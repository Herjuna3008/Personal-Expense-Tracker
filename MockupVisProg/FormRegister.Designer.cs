namespace MockupVisProg
{
    partial class FormRegister
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
            this.panelHeader  = new System.Windows.Forms.Panel();
            this.lblHeader    = new System.Windows.Forms.Label();
            this.lblWelcome   = new System.Windows.Forms.Label();
            this.lblUsername  = new System.Windows.Forms.Label();
            this.txtUsername  = new System.Windows.Forms.TextBox();
            this.lblEmail     = new System.Windows.Forms.Label();
            this.txtEmail     = new System.Windows.Forms.TextBox();
            this.lblPassword  = new System.Windows.Forms.Label();
            this.txtPassword  = new System.Windows.Forms.TextBox();
            this.lblConfirm   = new System.Windows.Forms.Label();
            this.txtConfirm   = new System.Windows.Forms.TextBox();
            this.btnDaftar    = new System.Windows.Forms.Button();
            this.lblGoLogin   = new System.Windows.Forms.LinkLabel();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();

            // ── panelHeader ──────────────────────────────────────────
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(26, 26, 62);
            this.panelHeader.Controls.Add(this.lblHeader);
            this.panelHeader.Dock     = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Name     = "panelHeader";
            this.panelHeader.Size     = new System.Drawing.Size(420, 60);
            this.panelHeader.TabIndex = 0;

            this.lblHeader.AutoSize  = false;
            this.lblHeader.Dock      = System.Windows.Forms.DockStyle.Fill;
            this.lblHeader.Font      = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Name      = "lblHeader";
            this.lblHeader.TabIndex  = 0;
            this.lblHeader.Text      = "Buat Akun Baru";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ── lblWelcome ───────────────────────────────────────────
            this.lblWelcome.AutoSize  = false;
            this.lblWelcome.Font      = new System.Drawing.Font("Segoe UI", 10F);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(112, 112, 144);
            this.lblWelcome.Location  = new System.Drawing.Point(30, 78);
            this.lblWelcome.Name      = "lblWelcome";
            this.lblWelcome.Size      = new System.Drawing.Size(360, 22);
            this.lblWelcome.TabIndex  = 1;
            this.lblWelcome.Text      = "Daftar dan mulai catat pengeluaranmu";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ── lblUsername ──────────────────────────────────────────
            this.lblUsername.AutoSize  = false;
            this.lblUsername.Font      = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(176, 176, 200);
            this.lblUsername.Location  = new System.Drawing.Point(30, 120);
            this.lblUsername.Name      = "lblUsername";
            this.lblUsername.Size      = new System.Drawing.Size(360, 22);
            this.lblUsername.TabIndex  = 2;
            this.lblUsername.Text      = "Nama Lengkap";

            // ── txtUsername ──────────────────────────────────────────
            this.txtUsername.BackColor   = System.Drawing.Color.FromArgb(26, 26, 62);
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtUsername.Font        = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUsername.ForeColor   = System.Drawing.Color.White;
            this.txtUsername.Location    = new System.Drawing.Point(30, 145);
            this.txtUsername.Name        = "txtUsername";
            this.txtUsername.Size        = new System.Drawing.Size(360, 23);
            this.txtUsername.TabIndex    = 3;

            // ── lblEmail ─────────────────────────────────────────────
            this.lblEmail.AutoSize  = false;
            this.lblEmail.Font      = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(176, 176, 200);
            this.lblEmail.Location  = new System.Drawing.Point(30, 198);
            this.lblEmail.Name      = "lblEmail";
            this.lblEmail.Size      = new System.Drawing.Size(360, 22);
            this.lblEmail.TabIndex  = 4;
            this.lblEmail.Text      = "Email";

            // ── txtEmail ─────────────────────────────────────────────
            this.txtEmail.BackColor   = System.Drawing.Color.FromArgb(26, 26, 62);
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtEmail.Font        = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.ForeColor   = System.Drawing.Color.White;
            this.txtEmail.Location    = new System.Drawing.Point(30, 223);
            this.txtEmail.Name        = "txtEmail";
            this.txtEmail.Size        = new System.Drawing.Size(360, 23);
            this.txtEmail.TabIndex    = 5;

            // ── lblPassword ──────────────────────────────────────────
            this.lblPassword.AutoSize  = false;
            this.lblPassword.Font      = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(176, 176, 200);
            this.lblPassword.Location  = new System.Drawing.Point(30, 276);
            this.lblPassword.Name      = "lblPassword";
            this.lblPassword.Size      = new System.Drawing.Size(360, 22);
            this.lblPassword.TabIndex  = 6;
            this.lblPassword.Text      = "Password";

            // ── txtPassword ──────────────────────────────────────────
            this.txtPassword.BackColor    = System.Drawing.Color.FromArgb(26, 26, 62);
            this.txtPassword.BorderStyle  = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtPassword.Font         = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPassword.ForeColor    = System.Drawing.Color.White;
            this.txtPassword.Location     = new System.Drawing.Point(30, 301);
            this.txtPassword.Name         = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size         = new System.Drawing.Size(360, 23);
            this.txtPassword.TabIndex     = 7;

            // ── lblConfirm ───────────────────────────────────────────
            this.lblConfirm.AutoSize  = false;
            this.lblConfirm.Font      = new System.Drawing.Font("Segoe UI", 10F);
            this.lblConfirm.ForeColor = System.Drawing.Color.FromArgb(176, 176, 200);
            this.lblConfirm.Location  = new System.Drawing.Point(30, 354);
            this.lblConfirm.Name      = "lblConfirm";
            this.lblConfirm.Size      = new System.Drawing.Size(360, 22);
            this.lblConfirm.TabIndex  = 8;
            this.lblConfirm.Text      = "Konfirmasi Password";

            // ── txtConfirm ───────────────────────────────────────────
            this.txtConfirm.BackColor    = System.Drawing.Color.FromArgb(26, 26, 62);
            this.txtConfirm.BorderStyle  = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtConfirm.Font         = new System.Drawing.Font("Segoe UI", 10F);
            this.txtConfirm.ForeColor    = System.Drawing.Color.White;
            this.txtConfirm.Location     = new System.Drawing.Point(30, 379);
            this.txtConfirm.Name         = "txtConfirm";
            this.txtConfirm.PasswordChar = '●';
            this.txtConfirm.Size         = new System.Drawing.Size(360, 23);
            this.txtConfirm.TabIndex     = 9;

            // ── btnDaftar ────────────────────────────────────────────
            this.btnDaftar.BackColor              = System.Drawing.Color.FromArgb(91, 79, 207);
            this.btnDaftar.FlatStyle              = System.Windows.Forms.FlatStyle.Flat;
            this.btnDaftar.FlatAppearance.BorderSize = 0;
            this.btnDaftar.Font                   = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnDaftar.ForeColor              = System.Drawing.Color.White;
            this.btnDaftar.Location               = new System.Drawing.Point(30, 440);
            this.btnDaftar.Name                   = "btnDaftar";
            this.btnDaftar.Size                   = new System.Drawing.Size(360, 45);
            this.btnDaftar.TabIndex               = 10;
            this.btnDaftar.Text                   = "Buat Akun";
            this.btnDaftar.UseVisualStyleBackColor = false;
            this.btnDaftar.Click                  += new System.EventHandler(this.btnDaftar_Click);

            // ── lblGoLogin ───────────────────────────────────────────
            this.lblGoLogin.ActiveLinkColor  = System.Drawing.Color.FromArgb(160, 160, 240);
            this.lblGoLogin.AutoSize         = false;
            this.lblGoLogin.Font             = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblGoLogin.ForeColor        = System.Drawing.Color.FromArgb(128, 128, 208);
            this.lblGoLogin.LinkBehavior     = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblGoLogin.LinkColor        = System.Drawing.Color.FromArgb(128, 128, 208);
            this.lblGoLogin.Location         = new System.Drawing.Point(30, 530);
            this.lblGoLogin.Name             = "lblGoLogin";
            this.lblGoLogin.Size             = new System.Drawing.Size(360, 22);
            this.lblGoLogin.TabIndex         = 11;
            this.lblGoLogin.TabStop          = true;
            this.lblGoLogin.Text             = "Sudah punya akun? Masuk";
            this.lblGoLogin.TextAlign        = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGoLogin.VisitedLinkColor = System.Drawing.Color.FromArgb(128, 128, 208);
            this.lblGoLogin.LinkClicked      += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblGoLogin_LinkClicked);

            // ── FormRegister ─────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.FromArgb(18, 18, 42);
            this.ClientSize          = new System.Drawing.Size(420, 580);
            this.Controls.Add(this.lblGoLogin);
            this.Controls.Add(this.btnDaftar);
            this.Controls.Add(this.txtConfirm);
            this.Controls.Add(this.lblConfirm);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox     = false;
            this.Name            = "FormRegister";
            this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text            = "Buat Akun Baru";
            this.Load           += new System.EventHandler(this.FormRegister_Load);
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel     panelHeader;
        private System.Windows.Forms.Label     lblHeader;
        private System.Windows.Forms.Label     lblWelcome;
        private System.Windows.Forms.Label     lblUsername;
        private System.Windows.Forms.TextBox   txtUsername;
        private System.Windows.Forms.Label     lblEmail;
        private System.Windows.Forms.TextBox   txtEmail;
        private System.Windows.Forms.Label     lblPassword;
        private System.Windows.Forms.TextBox   txtPassword;
        private System.Windows.Forms.Label     lblConfirm;
        private System.Windows.Forms.TextBox   txtConfirm;
        private System.Windows.Forms.Button    btnDaftar;
        private System.Windows.Forms.LinkLabel lblGoLogin;
    }
}
