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

namespace C__honorarium_dosen_eksternal
{
    public partial class ReportSlipGaji : Form
    {
        string emp = "";
        public ReportSlipGaji()
        {
            InitializeComponent();
        }

        private void ReportSlipGaji_Load(object sender, EventArgs e)
        {
            this.getListDosenTableAdapter.FillBy2(this.honorariumDosenEksternalDataSet.getListDosen, emp);
            this.reportViewer1.RefreshReport();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string currentPath = Environment.CurrentDirectory;
            string[] splitPath = currentPath.Split(new string[] { "\\bin\\" }, StringSplitOptions.None);
            currentPath = splitPath[0];

            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("PERIODE", txtTanggalAwal.Text+" - "+txtTanggalAkhir.Text));
            this.getReportSlipGajiTableAdapter.FillBy(this.honorariumDosenEksternalDataSet.getReportSlipGaji, cbDosen.SelectedValue.ToString(), txtTanggalAwal.Text, txtTanggalAkhir.Text);
            this.reportViewer1.RefreshReport();
            string pdfPath = currentPath + "\\" + cbDosen.Text + ".pdf";
            SaveReportToPDF(pdfPath);
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

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            string subject = "SLIP GAJI POLITEKNIK ASTRA"+ txtTanggalAwal.Text + " - " + txtTanggalAkhir.Text;
            string body = "Berikut ini lampiran slip gaji anda:";
            SendEmail sendEmail = new SendEmail("rahmatwahyubudiyanto@gmail.com", subject, body);
            sendEmail.send(cbDosen.Text);
        }
    }
}
