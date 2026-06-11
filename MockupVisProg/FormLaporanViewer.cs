using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using MockupVisProg.Models;

namespace MockupVisProg
{
    public partial class FormLaporanViewer : Form
    {
        private readonly DataTable _data;
        private readonly string    _periode;
        private ReportDocument     _report;

        public FormLaporanViewer(DataTable data, string periode)
        {
            InitializeComponent();
            _data    = data;
            _periode = periode;
        }

        private void FormLaporanViewer_Load(object sender, EventArgs e)
        {
            string rptPath = Path.Combine(Application.StartupPath, "Reports", "LaporanBulanan.rpt");

            if (!File.Exists(rptPath))
            {
                try
                {
                    // .rpt biner — dibuat otomatis via in-proc RAS saat pertama kali
                    Reports.RptGenerator.Generate(rptPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Gagal membuat report otomatis: " + ex.Message +
                        "\n\nBuat LaporanBulanan.rpt manual lewat designer " +
                        "(lihat Reports\\CARA_BUAT_RPT.md).",
                        "Report tidak ditemukan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }
            }

            try
            {
                _report = new ReportDocument();
                _report.Load(rptPath);
                _report.SetDataSource(_data);

                SetParameterIfExists("Periode",  _periode);
                SetParameterIfExists("Pengguna", Session.CurrentUser.Username);

                crystalReportViewer1.ReportSource = _report;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat report: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        // Report lama mungkin belum punya parameternya — jangan crash kalau tidak ada
        private void SetParameterIfExists(string name, string value)
        {
            bool exists = _report.DataDefinition.ParameterFields
                .Cast<ParameterFieldDefinition>()
                .Any(p => p.Name == name);

            if (exists)
                _report.SetParameterValue(name, value);
        }

        private void FormLaporanViewer_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_report != null)
            {
                _report.Close();
                _report.Dispose();
            }
        }
    }
}
