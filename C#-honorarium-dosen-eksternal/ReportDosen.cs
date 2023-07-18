using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace C__honorarium_dosen_eksternal
{
    public partial class ReportDosen : Form
    {
        ADTUser userlogin;
        public ReportDosen(ADTUser login)
        {
            InitializeComponent();
            userlogin = login;
        }

        string emp = "";
        private void ReportDosen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'honorariumDosenEksternalDataSet.getReportDosen' table. You can move, or remove it, as needed.
            this.getListJenisDosenTableAdapter.FillBy7(this.honorariumDosenEksternalDataSet.getListJenisDosen, emp);
            ShowDefaultDosen();
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
        public void ShowDefaultDosen()
        {
            DateTime currentDate = DateTime.Now;
            DateTime start = currentDate.AddMonths(-2).AddDays(16 - currentDate.Day);
            txtTanggalAwal.Value = start;

            DateTime end = start.AddMonths(1).AddDays(15 - start.Day);
            txtTanggalAkhir.Value = end;
        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            DateTime tanggal_awal = txtTanggalAwal.Value;
            string tanggal_Awal = txtTanggalAwal.Value.ToString("yyyy-MM-dd");
            string tanggal_akhir = txtTanggalAkhir.Value.ToString("yyyy-MM-dd");
            string jenis = cmbJenisDosen.SelectedValue.ToString();
            string nama_jenis = cmbJenisDosen.Text;
            string tahun_akademik = GetTahunAkademik(tanggal_awal);

            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("TAHUN", tahun_akademik));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("PERIODE", txtTanggalAwal.Text + " - " + txtTanggalAkhir.Text));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("JENISDOSEN", nama_jenis));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("CHECKEDBY", "Kepala DAAA"));

            this.getReportDosenTableAdapter.Fill(this.honorariumDosenEksternalDataSet.getReportDosen, tanggal_Awal, tanggal_akhir, jenis);
            this.reportViewer1.RefreshReport();
        }
    }
}
