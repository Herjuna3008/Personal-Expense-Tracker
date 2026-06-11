using System;
using System.Windows.Forms;
using MockupVisProg.Database;
using MockupVisProg.Models;

namespace MockupVisProg
{
    public partial class FormTambah : BaseChildForm
    {
        public FormTambah()
        {
            InitializeComponent();
            FormTitle = "Tambah Pengeluaran";
        }

        private void FormTambah_Load(object sender, EventArgs e)
        {
            if (!Session.IsLoggedIn)
            {
                new FormLogin().Show();
                this.Close();
                return;
            }

            LoadData();
        }

        public override void LoadData()
        {
            var categories = DbHelper.GetCategories();
            if (categories.Count == 0)
            {
                MessageBox.Show(
                    "Tidak ada kategori ditemukan. Pastikan database sudah terisi.",
                    "Peringatan",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            cboCategory.DataSource    = categories;
            cboCategory.DisplayMember = "Name";
            cboCategory.ValueMember   = "CategoryID";
        }

        // Allow only digits; no letters or special chars
        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (!Validate()) return;

            var expense = new Expense
            {
                Date        = dtpDate.Value.Date,
                Description = txtDescription.Text.Trim(),
                CategoryID  = (int)cboCategory.SelectedValue,
                Amount      = decimal.Parse(txtAmount.Text)
            };

            bool ok = DbHelper.AddExpense(expense);
            if (ok)
            {
                MessageBox.Show(
                    "Pengeluaran berhasil disimpan.",
                    "Sukses",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private new bool Validate()
        {
            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                MessageBox.Show("Deskripsi tidak boleh kosong.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescription.Focus();
                return false;
            }

            if (cboCategory.SelectedValue == null)
            {
                MessageBox.Show("Pilih kategori terlebih dahulu.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboCategory.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtAmount.Text))
            {
                MessageBox.Show("Jumlah tidak boleh kosong.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAmount.Focus();
                return false;
            }

            if (!decimal.TryParse(txtAmount.Text, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Jumlah harus berupa angka lebih dari 0.", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAmount.Focus();
                return false;
            }

            return true;
        }
    }
}
