using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using MockupVisProg.Database;

namespace MockupVisProg
{
    public partial class FormRegister : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam, string lParam);
        private const int EM_SETCUEBANNER = 0x1501;

        public FormRegister()
        {
            InitializeComponent();
            this.AcceptButton = btnDaftar;
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {
            SendMessage(txtUsername.Handle, EM_SETCUEBANNER, (IntPtr)1, "Nama lengkap");
            SendMessage(txtEmail.Handle,    EM_SETCUEBANNER, (IntPtr)1, "Email");
            SendMessage(txtPassword.Handle, EM_SETCUEBANNER, (IntPtr)1, "Password");
            SendMessage(txtConfirm.Handle,  EM_SETCUEBANNER, (IntPtr)1, "Konfirmasi password");
        }

        private void btnDaftar_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string email    = txtEmail.Text.Trim();
            string password = txtPassword.Text;
            string confirm  = txtConfirm.Text;

            if (string.IsNullOrWhiteSpace(username))
            {
                MessageBox.Show("Nama lengkap tidak boleh kosong.", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }

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

            if (string.IsNullOrWhiteSpace(confirm))
            {
                MessageBox.Show("Konfirmasi password tidak boleh kosong.", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirm.Focus();
                return;
            }

            if (password != confirm)
            {
                MessageBox.Show("Password tidak cocok.", "Validasi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirm.Clear();
                txtConfirm.Focus();
                return;
            }

            bool success = DbHelper.RegisterUser(username, email, password);

            if (success)
            {
                MessageBox.Show("Akun berhasil dibuat! Silakan login.", "Registrasi Berhasil",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                OpenLogin();
            }
            else
            {
                MessageBox.Show("Email sudah terdaftar atau terjadi kesalahan.", "Registrasi Gagal",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
            }
        }

        private void lblGoLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenLogin();
        }

        private void OpenLogin()
        {
            new FormLogin().Show();
            this.Close();
        }
    }
}
