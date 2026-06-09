namespace MockupVisProg
{
    partial class FormRiwayat
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
            this.panelSummary   = new System.Windows.Forms.Panel();
            this.lblTotal       = new System.Windows.Forms.Label();
            this.lblTerbesar    = new System.Windows.Forms.Label();
            this.lblCount       = new System.Windows.Forms.Label();
            this.lblFilterLabel = new System.Windows.Forms.Label();
            this.cboFilter      = new System.Windows.Forms.ComboBox();
            this.dgvExpenses    = new System.Windows.Forms.DataGridView();
            this.colID          = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDate        = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory    = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAmount      = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategoryID  = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHapus       = new System.Windows.Forms.Button();
            this.btnExportCsv   = new System.Windows.Forms.Button();
            this.btnKembali     = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.panelSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).BeginInit();
            this.SuspendLayout();

            // ── panelHeader ──────────────────────────────────────────
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(26, 26, 62);
            this.panelHeader.Controls.Add(this.lblHeader);
            this.panelHeader.Dock     = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name     = "panelHeader";
            this.panelHeader.Size     = new System.Drawing.Size(900, 50);
            this.panelHeader.TabIndex = 0;

            // lblHeader
            this.lblHeader.AutoSize  = false;
            this.lblHeader.Dock      = System.Windows.Forms.DockStyle.Fill;
            this.lblHeader.Font      = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Name      = "lblHeader";
            this.lblHeader.TabIndex  = 0;
            this.lblHeader.Text      = "Riwayat Pengeluaran";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ── panelSummary ─────────────────────────────────────────
            this.panelSummary.BackColor = System.Drawing.Color.FromArgb(26, 26, 62);
            this.panelSummary.Controls.Add(this.lblTotal);
            this.panelSummary.Controls.Add(this.lblTerbesar);
            this.panelSummary.Controls.Add(this.lblCount);
            this.panelSummary.Location = new System.Drawing.Point(10, 60);
            this.panelSummary.Name     = "panelSummary";
            this.panelSummary.Size     = new System.Drawing.Size(880, 55);
            this.panelSummary.TabIndex = 1;

            // lblTotal
            this.lblTotal.AutoSize  = false;
            this.lblTotal.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location  = new System.Drawing.Point(15, 17);
            this.lblTotal.Name      = "lblTotal";
            this.lblTotal.Size      = new System.Drawing.Size(250, 22);
            this.lblTotal.TabIndex  = 0;
            this.lblTotal.Text      = "Total: Rp 0";

            // lblTerbesar
            this.lblTerbesar.AutoSize  = false;
            this.lblTerbesar.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTerbesar.ForeColor = System.Drawing.Color.FromArgb(176, 176, 220);
            this.lblTerbesar.Location  = new System.Drawing.Point(295, 17);
            this.lblTerbesar.Name      = "lblTerbesar";
            this.lblTerbesar.Size      = new System.Drawing.Size(270, 22);
            this.lblTerbesar.TabIndex  = 1;
            this.lblTerbesar.Text      = "Terbesar: Rp 0";

            // lblCount
            this.lblCount.AutoSize  = false;
            this.lblCount.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCount.ForeColor = System.Drawing.Color.FromArgb(112, 112, 144);
            this.lblCount.Location  = new System.Drawing.Point(600, 17);
            this.lblCount.Name      = "lblCount";
            this.lblCount.Size      = new System.Drawing.Size(250, 22);
            this.lblCount.TabIndex  = 2;
            this.lblCount.Text      = "0 transaksi";
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            // ── Filter row ───────────────────────────────────────────
            this.lblFilterLabel.AutoSize  = false;
            this.lblFilterLabel.Font      = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFilterLabel.ForeColor = System.Drawing.Color.FromArgb(176, 176, 200);
            this.lblFilterLabel.Location  = new System.Drawing.Point(10, 132);
            this.lblFilterLabel.Name      = "lblFilterLabel";
            this.lblFilterLabel.Size      = new System.Drawing.Size(115, 22);
            this.lblFilterLabel.TabIndex  = 2;
            this.lblFilterLabel.Text      = "Filter Kategori:";
            this.lblFilterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.cboFilter.BackColor     = System.Drawing.Color.FromArgb(26, 26, 62);
            this.cboFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilter.FlatStyle     = System.Windows.Forms.FlatStyle.Flat;
            this.cboFilter.Font          = new System.Drawing.Font("Segoe UI", 10F);
            this.cboFilter.ForeColor     = System.Drawing.Color.White;
            this.cboFilter.Location      = new System.Drawing.Point(130, 130);
            this.cboFilter.Name          = "cboFilter";
            this.cboFilter.Size          = new System.Drawing.Size(160, 25);
            this.cboFilter.TabIndex      = 3;
            this.cboFilter.SelectedIndexChanged += new System.EventHandler(this.cboFilter_SelectedIndexChanged);

            // ── dgvExpenses ──────────────────────────────────────────
            this.dgvExpenses.AllowUserToAddRows          = false;
            this.dgvExpenses.AllowUserToDeleteRows       = false;
            this.dgvExpenses.AutoGenerateColumns         = false;
            this.dgvExpenses.BackgroundColor             = System.Drawing.Color.FromArgb(21, 21, 46);
            this.dgvExpenses.BorderStyle                 = System.Windows.Forms.BorderStyle.None;
            this.dgvExpenses.CellBorderStyle             = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvExpenses.GridColor                   = System.Drawing.Color.FromArgb(42, 42, 80);
            this.dgvExpenses.EnableHeadersVisualStyles   = false;
            this.dgvExpenses.MultiSelect                 = false;
            this.dgvExpenses.ReadOnly                    = true;
            this.dgvExpenses.RowHeadersVisible           = false;
            this.dgvExpenses.SelectionMode               = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExpenses.Location                    = new System.Drawing.Point(10, 168);
            this.dgvExpenses.Name                        = "dgvExpenses";
            this.dgvExpenses.Size                        = new System.Drawing.Size(880, 338);
            this.dgvExpenses.TabIndex                    = 4;

            // Column header style
            this.dgvExpenses.ColumnHeadersDefaultCellStyle.BackColor  = System.Drawing.Color.FromArgb(26, 26, 62);
            this.dgvExpenses.ColumnHeadersDefaultCellStyle.ForeColor  = System.Drawing.Color.White;
            this.dgvExpenses.ColumnHeadersDefaultCellStyle.Font       = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.dgvExpenses.ColumnHeadersDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(26, 26, 62);
            this.dgvExpenses.ColumnHeadersHeight                       = 32;
            this.dgvExpenses.ColumnHeadersHeightSizeMode               = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            // Default (odd) row style
            this.dgvExpenses.DefaultCellStyle.BackColor          = System.Drawing.Color.FromArgb(21, 21, 46);
            this.dgvExpenses.DefaultCellStyle.ForeColor          = System.Drawing.Color.FromArgb(192, 192, 224);
            this.dgvExpenses.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(91, 79, 207);
            this.dgvExpenses.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvExpenses.DefaultCellStyle.Font               = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgvExpenses.DefaultCellStyle.Padding            = new System.Windows.Forms.Padding(4, 0, 4, 0);

            // Alternating (even) row style
            this.dgvExpenses.AlternatingRowsDefaultCellStyle.BackColor          = System.Drawing.Color.FromArgb(26, 26, 62);
            this.dgvExpenses.AlternatingRowsDefaultCellStyle.ForeColor          = System.Drawing.Color.FromArgb(192, 192, 224);
            this.dgvExpenses.AlternatingRowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(91, 79, 207);
            this.dgvExpenses.AlternatingRowsDefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;

            this.dgvExpenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colID, this.colDate, this.colDescription,
                this.colCategory, this.colAmount, this.colCategoryID });

            // colID (hidden)
            this.colID.DataPropertyName = "ExpenseID";
            this.colID.HeaderText       = "ID";
            this.colID.Name             = "colID";
            this.colID.Visible          = false;

            // colDate
            this.colDate.DataPropertyName = "Date";
            this.colDate.HeaderText       = "Tanggal";
            this.colDate.Name             = "colDate";
            this.colDate.Width            = 110;
            this.colDate.DefaultCellStyle.Format = "dd/MM/yyyy";

            // colDescription
            this.colDescription.AutoSizeMode      = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDescription.DataPropertyName  = "Description";
            this.colDescription.HeaderText        = "Deskripsi";
            this.colDescription.Name              = "colDescription";

            // colCategory
            this.colCategory.DataPropertyName = "CategoryName";
            this.colCategory.HeaderText       = "Kategori";
            this.colCategory.Name             = "colCategory";
            this.colCategory.Width            = 130;

            // colAmount
            this.colAmount.DataPropertyName              = "Amount";
            this.colAmount.HeaderText                    = "Jumlah (Rp)";
            this.colAmount.Name                          = "colAmount";
            this.colAmount.Width                         = 140;
            this.colAmount.DefaultCellStyle.Format       = "N0";
            this.colAmount.DefaultCellStyle.Alignment    = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;

            // colCategoryID (hidden)
            this.colCategoryID.DataPropertyName = "CategoryID";
            this.colCategoryID.HeaderText       = "CategoryID";
            this.colCategoryID.Name             = "colCategoryID";
            this.colCategoryID.Visible          = false;

            // ── Buttons ──────────────────────────────────────────────
            this.btnHapus.BackColor              = System.Drawing.Color.FromArgb(58, 21, 21);
            this.btnHapus.FlatStyle              = System.Windows.Forms.FlatStyle.Flat;
            this.btnHapus.FlatAppearance.BorderSize = 0;
            this.btnHapus.Font                   = new System.Drawing.Font("Segoe UI", 10F);
            this.btnHapus.ForeColor              = System.Drawing.Color.White;
            this.btnHapus.Location               = new System.Drawing.Point(10, 520);
            this.btnHapus.Name                   = "btnHapus";
            this.btnHapus.Size                   = new System.Drawing.Size(100, 32);
            this.btnHapus.TabIndex               = 5;
            this.btnHapus.Text                   = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click                  += new System.EventHandler(this.btnHapus_Click);

            this.btnExportCsv.BackColor              = System.Drawing.Color.FromArgb(30, 30, 58);
            this.btnExportCsv.FlatStyle              = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportCsv.FlatAppearance.BorderSize = 0;
            this.btnExportCsv.Font                   = new System.Drawing.Font("Segoe UI", 10F);
            this.btnExportCsv.ForeColor              = System.Drawing.Color.White;
            this.btnExportCsv.Location               = new System.Drawing.Point(120, 520);
            this.btnExportCsv.Name                   = "btnExportCsv";
            this.btnExportCsv.Size                   = new System.Drawing.Size(130, 32);
            this.btnExportCsv.TabIndex               = 6;
            this.btnExportCsv.Text                   = "Export CSV";
            this.btnExportCsv.UseVisualStyleBackColor = false;
            this.btnExportCsv.Click                  += new System.EventHandler(this.btnExportCsv_Click);

            this.btnKembali.BackColor              = System.Drawing.Color.FromArgb(30, 30, 58);
            this.btnKembali.FlatStyle              = System.Windows.Forms.FlatStyle.Flat;
            this.btnKembali.FlatAppearance.BorderSize = 0;
            this.btnKembali.Font                   = new System.Drawing.Font("Segoe UI", 10F);
            this.btnKembali.ForeColor              = System.Drawing.Color.White;
            this.btnKembali.Location               = new System.Drawing.Point(780, 520);
            this.btnKembali.Name                   = "btnKembali";
            this.btnKembali.Size                   = new System.Drawing.Size(110, 32);
            this.btnKembali.TabIndex               = 7;
            this.btnKembali.Text                   = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = false;
            this.btnKembali.Click                  += new System.EventHandler(this.btnKembali_Click);

            // ── FormRiwayat ──────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.FromArgb(18, 18, 42);
            this.ClientSize          = new System.Drawing.Size(900, 570);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.btnExportCsv);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.dgvExpenses);
            this.Controls.Add(this.cboFilter);
            this.Controls.Add(this.lblFilterLabel);
            this.Controls.Add(this.panelSummary);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox     = false;
            this.Name            = "FormRiwayat";
            this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text            = "Riwayat Pengeluaran";
            this.Load           += new System.EventHandler(this.FormRiwayat_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelSummary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel panelSummary;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTerbesar;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblFilterLabel;
        private System.Windows.Forms.ComboBox cboFilter;
        private System.Windows.Forms.DataGridView dgvExpenses;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategoryID;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnExportCsv;
        private System.Windows.Forms.Button btnKembali;
    }
}
