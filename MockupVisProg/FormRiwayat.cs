using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MockupVisProg.Database;
using MockupVisProg.Models;

namespace MockupVisProg
{
    public partial class FormRiwayat : Form
    {
        private List<Expense> _allExpenses = new List<Expense>();

        public FormRiwayat()
        {
            InitializeComponent();
        }

        private void FormRiwayat_Load(object sender, EventArgs e)
        {
            if (!Session.IsLoggedIn)
            {
                new FormLogin().Show();
                this.Close();
                return;
            }

            LoadData();
        }

        private void LoadData()
        {
            _allExpenses = DbHelper.GetAllExpenses();
            PopulateFilter();
            ApplyFilter();
        }

        // Isi filter dari kategori yang benar-benar ada di data (LINQ Distinct)
        private void PopulateFilter()
        {
            string selected = cboFilter.SelectedItem?.ToString() ?? "Semua";

            var categories = _allExpenses
                .Select(x => x.CategoryName)
                .Distinct()
                .OrderBy(name => name)
                .Cast<object>()
                .ToArray();

            // Populate without triggering SelectedIndexChanged prematurely
            cboFilter.SelectedIndexChanged -= cboFilter_SelectedIndexChanged;
            cboFilter.Items.Clear();
            cboFilter.Items.Add("Semua");
            cboFilter.Items.AddRange(categories);

            int idx = cboFilter.Items.IndexOf(selected);
            cboFilter.SelectedIndex = idx >= 0 ? idx : 0;
            cboFilter.SelectedIndexChanged += cboFilter_SelectedIndexChanged;
        }

        private void ApplyFilter()
        {
            string filter = cboFilter.SelectedItem?.ToString() ?? "Semua";

            List<Expense> filtered = filter == "Semua"
                ? _allExpenses
                : _allExpenses.Where(e => e.CategoryName == filter).ToList();

            dgvExpenses.DataSource = null;
            dgvExpenses.DataSource = filtered;

            UpdateSummary(filtered);
        }

        private void UpdateSummary(List<Expense> expenses)
        {
            if (expenses.Count == 0)
            {
                lblTotal.Text    = "Total: Rp 0";
                lblTerbesar.Text = "Terbesar: Rp 0";
                lblCount.Text    = "0 transaksi";
                return;
            }

            lblTotal.Text    = $"Total: Rp {expenses.Sum(e => e.Amount):N0}";
            lblTerbesar.Text = $"Terbesar: Rp {expenses.Max(e => e.Amount):N0}";
            lblCount.Text    = $"{expenses.Count()} transaksi";
        }

        private void cboFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (dgvExpenses.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Pilih baris yang ingin dihapus.",
                    "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirm = MessageBox.Show(
                "Hapus data pengeluaran ini?",
                "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm != DialogResult.Yes) return;

            var expense = (Expense)dgvExpenses.SelectedRows[0].DataBoundItem;
            if (DbHelper.DeleteExpense(expense.ExpenseID))
            {
                LoadData();
            }
        }

        private void btnExportCsv_Click(object sender, EventArgs e)
        {
            if (_allExpenses.Count == 0)
            {
                MessageBox.Show("Tidak ada data untuk diekspor.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var dialog = new SaveFileDialog())
            {
                dialog.Filter   = "CSV files (*.csv)|*.csv";
                dialog.FileName = "pengeluaran_" + DateTime.Now.ToString("yyyyMMdd");

                if (dialog.ShowDialog() != DialogResult.OK) return;

                try
                {
                    var lines = new[] { "Tanggal,Deskripsi,Kategori,Jumlah" }
                        .Concat(_allExpenses.Select(exp =>
                            $"{exp.Date:dd/MM/yyyy}," +
                            $"{exp.Description?.Replace(",", ";") ?? string.Empty}," +
                            $"{exp.CategoryName},{exp.Amount}"));

                    File.WriteAllLines(dialog.FileName, lines, new UTF8Encoding(true));

                    MessageBox.Show(
                        $"Data berhasil diekspor ke:\n{dialog.FileName}",
                        "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menyimpan file: " + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
