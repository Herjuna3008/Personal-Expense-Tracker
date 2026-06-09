using System.Windows.Forms.DataVisualization.Charting;

namespace MockupVisProg
{
    partial class FormLaporan
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            ChartArea chartArea1 = new ChartArea();
            Legend    legend1    = new Legend();
            Series    series1    = new Series();

            this.panelHeader   = new System.Windows.Forms.Panel();
            this.lblHeader     = new System.Windows.Forms.Label();
            this.panelFilter   = new System.Windows.Forms.Panel();
            this.lblBulan      = new System.Windows.Forms.Label();
            this.cboMonth      = new System.Windows.Forms.ComboBox();
            this.lblTahun      = new System.Windows.Forms.Label();
            this.cboYear       = new System.Windows.Forms.ComboBox();
            this.btnTampilkan  = new System.Windows.Forms.Button();
            this.btnExportCSV  = new System.Windows.Forms.Button();
            this.btnPrint      = new System.Windows.Forms.Button();
            this.btnKembali    = new System.Windows.Forms.Button();
            this.panelSummary  = new System.Windows.Forms.Panel();
            this.lblTotal      = new System.Windows.Forms.Label();
            this.lblCount      = new System.Windows.Forms.Label();
            this.lblKategori   = new System.Windows.Forms.Label();
            this.panelContent  = new System.Windows.Forms.Panel();
            this.panelChart    = new System.Windows.Forms.Panel();
            this.chartLaporan  = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelGrid     = new System.Windows.Forms.Panel();
            this.dgvLaporan    = new System.Windows.Forms.DataGridView();
            this.colTanggal    = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKeterangan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKategori   = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJumlah     = new System.Windows.Forms.DataGridViewTextBoxColumn();

