using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MockupVisProg.Database;
using MockupVisProg.Models;

namespace MockupVisProg
{
    public partial class FormLaporan : Form
    {
        private static readonly Color[] SliceColors = {
            Color.FromArgb( 91,  79, 207),
            Color.FromArgb( 64, 196, 160),
            Color.FromArgb(255, 170,  64),
            Color.FromArgb(255,  80,  80),
            Color.FromArgb( 80, 160, 255),
            Color.FromArgb(200, 100, 220),
        };

        private DataTable _dt = new DataTable();
        private decimal   _total = 0;
        private int       _printRowIndex = 0;

        public FormLaporan()
        {
            InitializeComponent();
        }

        // ── Lifecycle ────────────────────────────────────────────────

        private void FormLaporan_Load(object sender, EventArgs e)
        {
            if (!Session.IsLoggedIn)
            {
                new FormLogin().Show();
                this.Close();
                return;
            }

            int currentYear = DateTime.Now.Year;
            for (int y = 2023; y <= currentYear + 1; y++)
                cboYear.Items.Add(y);

            cboMonth.SelectedIndex = DateTime.Now.Month - 1;
            cboYear.SelectedItem   = currentYear;

            LoadReport();
        }

        // ── Report loading ───────────────────────────────────────────

        private void LoadReport()
        {
            int month = cboMonth.SelectedIndex + 1;
            int year  = (int)cboYear.SelectedItem;

            _dt = DbHelper.GetExpensesByMonth(month, year, Session.CurrentUser.UserID);

            dgvLaporan.DataSource = null;
            dgvLaporan.DataSource = _dt;

            if (_dt.Rows.Count == 0)
            {
                _total = 0;
                lblTotal.Text    = "Total: Rp 0";
                lblCount.Text    = "0 transaksi";
                lblKategori.Text = "Kategori terbanyak: -";
                ClearChart();
                return;
            }

            _total = _dt.AsEnumerable().Sum(r => r.Field<decimal>("Amount"));

            int     days = DateTime.DaysInMonth(year, month);
            decimal avg  = _total / days;

            lblTotal.Text = $"Total: Rp {_total:N0}   Avg/hari: Rp {avg:N0}";
            lblCount.Text = $"{_dt.Rows.Count} transaksi";

            string topCategory = _dt.AsEnumerable()
                .GroupBy(r => r.Field<string>("Kategori"))
                .OrderByDescending(g => g.Sum(r => r.Field<decimal>("Amount")))
                .Select(g => g.Key)
                .FirstOrDefault() ?? "-";

            lblKategori.Text = $"Kategori terbanyak: {topCategory}";

            UpdateChart();
        }

        // ── Chart ────────────────────────────────────────────────────

        private void ClearChart()
        {
            chartLaporan.Series["Series1"].Points.Clear();
        }

        private void UpdateChart()
        {
            var series = chartLaporan.Series["Series1"];
            series.Points.Clear();

            if (_dt.Rows.Count == 0) return;

            var groups = _dt.AsEnumerable()
                .GroupBy(r => r.Field<string>("Kategori"))
                .Select(g => new {
                    Name  = g.Key,
                    Total = g.Sum(r => r.Field<decimal>("Amount"))
                })
                .OrderByDescending(x => x.Total)
                .ToList();

            double grandTotal = (double)_total;

            for (int i = 0; i < groups.Count; i++)
            {
                double pct = grandTotal > 0 ? (double)groups[i].Total / grandTotal * 100 : 0;
                var    pt  = series.Points.Add((double)groups[i].Total);

                pt.LegendText = $"{groups[i].Name}  ({pct:F1}%)";
                pt.Color       = SliceColors[i % SliceColors.Length];
                pt.BorderColor = Color.FromArgb(18, 18, 42);
                pt.BorderWidth = 2;
            }

            // configure chart area style
            var ca = chartLaporan.ChartAreas["ChartArea1"];
            ca.BackColor = Color.FromArgb(18, 18, 42);

            series["PieLabelStyle"]    = "Outside";
            series["PieLineColor"]     = "Silver";
            series.IsValueShownAsLabel = false;
            series.Font                = new Font("Segoe UI", 8F);
            series.LabelForeColor      = Color.White;
        }

        // ── CellFormatting ───────────────────────────────────────────

