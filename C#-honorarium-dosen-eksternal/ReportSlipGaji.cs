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
using System.Net.Mail;
using System.Net;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;

namespace C__honorarium_dosen_eksternal
{
    public partial class ReportSlipGaji : Form
    {
        string connectionString = ConfigurationManager.AppSettings["Connectionstring"];
        string emp = "";
        public ReportSlipGaji()
        {
            InitializeComponent();
        }

        private void ReportSlipGaji_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'honorariumDosenEksternalDataSet.getReportSlipGaji' table. You can move, or remove it, as needed.
            this.getListDosenTableAdapter.FillBy2(this.honorariumDosenEksternalDataSet.getListDosen, emp);
            this.reportViewer1.RefreshReport();
            ShowDefaultProdi();
        }

        private void SaveReportToPDF(string filePath)
        {
            Warning[] warnings;
            string[] streamIds;
            string mimeType;
            string encoding;
            string extension;

            byte[] pdfBytes = reportViewer1.LocalReport.Render("PDF", null, out mimeType, out encoding, out extension, out streamIds, out warnings);

            using (FileStream fs = new FileStream(filePath, FileMode.Create))
            {
                fs.Write(pdfBytes, 0, pdfBytes.Length);
            }
        }

        private DataTable getSpecificDosen(string id_dosen)
        {
            DataTable dataDosen = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM dbo.getSpecificDosen(@id_dosen)", connection);
                command.Parameters.AddWithValue("@id_dosen", id_dosen);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataDosen);
            }

            return dataDosen;
        }

        public void ShowDefaultProdi()
        {
            DateTime currentDate = DateTime.Now;
            DateTime start = currentDate.AddMonths(-2).AddDays(16 - currentDate.Day);
            txtTanggalAwal.Value = start;

            DateTime end = start.AddMonths(1).AddDays(15 - start.Day);
            txtTanggalAkhir.Value = end;
        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            string currentPath = Environment.CurrentDirectory;
            string[] splitPath = currentPath.Split(new string[] { "\\bin\\" }, StringSplitOptions.None);
            currentPath = splitPath[0];

            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("PERIODE", txtTanggalAwal.Text + " - " + txtTanggalAkhir.Text));
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("PENERIMA", cbDosen.Text));

            string tanggal_Awal = txtTanggalAwal.Value.ToString("yyyy-MM-dd");
            string tanggal_akhir = txtTanggalAkhir.Value.ToString("yyyy-MM-dd");
            this.getReportSlipGajiTableAdapter.Fill(this.honorariumDosenEksternalDataSet.getReportSlipGaji, cbDosen.SelectedValue.ToString(), tanggal_Awal, tanggal_akhir);

            this.reportViewer1.RefreshReport();
            string pdfPath = currentPath + "\\" + cbDosen.Text + ".pdf";
            SaveReportToPDF(pdfPath);
        }

        private void btnKirimEmail_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Apakah anda yakin untuk kirim email?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result1 == DialogResult.Yes)
            {
                string id_dosen = cbDosen.SelectedValue.ToString();
                string email = getSpecificDosen(id_dosen).Rows[0]["email"].ToString();
                string subject = "SLIP GAJI POLITEKNIK ASTRA" + txtTanggalAwal.Text + " - " + txtTanggalAkhir.Text;
                string body = "Dear " + cbDosen.Text + "\r\nKami dengan senang hati mengirimkan slip gaji Anda untuk periode " + txtTanggalAwal.Text + " - " + txtTanggalAkhir.Text + ". Ini adalah apresiasi kami terhadap upaya keras dan kontribusi yang Anda berikan di Politeknik Astra. Slip gaji ini berisi rincian gaji dan tunjangan yang Anda terima pada periode ini.\r\n\r\nKami ingin mengucapkan terima kasih atas dedikasi Anda dan harapan kami adalah Anda merasa dihargai dan diakui atas kerja keras Anda. Jika Anda memiliki pertanyaan atau membutuhkan penjelasan lebih lanjut tentang slip gaji ini, jangan ragu untuk menghubungi kami.\r\n\r\nKami berharap Anda terus memberikan kinerja terbaik dan mencapai kesuksesan dalam karir Anda di Politeknik Astra. Terima kasih atas kerjasama Anda dan semoga bulan ini membawa keberhasilan dan kebahagiaan bagi Anda.\r\n\r\nSalam hormat,\r\n\r\nRahmat Wahyu\r\nPoliteknik Astra";
                SendEmail sendEmail = new SendEmail(email, subject, body);
                sendEmail.send(cbDosen.Text);

                MessageBox.Show("Slip gaji berhasil dikirim!");
            }
        }
    }
}