            this.panelHeader.SuspendLayout();
            this.panelFilter.SuspendLayout();
            this.panelSummary.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartLaporan)).BeginInit();
            this.panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaporan)).BeginInit();
            this.SuspendLayout();

            // ── panelHeader ──────────────────────────────────────────
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(26, 26, 62);
            this.panelHeader.Controls.Add(this.lblHeader);
            this.panelHeader.Dock     = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Name     = "panelHeader";
            this.panelHeader.Size     = new System.Drawing.Size(900, 50);
            this.panelHeader.TabIndex = 0;

            this.lblHeader.AutoSize  = false;
            this.lblHeader.Font      = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Location  = new System.Drawing.Point(15, 0);
            this.lblHeader.Name      = "lblHeader";
            this.lblHeader.Size      = new System.Drawing.Size(870, 50);
            this.lblHeader.TabIndex  = 0;
            this.lblHeader.Text      = "Laporan Pengeluaran Bulanan";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // ── panelFilter ──────────────────────────────────────────
            this.panelFilter.BackColor = System.Drawing.Color.FromArgb(26, 26, 62);
            this.panelFilter.Controls.Add(this.lblBulan);
            this.panelFilter.Controls.Add(this.cboMonth);
            this.panelFilter.Controls.Add(this.lblTahun);
            this.panelFilter.Controls.Add(this.cboYear);
            this.panelFilter.Controls.Add(this.btnTampilkan);
            this.panelFilter.Controls.Add(this.btnExportCSV);
            this.panelFilter.Controls.Add(this.btnPrint);
            this.panelFilter.Controls.Add(this.btnKembali);
            this.panelFilter.Dock     = System.Windows.Forms.DockStyle.Top;
            this.panelFilter.Name     = "panelFilter";
            this.panelFilter.Size     = new System.Drawing.Size(900, 50);
            this.panelFilter.TabIndex = 1;

            this.lblBulan.AutoSize  = false;
            this.lblBulan.Font      = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBulan.ForeColor = System.Drawing.Color.White;
            this.lblBulan.Location  = new System.Drawing.Point(15, 15);
            this.lblBulan.Name      = "lblBulan";
            this.lblBulan.Size      = new System.Drawing.Size(46, 20);
            this.lblBulan.TabIndex  = 0;
            this.lblBulan.Text      = "Bulan:";

            this.cboMonth.BackColor     = System.Drawing.Color.FromArgb(18, 18, 42);
            this.cboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMonth.FlatStyle     = System.Windows.Forms.FlatStyle.Flat;
            this.cboMonth.Font          = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboMonth.ForeColor     = System.Drawing.Color.White;
            this.cboMonth.Items.AddRange(new object[] {
                "Januari","Februari","Maret","April","Mei","Juni",
                "Juli","Agustus","September","Oktober","November","Desember" });
            this.cboMonth.Location  = new System.Drawing.Point(65, 14);
            this.cboMonth.Name      = "cboMonth";
            this.cboMonth.Size      = new System.Drawing.Size(110, 23);
            this.cboMonth.TabIndex  = 1;

            this.lblTahun.AutoSize  = false;
            this.lblTahun.Font      = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTahun.ForeColor = System.Drawing.Color.White;
            this.lblTahun.Location  = new System.Drawing.Point(185, 15);
            this.lblTahun.Name      = "lblTahun";
            this.lblTahun.Size      = new System.Drawing.Size(46, 20);
            this.lblTahun.TabIndex  = 2;
            this.lblTahun.Text      = "Tahun:";

            this.cboYear.BackColor     = System.Drawing.Color.FromArgb(18, 18, 42);
            this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear.FlatStyle     = System.Windows.Forms.FlatStyle.Flat;
            this.cboYear.Font          = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cboYear.ForeColor     = System.Drawing.Color.White;
            this.cboYear.Location      = new System.Drawing.Point(235, 14);
            this.cboYear.Name          = "cboYear";
            this.cboYear.Size          = new System.Drawing.Size(75, 23);
            this.cboYear.TabIndex      = 3;

            this.btnTampilkan.BackColor                = System.Drawing.Color.FromArgb(91, 79, 207);
            this.btnTampilkan.FlatStyle                = System.Windows.Forms.FlatStyle.Flat;
            this.btnTampilkan.FlatAppearance.BorderSize = 0;
            this.btnTampilkan.Font                     = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnTampilkan.ForeColor                = System.Drawing.Color.White;
            this.btnTampilkan.Location                 = new System.Drawing.Point(328, 10);
            this.btnTampilkan.Name                     = "btnTampilkan";
            this.btnTampilkan.Size                     = new System.Drawing.Size(90, 30);
            this.btnTampilkan.TabIndex                 = 4;
            this.btnTampilkan.Text                     = "Tampilkan";
            this.btnTampilkan.UseVisualStyleBackColor  = false;
            this.btnTampilkan.Click                   += new System.EventHandler(this.btnTampilkan_Click);

            this.btnExportCSV.BackColor                = System.Drawing.Color.FromArgb(30, 58, 32);
            this.btnExportCSV.FlatStyle                = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportCSV.FlatAppearance.BorderSize = 0;
            this.btnExportCSV.Font                     = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExportCSV.ForeColor                = System.Drawing.Color.FromArgb(76, 175, 132);
            this.btnExportCSV.Location                 = new System.Drawing.Point(428, 10);
            this.btnExportCSV.Name                     = "btnExportCSV";
            this.btnExportCSV.Size                     = new System.Drawing.Size(90, 30);
            this.btnExportCSV.TabIndex                 = 5;
            this.btnExportCSV.Text                     = "Export CSV";
            this.btnExportCSV.UseVisualStyleBackColor  = false;
            this.btnExportCSV.Click                   += new System.EventHandler(this.btnExportCSV_Click);

            this.btnPrint.BackColor                = System.Drawing.Color.FromArgb(30, 42, 58);
            this.btnPrint.FlatStyle                = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.Font                     = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPrint.ForeColor                = System.Drawing.Color.FromArgb(96, 144, 208);
            this.btnPrint.Location                 = new System.Drawing.Point(528, 10);
            this.btnPrint.Name                     = "btnPrint";
            this.btnPrint.Size                     = new System.Drawing.Size(100, 30);
            this.btnPrint.TabIndex                 = 6;
            this.btnPrint.Text                     = "Print Preview";
            this.btnPrint.UseVisualStyleBackColor  = false;
            this.btnPrint.Click                   += new System.EventHandler(this.btnPrint_Click);

            this.btnKembali.BackColor                = System.Drawing.Color.FromArgb(30, 30, 58);
            this.btnKembali.FlatStyle                = System.Windows.Forms.FlatStyle.Flat;
            this.btnKembali.FlatAppearance.BorderSize = 0;
            this.btnKembali.Font                     = new System.Drawing.Font("Segoe UI", 9F);
            this.btnKembali.ForeColor                = System.Drawing.Color.FromArgb(128, 128, 176);
            this.btnKembali.Location                 = new System.Drawing.Point(810, 10);
            this.btnKembali.Name                     = "btnKembali";
            this.btnKembali.Size                     = new System.Drawing.Size(80, 30);
            this.btnKembali.TabIndex                 = 7;
            this.btnKembali.Text                     = "← Kembali";
            this.btnKembali.UseVisualStyleBackColor  = false;
            this.btnKembali.Click                   += new System.EventHandler(this.btnKembali_Click);

            // ── panelSummary ─────────────────────────────────────────
            this.panelSummary.BackColor = System.Drawing.Color.FromArgb(26, 26, 62);
            this.panelSummary.Controls.Add(this.lblTotal);
            this.panelSummary.Controls.Add(this.lblCount);
            this.panelSummary.Controls.Add(this.lblKategori);
            this.panelSummary.Dock     = System.Windows.Forms.DockStyle.Top;
            this.panelSummary.Name     = "panelSummary";
            this.panelSummary.Size     = new System.Drawing.Size(900, 55);
            this.panelSummary.TabIndex = 2;

            this.lblTotal.AutoSize  = false;
            this.lblTotal.Font      = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location  = new System.Drawing.Point(20, 14);
            this.lblTotal.Name      = "lblTotal";
            this.lblTotal.Size      = new System.Drawing.Size(260, 26);
            this.lblTotal.TabIndex  = 0;
            this.lblTotal.Text      = "Total: Rp 0";

            this.lblCount.AutoSize  = false;
            this.lblCount.Font      = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCount.ForeColor = System.Drawing.Color.FromArgb(144, 144, 192);
            this.lblCount.Location  = new System.Drawing.Point(300, 17);
            this.lblCount.Name      = "lblCount";
            this.lblCount.Size      = new System.Drawing.Size(180, 22);
            this.lblCount.TabIndex  = 1;
            this.lblCount.Text      = "0 transaksi";

            this.lblKategori.AutoSize  = false;
            this.lblKategori.Font      = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblKategori.ForeColor = System.Drawing.Color.FromArgb(144, 144, 192);
            this.lblKategori.Location  = new System.Drawing.Point(498, 18);
            this.lblKategori.Name      = "lblKategori";
            this.lblKategori.Size      = new System.Drawing.Size(390, 20);
            this.lblKategori.TabIndex  = 2;
            this.lblKategori.Text      = "Kategori terbanyak: -";

            // ── panelContent (Dock=Fill) ─────────────────────────────
            // Controls.Add: panelGrid (Fill) first, panelChart (Right) last
            // so docking processes panelChart before panelGrid
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(18, 18, 42);
            this.panelContent.Controls.Add(this.panelGrid);
            this.panelContent.Controls.Add(this.panelChart);
            this.panelContent.Dock     = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Name     = "panelContent";
            this.panelContent.TabIndex = 3;

            // ── panelChart (Dock=Right, 360px) ───────────────────────
            this.panelChart.BackColor = System.Drawing.Color.FromArgb(26, 26, 62);
            this.panelChart.Controls.Add(this.chartLaporan);
            this.panelChart.Dock      = System.Windows.Forms.DockStyle.Right;
            this.panelChart.Name      = "panelChart";
            this.panelChart.Width     = 360;
            this.panelChart.TabIndex  = 1;

            // ── chartLaporan ─────────────────────────────────────────
            chartArea1.Name      = "ChartArea1";
            chartArea1.BackColor = System.Drawing.Color.FromArgb(18, 18, 42);

            legend1.Name      = "Legend1";
            legend1.BackColor = System.Drawing.Color.FromArgb(26, 26, 62);
            legend1.ForeColor = System.Drawing.Color.FromArgb(192, 192, 224);
            legend1.Docking   = Docking.Bottom;
            legend1.Font      = new System.Drawing.Font("Segoe UI", 8.5F);
            legend1.Alignment = System.Drawing.StringAlignment.Center;

            series1.Name          = "Series1";
            series1.ChartType     = SeriesChartType.Pie;

            this.chartLaporan.BackColor = System.Drawing.Color.FromArgb(26, 26, 62);
            this.chartLaporan.ChartAreas.Add(chartArea1);
            this.chartLaporan.Legends.Add(legend1);
            this.chartLaporan.Series.Add(series1);
            this.chartLaporan.Dock     = System.Windows.Forms.DockStyle.Fill;
            this.chartLaporan.Name     = "chartLaporan";
            this.chartLaporan.TabIndex = 0;

            // ── panelGrid (Dock=Fill) ────────────────────────────────
            this.panelGrid.BackColor = System.Drawing.Color.FromArgb(18, 18, 42);
            this.panelGrid.Controls.Add(this.dgvLaporan);
            this.panelGrid.Dock      = System.Windows.Forms.DockStyle.Fill;
            this.panelGrid.Name      = "panelGrid";
            this.panelGrid.TabIndex  = 0;

            // ── dgvLaporan ───────────────────────────────────────────
            this.dgvLaporan.AllowUserToAddRows    = false;
            this.dgvLaporan.AllowUserToDeleteRows = false;
            this.dgvLaporan.AutoGenerateColumns   = false;
            this.dgvLaporan.BackgroundColor       = System.Drawing.Color.FromArgb(21, 21, 46);
            this.dgvLaporan.BorderStyle           = System.Windows.Forms.BorderStyle.None;
            this.dgvLaporan.CellBorderStyle       = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLaporan.GridColor             = System.Drawing.Color.FromArgb(42, 42, 80);
            this.dgvLaporan.EnableHeadersVisualStyles = false;
            this.dgvLaporan.MultiSelect           = false;
            this.dgvLaporan.ReadOnly              = true;
            this.dgvLaporan.RowHeadersVisible     = false;
            this.dgvLaporan.SelectionMode         = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLaporan.Dock                  = System.Windows.Forms.DockStyle.Fill;
            this.dgvLaporan.Name                  = "dgvLaporan";
            this.dgvLaporan.TabIndex              = 0;
            this.dgvLaporan.RowTemplate.Height    = 28;

            this.dgvLaporan.ColumnHeadersDefaultCellStyle.BackColor          = System.Drawing.Color.FromArgb(26, 26, 62);
            this.dgvLaporan.ColumnHeadersDefaultCellStyle.ForeColor          = System.Drawing.Color.White;
            this.dgvLaporan.ColumnHeadersDefaultCellStyle.Font               = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.dgvLaporan.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(26, 26, 62);
            this.dgvLaporan.ColumnHeadersHeight                              = 32;
            this.dgvLaporan.ColumnHeadersHeightSizeMode                      = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            this.dgvLaporan.DefaultCellStyle.BackColor          = System.Drawing.Color.FromArgb(21, 21, 46);
            this.dgvLaporan.DefaultCellStyle.ForeColor          = System.Drawing.Color.FromArgb(192, 192, 224);
            this.dgvLaporan.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(91, 79, 207);
            this.dgvLaporan.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvLaporan.DefaultCellStyle.Font               = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgvLaporan.DefaultCellStyle.Padding            = new System.Windows.Forms.Padding(4, 0, 4, 0);

            this.dgvLaporan.AlternatingRowsDefaultCellStyle.BackColor          = System.Drawing.Color.FromArgb(26, 26, 62);
            this.dgvLaporan.AlternatingRowsDefaultCellStyle.ForeColor          = System.Drawing.Color.FromArgb(192, 192, 224);
            this.dgvLaporan.AlternatingRowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(91, 79, 207);
            this.dgvLaporan.AlternatingRowsDefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;

            // DataPropertyName maps to the actual SQL column names returned by GetExpensesByMonth:
            // e.Date → "Date", e.Description → "Description", c.Name AS Kategori → "Kategori", e.Amount → "Amount"
            this.colTanggal.DataPropertyName        = "Date";
            this.colTanggal.DefaultCellStyle.Format = "dd/MM/yyyy";
            this.colTanggal.HeaderText              = "Tanggal";
            this.colTanggal.Name                    = "colTanggal";
            this.colTanggal.Width                   = 90;

            this.colKeterangan.AutoSizeMode     = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colKeterangan.DataPropertyName = "Description";
            this.colKeterangan.HeaderText       = "Keterangan";
            this.colKeterangan.Name             = "colKeterangan";

            this.colKategori.DataPropertyName = "Kategori";
            this.colKategori.HeaderText       = "Kategori";
            this.colKategori.Name             = "colKategori";
            this.colKategori.Width            = 100;

            this.colJumlah.DataPropertyName             = "Amount";
            this.colJumlah.DefaultCellStyle.Alignment   = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colJumlah.HeaderText                   = "Jumlah";
            this.colJumlah.Name                         = "colJumlah";
            this.colJumlah.Width                        = 110;

            this.dgvLaporan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colTanggal, this.colKeterangan, this.colKategori, this.colJumlah });

            this.dgvLaporan.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvLaporan_CellFormatting);

            // ── FormLaporan ──────────────────────────────────────────
            // Controls.Add: panelContent (Fill) first, then Dock=Top panels
            // in reverse visual order so last-added docks topmost
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.FromArgb(18, 18, 42);
            this.ClientSize          = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelSummary);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox     = false;
            this.Name            = "FormLaporan";
            this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text            = "Laporan Pengeluaran";
            this.Load           += new System.EventHandler(this.FormLaporan_Load);

            this.panelHeader.ResumeLayout(false);
            this.panelFilter.ResumeLayout(false);
            this.panelSummary.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.panelChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartLaporan)).EndInit();
            this.panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLaporan)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel    panelHeader;
        private System.Windows.Forms.Label    lblHeader;
        private System.Windows.Forms.Panel    panelFilter;
        private System.Windows.Forms.Label    lblBulan;
        private System.Windows.Forms.ComboBox cboMonth;
        private System.Windows.Forms.Label    lblTahun;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.Button   btnTampilkan;
        private System.Windows.Forms.Button   btnExportCSV;
        private System.Windows.Forms.Button   btnPrint;
        private System.Windows.Forms.Button   btnKembali;
        private System.Windows.Forms.Panel    panelSummary;
        private System.Windows.Forms.Label    lblTotal;
        private System.Windows.Forms.Label    lblCount;
        private System.Windows.Forms.Label    lblKategori;
        private System.Windows.Forms.Panel    panelContent;
        private System.Windows.Forms.Panel    panelChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartLaporan;
        private System.Windows.Forms.Panel    panelGrid;
        private System.Windows.Forms.DataGridView              dgvLaporan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTanggal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKeterangan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKategori;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJumlah;
    }
}