        private void dgvLaporan_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvLaporan.Columns[e.ColumnIndex].Name == "colJumlah" && e.Value != null)
            {
                if (decimal.TryParse(e.Value.ToString(), out decimal amount))
                {
                    e.Value             = $"Rp {amount:N0}";
                    e.FormattingApplied = true;
                }
            }
        }

        // ── Button handlers ──────────────────────────────────────────

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void btnExportCSV_Click(object sender, EventArgs e)
        {
            if (_dt == null || _dt.Rows.Count == 0)
            {
                MessageBox.Show("Tidak ada data untuk diekspor.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int month = cboMonth.SelectedIndex + 1;
            int year  = (int)cboYear.SelectedItem;

            using (var dialog = new SaveFileDialog())
            {
                dialog.Filter   = "CSV File|*.csv";
                dialog.FileName = $"Laporan_{month}_{year}";

                if (dialog.ShowDialog() != DialogResult.OK) return;

                try
                {
                    using (var writer = new StreamWriter(dialog.FileName, false, new UTF8Encoding(true)))
                    {
                        writer.WriteLine("Tanggal,Keterangan,Kategori,Jumlah");

                        foreach (DataRow row in _dt.Rows)
                        {
                            string tanggal    = Convert.ToDateTime(row["Date"]).ToString("dd/MM/yyyy");
                            string keterangan = (row["Description"] == DBNull.Value
                                                    ? ""
                                                    : row["Description"].ToString()).Replace(",", ";");
                            string kategori   = row["Kategori"].ToString();
                            string jumlah     = row["Amount"].ToString();

                            writer.WriteLine($"{tanggal},{keterangan},{kategori},{jumlah}");
                        }

                        writer.WriteLine($",,Total,{_total}");
                    }

                    MessageBox.Show($"Data berhasil diekspor ke:\n{dialog.FileName}",
                        "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menyimpan file: " + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (_dt == null || _dt.Rows.Count == 0)
            {
                MessageBox.Show("Tidak ada data untuk dicetak.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _printRowIndex = 0;

            var doc = new PrintDocument();
            doc.DefaultPageSettings.Margins = new Margins(60, 60, 60, 60);
            doc.PrintPage += PrintPage;

            using (var preview = new PrintPreviewDialog())
            {
                preview.Document    = doc;
                preview.WindowState = FormWindowState.Maximized;
                preview.ShowDialog(this);
            }
        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g     = e.Graphics;
            int      left  = e.MarginBounds.Left;
            int      right = e.MarginBounds.Right;
            int      width = e.MarginBounds.Width;
            float    y     = e.MarginBounds.Top;
            int      year  = (int)cboYear.SelectedItem;

            // ── Header (first page only) ─────────────────────────────
            if (_printRowIndex == 0)
            {
                var titleFont    = new Font("Segoe UI", 14, FontStyle.Bold);
                var subtitleFont = new Font("Segoe UI", 9,  FontStyle.Regular);

                string title    = "Laporan Pengeluaran Bulanan";
                string subtitle = $"{cboMonth.Text} {year}  —  {Session.CurrentUser.Username}";

                SizeF ts = g.MeasureString(title, titleFont);
                g.DrawString(title,    titleFont,    Brushes.Black,   left + (width - ts.Width) / 2, y);
                y += ts.Height + 4;

                SizeF ss = g.MeasureString(subtitle, subtitleFont);
                g.DrawString(subtitle, subtitleFont, Brushes.DimGray, left + (width - ss.Width) / 2, y);
                y += ss.Height + 8;

                g.DrawLine(Pens.Black, left, y, right, y);
                y += 10;

                titleFont.Dispose();
                subtitleFont.Dispose();
            }

            // ── Column layout ────────────────────────────────────────
            int cw0 = 90, cw2 = 110, cw3 = 110;
            int cw1 = width - cw0 - cw2 - cw3;
            int x0  = left, x1 = x0 + cw0, x2 = x1 + cw1, x3 = x2 + cw2;

            var headerFont = new Font("Segoe UI", 9, FontStyle.Bold);
            var cellFont   = new Font("Segoe UI", 9);
            var rightFmt   = new StringFormat { Alignment = StringAlignment.Far };

            // ── Column headers ───────────────────────────────────────
            if (_printRowIndex == 0)
            {
                g.FillRectangle(new SolidBrush(Color.FromArgb(220, 220, 235)), left, y, width, 20);
                g.DrawString("Tanggal",    headerFont, Brushes.Black, x0, y + 3);
                g.DrawString("Keterangan", headerFont, Brushes.Black, x1, y + 3);
                g.DrawString("Kategori",   headerFont, Brushes.Black, x2, y + 3);
                g.DrawString("Jumlah",     headerFont, Brushes.Black,
                    new RectangleF(x3, y + 3, cw3, 20), rightFmt);
                y += 22;
            }

            float rowH = cellFont.GetHeight(g) + 4;

            // ── Data rows ────────────────────────────────────────────
            while (_printRowIndex < _dt.Rows.Count)
            {
                if (y + rowH > e.MarginBounds.Bottom - 30)
                {
                    e.HasMorePages = true;
                    headerFont.Dispose();
                    cellFont.Dispose();
                    return;
                }

                DataRow row       = _dt.Rows[_printRowIndex];
                string  tanggal   = Convert.ToDateTime(row["Date"]).ToString("dd/MM/yyyy");
                string  keterangan = row["Description"] == DBNull.Value ? "" : row["Description"].ToString();
                string  kategori  = row["Kategori"].ToString();
                string  jumlah    = $"Rp {Convert.ToDecimal(row["Amount"]):N0}";

                if (_printRowIndex % 2 == 1)
                    g.FillRectangle(new SolidBrush(Color.FromArgb(240, 240, 248)), left, y, width, rowH);

                g.DrawString(tanggal,    cellFont, Brushes.Black, x0, y + 2);
                g.DrawString(keterangan, cellFont, Brushes.Black, x1, y + 2);
                g.DrawString(kategori,   cellFont, Brushes.Black, x2, y + 2);
                g.DrawString(jumlah,     cellFont, Brushes.Black,
                    new RectangleF(x3, y + 2, cw3, rowH), rightFmt);

                y += rowH;
                _printRowIndex++;
            }

            // ── Total row ────────────────────────────────────────────
            y += 6;
            g.DrawLine(Pens.Black, left, y, right, y);
            y += 4;
            g.DrawString($"Total: Rp {_total:N0}", headerFont, Brushes.Black,
                new RectangleF(left, y, width, 20), rightFmt);

            e.HasMorePages = false;
            headerFont.Dispose();
            cellFont.Dispose();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
