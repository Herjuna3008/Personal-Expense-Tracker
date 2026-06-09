namespace MockupVisProg
{
    partial class FormTambah
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
            this.panelHeader    = new System.Windows.Forms.Panel();
            this.lblHeader      = new System.Windows.Forms.Label();
            this.lblTanggal     = new System.Windows.Forms.Label();
            this.dtpDate        = new System.Windows.Forms.DateTimePicker();
            this.lblDeskripsi   = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblKategori    = new System.Windows.Forms.Label();
            this.cboCategory    = new System.Windows.Forms.ComboBox();
            this.lblJumlah      = new System.Windows.Forms.Label();
            this.txtAmount      = new System.Windows.Forms.TextBox();
            this.btnSimpan      = new System.Windows.Forms.Button();
            this.btnBatal       = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();

            // ── panelHeader ──────────────────────────────────────────
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(26, 26, 62);
            this.panelHeader.Controls.Add(this.lblHeader);
            this.panelHeader.Dock     = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name     = "panelHeader";
            this.panelHeader.Size     = new System.Drawing.Size(480, 50);
            this.panelHeader.TabIndex = 0;

            // lblHeader
            this.lblHeader.AutoSize  = false;
            this.lblHeader.Dock      = System.Windows.Forms.DockStyle.Fill;
            this.lblHeader.Font      = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Name      = "lblHeader";
            this.lblHeader.TabIndex  = 0;
            this.lblHeader.Text      = "Tambah Pengeluaran";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ── lblTanggal ───────────────────────────────────────────
            this.lblTanggal.AutoSize  = false;
            this.lblTanggal.Font      = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTanggal.ForeColor = System.Drawing.Color.FromArgb(176, 176, 200);
            this.lblTanggal.Location  = new System.Drawing.Point(30, 88);
            this.lblTanggal.Name      = "lblTanggal";
            this.lblTanggal.Size      = new System.Drawing.Size(110, 22);
            this.lblTanggal.TabIndex  = 1;
            this.lblTanggal.Text      = "Tanggal";
            this.lblTanggal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // ── dtpDate ──────────────────────────────────────────────
            this.dtpDate.CalendarForeColor        = System.Drawing.Color.White;
            this.dtpDate.CalendarMonthBackground  = System.Drawing.Color.FromArgb(26, 26, 62);
            this.dtpDate.CalendarTitleBackColor   = System.Drawing.Color.FromArgb(91, 79, 207);
            this.dtpDate.CalendarTitleForeColor   = System.Drawing.Color.White;
            this.dtpDate.CalendarTrailingForeColor= System.Drawing.Color.FromArgb(112, 112, 144);
            this.dtpDate.Font     = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpDate.Format   = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(150, 85);
            this.dtpDate.Name     = "dtpDate";
            this.dtpDate.Size     = new System.Drawing.Size(270, 23);
            this.dtpDate.TabIndex = 2;

            // ── lblDeskripsi ─────────────────────────────────────────
            this.lblDeskripsi.AutoSize  = false;
            this.lblDeskripsi.Font      = new System.Drawing.Font("Segoe UI", 10F);
            this.lblDeskripsi.ForeColor = System.Drawing.Color.FromArgb(176, 176, 200);
            this.lblDeskripsi.Location  = new System.Drawing.Point(30, 153);
            this.lblDeskripsi.Name      = "lblDeskripsi";
            this.lblDeskripsi.Size      = new System.Drawing.Size(110, 22);
            this.lblDeskripsi.TabIndex  = 3;
            this.lblDeskripsi.Text      = "Deskripsi";
            this.lblDeskripsi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // ── txtDescription ───────────────────────────────────────
            this.txtDescription.BackColor    = System.Drawing.Color.FromArgb(26, 26, 62);
            this.txtDescription.BorderStyle  = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescription.Font         = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDescription.ForeColor    = System.Drawing.Color.White;
            this.txtDescription.Location     = new System.Drawing.Point(150, 150);
            this.txtDescription.Name         = "txtDescription";
            this.txtDescription.Size         = new System.Drawing.Size(270, 23);
            this.txtDescription.TabIndex     = 4;

            // ── lblKategori ──────────────────────────────────────────
            this.lblKategori.AutoSize  = false;
            this.lblKategori.Font      = new System.Drawing.Font("Segoe UI", 10F);
            this.lblKategori.ForeColor = System.Drawing.Color.FromArgb(176, 176, 200);
            this.lblKategori.Location  = new System.Drawing.Point(30, 223);
            this.lblKategori.Name      = "lblKategori";
            this.lblKategori.Size      = new System.Drawing.Size(110, 22);
            this.lblKategori.TabIndex  = 5;
            this.lblKategori.Text      = "Kategori";
            this.lblKategori.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // ── cboCategory ──────────────────────────────────────────
            this.cboCategory.BackColor         = System.Drawing.Color.FromArgb(26, 26, 62);
            this.cboCategory.DropDownStyle     = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FlatStyle         = System.Windows.Forms.FlatStyle.Flat;
            this.cboCategory.Font              = new System.Drawing.Font("Segoe UI", 10F);
            this.cboCategory.ForeColor         = System.Drawing.Color.White;
            this.cboCategory.Location          = new System.Drawing.Point(150, 220);
            this.cboCategory.Name              = "cboCategory";
            this.cboCategory.Size              = new System.Drawing.Size(270, 25);
            this.cboCategory.TabIndex          = 6;

            // ── lblJumlah ────────────────────────────────────────────
            this.lblJumlah.AutoSize  = false;
            this.lblJumlah.Font      = new System.Drawing.Font("Segoe UI", 10F);
            this.lblJumlah.ForeColor = System.Drawing.Color.FromArgb(176, 176, 200);
            this.lblJumlah.Location  = new System.Drawing.Point(30, 293);
            this.lblJumlah.Name      = "lblJumlah";
            this.lblJumlah.Size      = new System.Drawing.Size(110, 22);
            this.lblJumlah.TabIndex  = 7;
            this.lblJumlah.Text      = "Jumlah (Rp)";
            this.lblJumlah.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // ── txtAmount ────────────────────────────────────────────
            this.txtAmount.BackColor   = System.Drawing.Color.FromArgb(26, 26, 62);
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmount.Font        = new System.Drawing.Font("Segoe UI", 10F);
            this.txtAmount.ForeColor   = System.Drawing.Color.White;
            this.txtAmount.Location    = new System.Drawing.Point(150, 290);
            this.txtAmount.Name        = "txtAmount";
            this.txtAmount.Size        = new System.Drawing.Size(270, 23);
            this.txtAmount.TabIndex    = 8;
            this.txtAmount.KeyPress   += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);

            // ── btnSimpan ────────────────────────────────────────────
            this.btnSimpan.BackColor              = System.Drawing.Color.FromArgb(91, 79, 207);
            this.btnSimpan.FlatStyle              = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimpan.FlatAppearance.BorderSize = 0;
            this.btnSimpan.Font                   = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSimpan.ForeColor              = System.Drawing.Color.White;
            this.btnSimpan.Location               = new System.Drawing.Point(150, 355);
            this.btnSimpan.Name                   = "btnSimpan";
            this.btnSimpan.Size                   = new System.Drawing.Size(120, 35);
            this.btnSimpan.TabIndex               = 9;
            this.btnSimpan.Text                   = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click                  += new System.EventHandler(this.btnSimpan_Click);

            // ── btnBatal ─────────────────────────────────────────────
            this.btnBatal.BackColor              = System.Drawing.Color.FromArgb(30, 30, 58);
            this.btnBatal.FlatStyle              = System.Windows.Forms.FlatStyle.Flat;
            this.btnBatal.FlatAppearance.BorderSize = 0;
            this.btnBatal.Font                   = new System.Drawing.Font("Segoe UI", 10F);
            this.btnBatal.ForeColor              = System.Drawing.Color.White;
            this.btnBatal.Location               = new System.Drawing.Point(290, 355);
            this.btnBatal.Name                   = "btnBatal";
            this.btnBatal.Size                   = new System.Drawing.Size(110, 35);
            this.btnBatal.TabIndex               = 10;
            this.btnBatal.Text                   = "Batal";
            this.btnBatal.UseVisualStyleBackColor = false;
            this.btnBatal.Click                  += new System.EventHandler(this.btnBatal_Click);

            // ── FormTambah ───────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.FromArgb(18, 18, 42);
            this.ClientSize          = new System.Drawing.Size(480, 420);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblJumlah);
            this.Controls.Add(this.cboCategory);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblDeskripsi);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblTanggal);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox     = false;
            this.Name            = "FormTambah";
            this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text            = "Tambah Pengeluaran";
            this.Load           += new System.EventHandler(this.FormTambah_Load);
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Label lblTanggal;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDeskripsi;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblJumlah;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBatal;
    }
}
