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
    public partial class ReportProdi : Form
    {
        public ReportProdi()
        {
            InitializeComponent();
        }

        string emp = "";

        private void ReportProdi_Load(object sender, EventArgs e)
        {   
            ShowDefaultProdi();
            this.getListJenisDosenTableAdapter.FillBy6(this.honorariumDosenEksternalDataSet.getListJenisDosen, emp);
            this.reportViewer1.RefreshReport();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            DateTime tanggal_awal = txtTanggalAwal.Value;
            string tanggal_Awal = txtTanggalAwal.Value.ToString("yyyy-MM-dd");
            string tanggal_akhir = txtTanggalAkhir.Value.ToString("yyyy-MM-dd");
            string jenis = cmbJenisDosen.SelectedValue.ToString();
            string nama_jenis = cmbJenisDosen.Text;
            string tahun_akademik = GetTahunAkademik(tanggal_awal);

            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("TAHUN", tahun_akademik));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("PERIODE", txtTanggalAwal.Text + " - " + txtTanggalAkhir.Text));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("JenisDosen", nama_jenis));
            this.getReportProdiTableAdapter.Fill(this.honorariumDosenEksternalDataSet.getReportProdi, tanggal_Awal, tanggal_akhir, jenis);
            this.reportViewer1.RefreshReport();
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

        public void ShowDefaultProdi()
        {
            DateTime currentDate = DateTime.Now;
            DateTime start = currentDate.AddMonths(-2).AddDays(16 - currentDate.Day);
            txtTanggalAwal.Value = start;

            DateTime end = start.AddMonths(1).AddDays(15 - start.Day);
            txtTanggalAkhir.Value = end;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cmbJenisDosen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtTanggalAkhir_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtTanggalAwal_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
