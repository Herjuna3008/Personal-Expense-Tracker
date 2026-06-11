using System;
using System.Data;
using System.IO;
using CrystalDecisions.ReportAppServer.ClientDoc;
using CrystalDecisions.ReportAppServer.DataDefModel;
using CrystalDecisions.ReportAppServer.ReportDefModel;

namespace MockupVisProg.Reports
{
    /// <summary>
    /// Membuat LaporanBulanan.rpt secara otomatis lewat in-proc RAS saat file
    /// belum ada (format .rpt biner, tidak bisa ditulis tangan). Hasilnya layout
    /// dasar — bisa dipoles di designer Crystal Reports (lihat CARA_BUAT_RPT.md).
    /// Semua ukuran posisi dalam twips (1440 twips = 1 inci).
    /// </summary>
    public static class RptGenerator
    {
        private const string TableName = "LaporanBulanan";

        public static void Generate(string outputPath)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(outputPath));

            ISCDReportClientDocument rcd = new ReportClientDocumentClass();
            rcd.New();

            try
            {
                AddSchema(rcd);
                AddParameters(rcd);
                AddSummary(rcd);
                BuildLayout(rcd);

                // 1 = overwrite existing (CdReportClientDocumentSaveAsOptions)
                rcd.SaveAs(Path.GetFileName(outputPath),
                           Path.GetDirectoryName(outputPath) + "\\", 1);
            }
            finally
            {
                rcd.Close();
            }
        }

        // Skema identik dengan DataTable yang di-push FormLaporan
        private static void AddSchema(ISCDReportClientDocument rcd)
        {
            var ds = new DataSet("LaporanBulananDataSet");
            var dt = ds.Tables.Add(TableName);
            dt.Columns.Add("Date",        typeof(DateTime));
            dt.Columns.Add("Description", typeof(string));
            dt.Columns.Add("Kategori",    typeof(string));
            dt.Columns.Add("Amount",      typeof(decimal));

            rcd.DatabaseController.AddDataSource(ds);

            foreach (ISCRField f in rcd.Database.Tables[0].DataFields)
                rcd.DataDefController.ResultFieldController.Add(-1, f);
        }

        private static void AddParameters(ISCDReportClientDocument rcd)
        {
            foreach (string name in new[] { "Periode", "Pengguna" })
            {
                var p = new ParameterField();
                p.Name = name;
                p.Type = CrFieldValueTypeEnum.crFieldValueTypeStringField;
                rcd.DataDefController.ParameterFieldController.Add(p);
            }
        }

        private static void AddSummary(ISCDReportClientDocument rcd)
        {
            var sum = new SummaryField();
            sum.SummarizedField = FindField(rcd, "Amount");
            sum.Operation       = CrSummaryOperationEnum.crSummaryOperationSum;
            rcd.DataDefController.SummaryFieldController.Add(-1, sum);
        }

        private static void BuildLayout(ISCDReportClientDocument rcd)
        {
            ISCRReportDefinition def = rcd.ReportDefinition;
            ISCRSection reportHeader = def.ReportHeaderArea.Sections[0];
            ISCRSection pageHeader   = def.PageHeaderArea.Sections[0];
            ISCRSection detail       = def.DetailArea.Sections[0];
            ISCRSection reportFooter = def.ReportFooterArea.Sections[0];

            // Report header: judul + parameter periode/pengguna
            AddText(rcd, reportHeader, "Laporan Pengeluaran Bulanan", 0, 4800);
            AddField(rcd, reportHeader, "{?Periode}",
                CrFieldValueTypeEnum.crFieldValueTypeStringField, 4900, 2200);
            AddField(rcd, reportHeader, "{?Pengguna}",
                CrFieldValueTypeEnum.crFieldValueTypeStringField, 7200, 2200);

            // Page header: judul kolom
            AddText(rcd, pageHeader, "Tanggal",    0,    1300);
            AddText(rcd, pageHeader, "Keterangan", 1400, 4200);
            AddText(rcd, pageHeader, "Kategori",   5700, 1700);
            AddText(rcd, pageHeader, "Jumlah",     7500, 1900);

            // Detail: field data
            AddField(rcd, detail, Col("Date"),        FindField(rcd, "Date").Type,        0,    1300);
            AddField(rcd, detail, Col("Description"), FindField(rcd, "Description").Type, 1400, 4200);
            AddField(rcd, detail, Col("Kategori"),    FindField(rcd, "Kategori").Type,    5700, 1700);
            AddField(rcd, detail, Col("Amount"),      FindField(rcd, "Amount").Type,      7500, 1900);

            // Report footer: grand total
            AddText(rcd, reportFooter, "Total:", 6300, 1100);
            AddField(rcd, reportFooter, "Sum (" + Col("Amount") + ")",
                FindField(rcd, "Amount").Type, 7500, 1900);
        }

        // ── Helpers ─────────────────────────────────────────────────

        private static string Col(string name)
        {
            return "{" + TableName + "." + name + "}";
        }

        private static ISCRField FindField(ISCDReportClientDocument rcd, string name)
        {
            foreach (ISCRField f in rcd.Database.Tables[0].DataFields)
                if (string.Equals(f.Name, name, StringComparison.OrdinalIgnoreCase))
                    return f;
            throw new InvalidOperationException("Field tidak ditemukan: " + name);
        }

        private static void AddField(ISCDReportClientDocument rcd, ISCRSection section,
            string dataSource, CrFieldValueTypeEnum type, int left, int width)
        {
            var fo = new FieldObject();
            fo.Kind           = CrReportObjectKindEnum.crReportObjectKindField;
            fo.DataSourceName = dataSource;
            fo.FieldValueType = type;
            fo.Left   = left;
            fo.Top    = 30;
            fo.Width  = width;
            fo.Height = 226;

            rcd.ReportDefController.ReportObjectController.Add(fo, section, -1);
        }

        private static void AddText(ISCDReportClientDocument rcd, ISCRSection section,
            string text, int left, int width)
        {
            var element  = new ParagraphTextElement();
            element.Text = text;
            element.Kind = CrParagraphElementKindEnum.crParagraphElementKindText;

            var elements = new ParagraphElements();
            elements.Add(element);

            var paragraph = new Paragraph();
            paragraph.ParagraphElements = elements;

            var paragraphs = new Paragraphs();
            paragraphs.Add(paragraph);

            var to = new TextObject();
            to.Kind       = CrReportObjectKindEnum.crReportObjectKindText;
            to.Paragraphs = paragraphs;
            to.Left   = left;
            to.Top    = 30;
            to.Width  = width;
            to.Height = 226;

            rcd.ReportDefController.ReportObjectController.Add(to, section, -1);
        }
    }
}
