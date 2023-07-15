using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__honorarium_dosen_eksternal
{
    public partial class ReportTransfer : Form
    {
        public ReportTransfer()
        {
            InitializeComponent();
        }

        string emp = "";


        private void ReportTransfer_Load(object sender, EventArgs e)
        {
            this.getListJenisDosenTableAdapter.FillBy5(this.honorariumDosenEksternalDataSet.getListJenisDosen, emp);
            this.reportViewer1.RefreshReport();
            ShowDefaultTransfer();
        }
        public void ShowDefaultTransfer()
        {
            DateTime currentDate = DateTime.Now;
            DateTime start = currentDate.AddMonths(-2).AddDays(16 - currentDate.Day);
            txtTglAwal.Value = start;

            DateTime end = start.AddMonths(1).AddDays(15 - start.Day);
            txtTglAkhir.Value = end;
        }
        public static string GetTahunAkademik(DateTime date)
        {
            int year = date.Year;
            int month = date.Month;

            if (month >= 7)
            {
                return $"{year}/{year + 1}"; // Example: 2023/2024
            }
            else
            {
                return $"{year - 1}/{year}"; // Example: 2022/2023
            }
        }
        public string FormatTerbilang(int number)
        {
            string[] ones = { "", "satu", "dua", "tiga", "empat", "lima", "enam", "tujuh", "delapan", "sembilan" };
            string[] tens = { "", "sepuluh", "dua puluh", "tiga puluh", "empat puluh", "lima puluh", "enam puluh", "tujuh puluh", "delapan puluh", "sembilan puluh" };
            string[] thousands = { "ribu" };
            string[] millions = { "juta" };
            string[] billions = { "milyar" };

            if (number < 0)
            {
                return "minus " + FormatTerbilang(-number);
            }

            if (number < 10)
            {
                return ones[number];
            }

            if (number < 20)
            {
                return tens[number - 10];
            }

            if (number < 100)
            {
                return tens[number / 10] + (number % 10 != 0 ? " " : "") + ones[number % 10];
            }

            if (number < 1000)
            {
                return ones[number / 100] + " ratus" + (number % 100 != 0 ? " " : "") + FormatTerbilang(number % 100);
            }

            if (number < 1000000)
            {
                return FormatTerbilang(number / 1000) + " ribu" + (number % 1000 != 0 ? " " : "") + FormatTerbilang(number % 1000);
            }

            if (number < 1000000000)
            {
                return FormatTerbilang(number / 1000000) + " juta" + (number % 1000000 != 0 ? " " : "") + FormatTerbilang(number % 1000000);
            }

            if (number < int.MaxValue)
            {
                return FormatTerbilang(number / 1000000000) + " milyar" + (number % 1000000000 != 0 ? " " : "") + FormatTerbilang(number % 1000000000);
            }

            return "";
        }


        private void btnFilter_Click(object sender, EventArgs e)
        {
            DateTime tanggal_awal = txtTglAwal.Value;
            string tanggal_Awal = txtTglAwal.Value.ToString("yyyy-MM-dd");
            string tanggal_akhir = txtTglAkhir.Value.ToString("yyyy-MM-dd");
            string IDjenis = cbIDJenis.SelectedValue.ToString();
            string nama_jenis = cbIDJenis.Text;
            string tahun_akademik = GetTahunAkademik(tanggal_awal);
           

            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("TAHUN", tahun_akademik));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("PERIODE", txtTglAwal.Text + " - " + txtTglAkhir.Text));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("JenisDosen", nama_jenis));
            this.getReportTransferTableAdapter.FillBy(this.honorariumDosenEksternalDataSet.getReportTransfer, tanggal_Awal, tanggal_akhir, IDjenis);

            DataTable reportTransferTable = this.honorariumDosenEksternalDataSet.getReportTransfer; // Ganti dengan objek DataTable yang sesuai dengan hasil query

            int totalTransfer = 0;

            foreach (DataRow row in reportTransferTable.Rows)
            {
                int transfer = Convert.ToInt32(row["total"]); // Ganti "total_transfer" dengan nama kolom yang sesuai pada hasil query
                totalTransfer += transfer;
            }
            string terbilang = FormatTerbilang(totalTransfer);
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("TERBILANG", terbilang));

            this.reportViewer1.RefreshReport();
        }
    }
}
