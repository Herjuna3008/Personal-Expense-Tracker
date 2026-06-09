namespace MockupVisProg
{
    partial class Form1
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
            this.menuStrip1     = new System.Windows.Forms.MenuStrip();
            this.tsmiAkun       = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRegistrasi = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMasukAkun  = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSeparator  = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiLogout     = new System.Windows.Forms.ToolStripMenuItem();
            this.tslSpacer      = new System.Windows.Forms.ToolStripLabel();
            this.lblWelcome     = new System.Windows.Forms.ToolStripLabel();
            this.panelNav1      = new System.Windows.Forms.Panel();
            this.lblNav1Title   = new System.Windows.Forms.Label();
            this.lblNav1Sub     = new System.Windows.Forms.Label();
            this.panelNav2      = new System.Windows.Forms.Panel();
            this.lblNav2Title   = new System.Windows.Forms.Label();
            this.lblNav2Sub     = new System.Windows.Forms.Label();
            this.panelNav3      = new System.Windows.Forms.Panel();
            this.lblNav3Title   = new System.Windows.Forms.Label();
            this.lblNav3Sub     = new System.Windows.Forms.Label();
            this.panelNav4      = new System.Windows.Forms.Panel();
            this.lblNav4Title   = new System.Windows.Forms.Label();
            this.lblNav4Sub     = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panelNav1.SuspendLayout();
            this.panelNav2.SuspendLayout();
            this.panelNav3.SuspendLayout();
            this.panelNav4.SuspendLayout();
            this.SuspendLayout();

            // ── menuStrip1 ───────────────────────────────────────────
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(26, 26, 62);
            this.menuStrip1.ForeColor = System.Drawing.Color.FromArgb(144, 144, 192);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.tsmiAkun,
                this.tslSpacer,
                this.lblWelcome });
            this.menuStrip1.Location   = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name       = "menuStrip1";
            this.menuStrip1.Padding    = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size       = new System.Drawing.Size(900, 26);
            this.menuStrip1.TabIndex   = 0;

            // ── tsmiAkun ─────────────────────────────────────────────
            this.tsmiAkun.BackColor = System.Drawing.Color.FromArgb(26, 26, 62);
            this.tsmiAkun.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.tsmiRegistrasi,
                this.tsmiMasukAkun,
                this.tsmiSeparator,
                this.tsmiLogout });
            this.tsmiAkun.ForeColor = System.Drawing.Color.FromArgb(144, 144, 192);
            this.tsmiAkun.Name      = "tsmiAkun";
            this.tsmiAkun.Text      = "Akun";

            // tsmiRegistrasi
            this.tsmiRegistrasi.BackColor = System.Drawing.Color.FromArgb(26, 26, 62);
            this.tsmiRegistrasi.ForeColor = System.Drawing.Color.FromArgb(144, 144, 192);
            this.tsmiRegistrasi.Name      = "tsmiRegistrasi";
            this.tsmiRegistrasi.Text      = "Registrasi";
            this.tsmiRegistrasi.Click    += new System.EventHandler(this.tsmiRegistrasi_Click);

            // tsmiMasukAkun
            this.tsmiMasukAkun.BackColor = System.Drawing.Color.FromArgb(26, 26, 62);
            this.tsmiMasukAkun.ForeColor = System.Drawing.Color.FromArgb(144, 144, 192);
            this.tsmiMasukAkun.Name      = "tsmiMasukAkun";
            this.tsmiMasukAkun.Text      = "Masuk Akun";
            this.tsmiMasukAkun.Click    += new System.EventHandler(this.tsmiMasukAkun_Click);

            // tsmiSeparator
            this.tsmiSeparator.BackColor = System.Drawing.Color.FromArgb(26, 26, 62);
            this.tsmiSeparator.ForeColor = System.Drawing.Color.FromArgb(60, 60, 90);
            this.tsmiSeparator.Name      = "tsmiSeparator";

            // tsmiLogout
            this.tsmiLogout.BackColor = System.Drawing.Color.FromArgb(26, 26, 62);
            this.tsmiLogout.ForeColor = System.Drawing.Color.FromArgb(210, 80, 80);
            this.tsmiLogout.Name      = "tsmiLogout";
            this.tsmiLogout.Text      = "Logout";
            this.tsmiLogout.Click    += new System.EventHandler(this.tsmiLogout_Click);

            // ── tslSpacer (pushes welcome label to the right) ─────────
            this.tslSpacer.Name   = "tslSpacer";
            this.tslSpacer.Text   = string.Empty;

            // ── lblWelcome (ToolStripLabel, right-aligned) ────────────
            this.lblWelcome.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(112, 112, 160);
            this.lblWelcome.Name      = "lblWelcome";
            this.lblWelcome.Padding   = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.lblWelcome.Text      = "Halo, ...";

            // ── panelNav1  (+Tambah, purple) ──────────────────────────
            this.panelNav1.BackColor   = System.Drawing.Color.FromArgb(91, 79, 207);
            this.panelNav1.Controls.Add(this.lblNav1Title);
            this.panelNav1.Controls.Add(this.lblNav1Sub);
            this.panelNav1.Cursor      = System.Windows.Forms.Cursors.Hand;
            this.panelNav1.Location    = new System.Drawing.Point(60, 160);
            this.panelNav1.Name        = "panelNav1";
            this.panelNav1.Size        = new System.Drawing.Size(380, 140);
            this.panelNav1.TabIndex    = 1;
            this.panelNav1.Click       += new System.EventHandler(this.panelNav1_Click);
            this.panelNav1.MouseEnter  += new System.EventHandler(this.panelNav1_MouseEnter);
            this.panelNav1.MouseLeave  += new System.EventHandler(this.panelNav1_MouseLeave);

            this.lblNav1Title.AutoSize  = false;
            this.lblNav1Title.Font      = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblNav1Title.ForeColor = System.Drawing.Color.White;
            this.lblNav1Title.Location  = new System.Drawing.Point(0, 35);
            this.lblNav1Title.Name      = "lblNav1Title";
            this.lblNav1Title.Size      = new System.Drawing.Size(380, 35);
            this.lblNav1Title.TabIndex  = 0;
            this.lblNav1Title.Text      = "+ Tambah Pengeluaran";
            this.lblNav1Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNav1Title.Click      += new System.EventHandler(this.panelNav1_Click);
            this.lblNav1Title.MouseEnter += new System.EventHandler(this.panelNav1_MouseEnter);
            this.lblNav1Title.MouseLeave += new System.EventHandler(this.panelNav1_MouseLeave);

            this.lblNav1Sub.AutoSize  = false;
            this.lblNav1Sub.Font      = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNav1Sub.ForeColor = System.Drawing.Color.FromArgb(112, 112, 144);
            this.lblNav1Sub.Location  = new System.Drawing.Point(0, 78);
            this.lblNav1Sub.Name      = "lblNav1Sub";
            this.lblNav1Sub.Size      = new System.Drawing.Size(380, 28);
            this.lblNav1Sub.TabIndex  = 1;
            this.lblNav1Sub.Text      = "Catat pengeluaran baru";
            this.lblNav1Sub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNav1Sub.Click      += new System.EventHandler(this.panelNav1_Click);
            this.lblNav1Sub.MouseEnter += new System.EventHandler(this.panelNav1_MouseEnter);
            this.lblNav1Sub.MouseLeave += new System.EventHandler(this.panelNav1_MouseLeave);

            // ── panelNav2  (Riwayat, dark) ────────────────────────────
            this.panelNav2.BackColor   = System.Drawing.Color.FromArgb(30, 30, 58);
            this.panelNav2.Controls.Add(this.lblNav2Title);
            this.panelNav2.Controls.Add(this.lblNav2Sub);
            this.panelNav2.Cursor      = System.Windows.Forms.Cursors.Hand;
            this.panelNav2.Location    = new System.Drawing.Point(460, 160);
            this.panelNav2.Name        = "panelNav2";
            this.panelNav2.Size        = new System.Drawing.Size(380, 140);
            this.panelNav2.TabIndex    = 2;
            this.panelNav2.Click       += new System.EventHandler(this.panelNav2_Click);
            this.panelNav2.MouseEnter  += new System.EventHandler(this.panelNav2_MouseEnter);
            this.panelNav2.MouseLeave  += new System.EventHandler(this.panelNav2_MouseLeave);

            this.lblNav2Title.AutoSize  = false;
            this.lblNav2Title.Font      = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblNav2Title.ForeColor = System.Drawing.Color.White;
            this.lblNav2Title.Location  = new System.Drawing.Point(0, 35);
            this.lblNav2Title.Name      = "lblNav2Title";
            this.lblNav2Title.Size      = new System.Drawing.Size(380, 35);
            this.lblNav2Title.TabIndex  = 0;
            this.lblNav2Title.Text      = "\U0001F4CB Riwayat";
            this.lblNav2Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNav2Title.Click      += new System.EventHandler(this.panelNav2_Click);
            this.lblNav2Title.MouseEnter += new System.EventHandler(this.panelNav2_MouseEnter);
            this.lblNav2Title.MouseLeave += new System.EventHandler(this.panelNav2_MouseLeave);

            this.lblNav2Sub.AutoSize  = false;
            this.lblNav2Sub.Font      = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNav2Sub.ForeColor = System.Drawing.Color.FromArgb(112, 112, 144);
            this.lblNav2Sub.Location  = new System.Drawing.Point(0, 78);
            this.lblNav2Sub.Name      = "lblNav2Sub";
            this.lblNav2Sub.Size      = new System.Drawing.Size(380, 28);
            this.lblNav2Sub.TabIndex  = 1;
            this.lblNav2Sub.Text      = "Lihat semua transaksi";
            this.lblNav2Sub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNav2Sub.Click      += new System.EventHandler(this.panelNav2_Click);
            this.lblNav2Sub.MouseEnter += new System.EventHandler(this.panelNav2_MouseEnter);
            this.lblNav2Sub.MouseLeave += new System.EventHandler(this.panelNav2_MouseLeave);

            // ── panelNav3  (Laporan, dark) ────────────────────────────
            this.panelNav3.BackColor   = System.Drawing.Color.FromArgb(30, 30, 58);
            this.panelNav3.Controls.Add(this.lblNav3Title);
            this.panelNav3.Controls.Add(this.lblNav3Sub);
            this.panelNav3.Cursor      = System.Windows.Forms.Cursors.Hand;
            this.panelNav3.Location    = new System.Drawing.Point(60, 320);
            this.panelNav3.Name        = "panelNav3";
            this.panelNav3.Size        = new System.Drawing.Size(380, 140);
            this.panelNav3.TabIndex    = 3;
            this.panelNav3.Click       += new System.EventHandler(this.panelNav3_Click);
            this.panelNav3.MouseEnter  += new System.EventHandler(this.panelNav3_MouseEnter);
            this.panelNav3.MouseLeave  += new System.EventHandler(this.panelNav3_MouseLeave);

            this.lblNav3Title.AutoSize  = false;
            this.lblNav3Title.Font      = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblNav3Title.ForeColor = System.Drawing.Color.White;
            this.lblNav3Title.Location  = new System.Drawing.Point(0, 35);
            this.lblNav3Title.Name      = "lblNav3Title";
            this.lblNav3Title.Size      = new System.Drawing.Size(380, 35);
            this.lblNav3Title.TabIndex  = 0;
            this.lblNav3Title.Text      = "\U0001F4CA Laporan";
            this.lblNav3Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNav3Title.Click      += new System.EventHandler(this.panelNav3_Click);
            this.lblNav3Title.MouseEnter += new System.EventHandler(this.panelNav3_MouseEnter);
            this.lblNav3Title.MouseLeave += new System.EventHandler(this.panelNav3_MouseLeave);

            this.lblNav3Sub.AutoSize  = false;
            this.lblNav3Sub.Font      = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNav3Sub.ForeColor = System.Drawing.Color.FromArgb(112, 112, 144);
            this.lblNav3Sub.Location  = new System.Drawing.Point(0, 78);
            this.lblNav3Sub.Name      = "lblNav3Sub";
            this.lblNav3Sub.Size      = new System.Drawing.Size(380, 28);
            this.lblNav3Sub.TabIndex  = 1;
            this.lblNav3Sub.Text      = "Ringkasan & statistik";
            this.lblNav3Sub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNav3Sub.Click      += new System.EventHandler(this.panelNav3_Click);
            this.lblNav3Sub.MouseEnter += new System.EventHandler(this.panelNav3_MouseEnter);
            this.lblNav3Sub.MouseLeave += new System.EventHandler(this.panelNav3_MouseLeave);

            // ── panelNav4  (Keluar, dark red) ─────────────────────────
            this.panelNav4.BackColor   = System.Drawing.Color.FromArgb(58, 21, 21);
            this.panelNav4.Controls.Add(this.lblNav4Title);
            this.panelNav4.Controls.Add(this.lblNav4Sub);
            this.panelNav4.Cursor      = System.Windows.Forms.Cursors.Hand;
            this.panelNav4.Location    = new System.Drawing.Point(460, 320);
            this.panelNav4.Name        = "panelNav4";
            this.panelNav4.Size        = new System.Drawing.Size(380, 140);
            this.panelNav4.TabIndex    = 4;
            this.panelNav4.Click       += new System.EventHandler(this.panelNav4_Click);
            this.panelNav4.MouseEnter  += new System.EventHandler(this.panelNav4_MouseEnter);
            this.panelNav4.MouseLeave  += new System.EventHandler(this.panelNav4_MouseLeave);

            this.lblNav4Title.AutoSize  = false;
            this.lblNav4Title.Font      = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblNav4Title.ForeColor = System.Drawing.Color.White;
            this.lblNav4Title.Location  = new System.Drawing.Point(0, 35);
            this.lblNav4Title.Name      = "lblNav4Title";
            this.lblNav4Title.Size      = new System.Drawing.Size(380, 35);
            this.lblNav4Title.TabIndex  = 0;
            this.lblNav4Title.Text      = "⏻ Keluar";
            this.lblNav4Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNav4Title.Click      += new System.EventHandler(this.panelNav4_Click);
            this.lblNav4Title.MouseEnter += new System.EventHandler(this.panelNav4_MouseEnter);
            this.lblNav4Title.MouseLeave += new System.EventHandler(this.panelNav4_MouseLeave);

            this.lblNav4Sub.AutoSize  = false;
            this.lblNav4Sub.Font      = new System.Drawing.Font("Segoe UI", 10F);
            this.lblNav4Sub.ForeColor = System.Drawing.Color.FromArgb(112, 112, 144);
            this.lblNav4Sub.Location  = new System.Drawing.Point(0, 78);
            this.lblNav4Sub.Name      = "lblNav4Sub";
            this.lblNav4Sub.Size      = new System.Drawing.Size(380, 28);
            this.lblNav4Sub.TabIndex  = 1;
            this.lblNav4Sub.Text      = "Tutup aplikasi";
            this.lblNav4Sub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNav4Sub.Click      += new System.EventHandler(this.panelNav4_Click);
            this.lblNav4Sub.MouseEnter += new System.EventHandler(this.panelNav4_MouseEnter);
            this.lblNav4Sub.MouseLeave += new System.EventHandler(this.panelNav4_MouseLeave);

            // ── Form1 ────────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.FromArgb(18, 18, 42);
            this.ClientSize          = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.panelNav1);
            this.Controls.Add(this.panelNav2);
            this.Controls.Add(this.panelNav3);
            this.Controls.Add(this.panelNav4);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip   = this.menuStrip1;
            this.MaximizeBox     = false;
            this.Name            = "Form1";
            this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text            = "Personal Expense Tracker";
            this.Load           += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelNav1.ResumeLayout(false);
            this.panelNav2.ResumeLayout(false);
            this.panelNav3.ResumeLayout(false);
            this.panelNav4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip          menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem  tsmiAkun;
        private System.Windows.Forms.ToolStripMenuItem  tsmiRegistrasi;
        private System.Windows.Forms.ToolStripMenuItem  tsmiMasukAkun;
        private System.Windows.Forms.ToolStripSeparator tsmiSeparator;
        private System.Windows.Forms.ToolStripMenuItem  tsmiLogout;
        private System.Windows.Forms.ToolStripLabel     tslSpacer;
        private System.Windows.Forms.ToolStripLabel     lblWelcome;
        private System.Windows.Forms.Panel panelNav1;
        private System.Windows.Forms.Label lblNav1Title;
        private System.Windows.Forms.Label lblNav1Sub;
        private System.Windows.Forms.Panel panelNav2;
        private System.Windows.Forms.Label lblNav2Title;
        private System.Windows.Forms.Label lblNav2Sub;
        private System.Windows.Forms.Panel panelNav3;
        private System.Windows.Forms.Label lblNav3Title;
        private System.Windows.Forms.Label lblNav3Sub;
        private System.Windows.Forms.Panel panelNav4;
        private System.Windows.Forms.Label lblNav4Title;
        private System.Windows.Forms.Label lblNav4Sub;
    }
}
