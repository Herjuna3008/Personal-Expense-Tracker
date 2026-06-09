using System;
using System.Windows.Forms;
using MockupVisProg.Database;
using MockupVisProg.Models;

namespace MockupVisProg
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            this.AcceptButton = btnLogin;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email    = txtEmail.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Email tidak boleh kosong.", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Password tidak boleh kosong.", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            User user = DbHelper.LoginUser(email, password);

            if (user != null)
            {
                Session.CurrentUser = user;
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Email atau password salah.", "Login Gagal",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        private void lblGoRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var formRegister = new FormRegister();
            formRegister.Show();
            this.Hide();
        }
    }
}
