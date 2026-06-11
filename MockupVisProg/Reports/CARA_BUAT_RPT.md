# Cara Membuat `LaporanBulanan.rpt`

> **Update: file ini sekarang dibuat OTOMATIS.** Saat tombol **Print** ditekan
> dan `.rpt` belum ada, aplikasi men-generate `Reports\LaporanBulanan.rpt`
> (di folder output, mis. `bin\Debug\Reports\`) lewat in-proc RAS API —
> lihat `Reports\RptGenerator.cs`. Layout hasil generate masih polos.
> Mau dipoles (font, format Rp, garis)? Buka file hasil generate di designer
> Crystal Reports, edit, simpan — atau buat manual dari nol dengan langkah
> di bawah. Langkah manual ini sekarang hanya fallback/referensi.

File `.rpt` adalah format biner — dibuat lewat designer Crystal Reports di
Visual Studio (Windows, dengan **SAP Crystal Reports for Visual Studio** terinstall)
atau otomatis oleh `RptGenerator`. Aplikasi memuat report dari
`Reports\LaporanBulanan.rpt` saat tombol **Print** di Form Laporan ditekan.

## 1. Tambah report baru

1. Buka solution di Visual Studio (Windows).
2. Di Solution Explorer, klik kanan folder **Reports** → **Add** → **New Item…**
3. Pilih kategori **Reporting** → **Crystal Report**, beri nama `LaporanBulanan.rpt` → **Add**.
4. Di dialog Crystal Reports Gallery pilih **As a Blank Report** → **OK**.

## 2. Hubungkan ke skema data (push model)

Report tidak terhubung langsung ke SQL Server. Datanya di-push dari kode
(`ReportDocument.SetDataSource(DataTable)`), jadi designer cukup diberi skema:

1. Di designer report, buka **Field Explorer** (View → Other Windows → Document Outline / Field Explorer).
2. Klik kanan **Database Fields** → **Database Expert…**
3. **Create New Connection** → **ADO.NET (XML)**.
4. Pada **File Path**, browse ke `MockupVisProg\Reports\LaporanBulananDataSet.xsd` → **Finish**.
5. Pindahkan tabel **LaporanBulanan** ke panel kanan (Selected Tables) → **OK**.

## 3. Tambah parameter

Kode mengirim dua parameter string lewat `SetParameterValue`:

| Nama       | Tipe   | Isi dari kode                  |
|------------|--------|--------------------------------|
| `Periode`  | String | mis. "Juni 2026"               |
| `Pengguna` | String | username yang sedang login     |

Di **Field Explorer** → klik kanan **Parameter Fields** → **New…** → buat keduanya
(tipe **String**, nama persis seperti tabel di atas, tanpa value list).

## 4. Desain layout

- **Report Header**: Text Object berisi judul `Laporan Pengeluaran Bulanan`,
  lalu drag parameter `{?Periode}` dan `{?Pengguna}` di bawahnya.
- **Details**: drag field `Date`, `Description`, `Kategori`, `Amount` dari
  Database Fields. Header kolom otomatis muncul di Page Header.
- Format tanggal: klik kanan field `Date` → **Format Object** → tab **Date** → `dd/MM/yyyy`.
- Format rupiah: klik kanan field `Amount` → **Format Object** → tab **Number** →
  **Customize** → Currency Symbol `Rp `, decimal `0`, pemisah ribuan `.`.
- **Total**: klik kanan field `Amount` → **Insert** → **Summary…** →
  Sum of Amount, letakkan di **Report Footer**. Tambahkan Text Object `Total:` di sebelahnya.

## 5. Properti file (penting)

Pilih `LaporanBulanan.rpt` di Solution Explorer, lalu di jendela **Properties**:

- **Build Action** = `None`
- **Copy to Output Directory** = `Copy if newer`
- **Custom Tool** = *(kosongkan)* — hapus juga file `LaporanBulanan.cs` yang
  ikut ter-generate kalau ada. Kode memuat report lewat path, bukan kelas typed.

## 6. Jalankan

Build → jalankan aplikasi → Form Laporan → pilih bulan/tahun → **Print**.
Report tampil di `FormLaporanViewer` (CrystalReportViewer): bisa preview, print
ke printer, dan export PDF/Excel dari toolbar viewer.

## Catatan

- `App.config` sudah diberi `useLegacyV2RuntimeActivationPolicy="true"` — wajib untuk runtime CR 13.
- Kalau muncul error assembly `crdb_adoplus` / load DB saat run, ganti
  **Platform target** project ke `x86` (Project Properties → Build) atau pastikan
  runtime Crystal Reports 64-bit terinstall.
