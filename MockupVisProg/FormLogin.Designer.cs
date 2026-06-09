namespace MockupVisProg
{
    partial class FormLogin
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
            this.panelHeader   = new System.Windows.Forms.Panel();
            this.lblHeader     = new System.Windows.Forms.Label();
            this.lblWelcome    = new System.Windows.Forms.Label();
            this.lblEmail      = new System.Windows.Forms.Label();
            this.txtEmail      = new System.Windows.Forms.TextBox();
            this.lblPassword   = new System.Windows.Forms.Label();
            this.txtPassword   = new System.Windows.Forms.TextBox();
            this.btnLogin      = new System.Windows.Forms.Button();
            this.lblGoRegister = new System.Windows.Forms.LinkLabel();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();

            // ── panelHeader ──────────────────────────────────────────
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(26, 26, 62);
            this.panelHeader.Controls.Add(this.lblHeader);
            this.panelHeader.Dock     = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Name     = "panelHeader";
            this.panelHeader.Size     = new System.Drawing.Size(420, 60);
            this.panelHeader.TabIndex = 0;

            // lblHeader
            this.lblHeader.AutoSize  = false;
            this.lblHeader.Dock      = System.Windows.Forms.DockStyle.Fill;
            this.lblHeader.Font      = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Name      = "lblHeader";
            this.lblHeader.TabIndex  = 0;
            this.lblHeader.Text      = "Masuk Akun";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ── lblWelcome ───────────────────────────────────────────
            this.lblWelcome.AutoSize  = false;
            this.lblWelcome.Font      = new System.Drawing.Font("Segoe UI", 10F);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(112, 112, 144);
            this.lblWelcome.Location  = new System.Drawing.Point(30, 82);
            this.lblWelcome.Name      = "lblWelcome";
            this.lblWelcome.Size      = new System.Drawing.Size(360, 22);
            this.lblWelcome.TabIndex  = 1;
            this.lblWelcome.Text      = "Selamat datang kembali";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ── lblEmail ─────────────────────────────────────────────
            this.lblEmail.AutoSize  = false;
            this.lblEmail.Font      = new System.Drawing.Font("Segoe UI", 10F);
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(176, 176, 200);
            this.lblEmail.Location  = new System.Drawing.Point(30, 142);
            this.lblEmail.Name      = "lblEmail";
            this.lblEmail.Size      = new System.Drawing.Size(360, 22);
            this.lblEmail.TabIndex  = 2;
            this.lblEmail.Text      = "Email";

            // ── txtEmail ─────────────────────────────────────────────
            this.txtEmail.BackColor    = System.Drawing.Color.FromArgb(26, 26, 62);
            this.txtEmail.BorderStyle  = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtEmail.Font         = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmail.ForeColor    = System.Drawing.Color.White;
            this.txtEmail.Location     = new System.Drawing.Point(30, 167);
            this.txtEmail.Name         = "txtEmail";
            this.txtEmail.Size         = new System.Drawing.Size(360, 23);
            this.txtEmail.TabIndex     = 3;

            // ── lblPassword ──────────────────────────────────────────
            this.lblPassword.AutoSize  = false;
            this.lblPassword.Font      = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(176, 176, 200);
            this.lblPassword.Location  = new System.Drawing.Point(30, 220);
            this.lblPassword.Name      = "lblPassword";
            this.lblPassword.Size      = new System.Drawing.Size(360, 22);
            this.lblPassword.TabIndex  = 4;
            this.lblPassword.Text      = "Password";

            // ── txtPassword ──────────────────────────────────────────
            this.txtPassword.BackColor    = System.Drawing.Color.FromArgb(26, 26, 62);
            this.txtPassword.BorderStyle  = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtPassword.Font         = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPassword.ForeColor    = System.Drawing.Color.White;
            this.txtPassword.Location     = new System.Drawing.Point(30, 245);
            this.txtPassword.Name         = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size         = new System.Drawing.Size(360, 23);
            this.txtPassword.TabIndex     = 5;

            // ── btnLogin ─────────────────────────────────────────────
            this.btnLogin.BackColor              = System.Drawing.Color.FromArgb(91, 79, 207);
            this.btnLogin.FlatStyle              = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.Font                   = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor              = System.Drawing.Color.White;
            this.btnLogin.Location               = new System.Drawing.Point(30, 320);
            this.btnLogin.Name                   = "btnLogin";
            this.btnLogin.Size                   = new System.Drawing.Size(360, 45);
            this.btnLogin.TabIndex               = 6;
            this.btnLogin.Text                   = "Masuk Aplikasi";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click                  += new System.EventHandler(this.btnLogin_Click);

            // ── lblGoRegister ────────────────────────────────────────
            this.lblGoRegister.ActiveLinkColor   = System.Drawing.Color.FromArgb(160, 160, 240);
            this.lblGoRegister.AutoSize          = false;
            this.lblGoRegister.Font              = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblGoRegister.ForeColor         = System.Drawing.Color.FromArgb(128, 128, 208);
            this.lblGoRegister.LinkBehavior      = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblGoRegister.LinkColor         = System.Drawing.Color.FromArgb(128, 128, 208);
            this.lblGoRegister.Location          = new System.Drawing.Point(30, 415);
            this.lblGoRegister.Name              = "lblGoRegister";
            this.lblGoRegister.Size              = new System.Drawing.Size(360, 22);
            this.lblGoRegister.TabIndex          = 7;
            this.lblGoRegister.TabStop           = true;
            this.lblGoRegister.Text              = "Belum punya akun? Daftar";
            this.lblGoRegister.TextAlign         = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGoRegister.VisitedLinkColor  = System.Drawing.Color.FromArgb(128, 128, 208);
            this.lblGoRegister.LinkClicked       += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblGoRegister_LinkClicked);

            // ── FormLogin ────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.FromArgb(18, 18, 42);
            this.ClientSize          = new System.Drawing.Size(420, 520);
            this.Controls.Add(this.lblGoRegister);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox     = false;
            this.Name            = "FormLogin";
            this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text            = "Masuk Akun";
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel     panelHeader;
        private System.Windows.Forms.Label     lblHeader;
        private System.Windows.Forms.Label     lblWelcome;
        private System.Windows.Forms.Label     lblEmail;
        private System.Windows.Forms.TextBox   txtEmail;
        private System.Windows.Forms.Label     lblPassword;
        private System.Windows.Forms.TextBox   txtPassword;
        private System.Windows.Forms.Button    btnLogin;
        private System.Windows.Forms.LinkLabel lblGoRegister;
    }
}
