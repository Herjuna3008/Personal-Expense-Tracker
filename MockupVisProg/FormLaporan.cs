using System;
using System.Data;
using System.Drawing;
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
            cboYear.Items.AddRange(
                Enumerable.Range(2023, currentYear - 2023 + 2).Cast<object>().ToArray());

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
                    var rows = _dt.AsEnumerable().Select(r => string.Join(",",
                        r.Field<DateTime>("Date").ToString("dd/MM/yyyy"),
                        (r.Field<string>("Description") ?? "").Replace(",", ";"),
                        r.Field<string>("Kategori"),
                        r.Field<decimal>("Amount")));

                    var lines = new[] { "Tanggal,Keterangan,Kategori,Jumlah" }
                        .Concat(rows)
                        .Concat(new[] { $",,Total,{_total}" });

                    File.WriteAllLines(dialog.FileName, lines, new UTF8Encoding(true));

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

            string periode = $"{cboMonth.Text} {(int)cboYear.SelectedItem}";

            // Crystal Report push model: nama tabel harus cocok dengan skema .xsd
            var data = _dt.Copy();
            data.TableName = "LaporanBulanan";

            using (var viewer = new FormLaporanViewer(data, periode))
            {
                viewer.ShowDialog(this);
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
