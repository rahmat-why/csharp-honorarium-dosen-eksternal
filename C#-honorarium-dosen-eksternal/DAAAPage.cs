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
    public partial class DAAAPage : Form
    {
        public DAAAPage()
        {
            InitializeComponent();
        }

        private void PanelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DAAAPage_Load(object sender, EventArgs e)
        {

        }

        private void btnAbsensi_Click(object sender, EventArgs e)
        {
            Absensi absensi = new Absensi();
            absensi.TopLevel = false;
            PanelMenu.Controls.Add(absensi);
            absensi.BringToFront();
            absensi.Show();
        }

        private void btnLaporanDosen_Click(object sender, EventArgs e)
        {
            ReportDosen reportDosen = new ReportDosen();
            reportDosen.TopLevel = false;
            PanelMenu.Controls.Add(reportDosen);
            reportDosen.BringToFront();
            reportDosen.Show();
        }

        private void btnLaporanProdi_Click(object sender, EventArgs e)
        {
            ReportProdi reportProdi = new ReportProdi();
            reportProdi.TopLevel = false;
            PanelMenu.Controls.Add(reportProdi);
            reportProdi.BringToFront();
            reportProdi.Show();
        }

        private void btnLaporanTransfer_Click(object sender, EventArgs e)
        {
            ReportTransfer reportTransfer = new ReportTransfer();
            reportTransfer.TopLevel = false;
            PanelMenu.Controls.Add(reportTransfer);
            reportTransfer.BringToFront();
            reportTransfer.Show();
        }

        private void btnLaporanSlipGaji_Click(object sender, EventArgs e)
        {
            ReportSlipGaji reportSlip = new ReportSlipGaji();
            reportSlip.TopLevel = false;
            PanelMenu.Controls.Add(reportSlip);
            reportSlip.BringToFront();
            reportSlip.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Yakin ingin keluar?", "Logout!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                // Tampilkan form login
                LoginForm loginForm = new LoginForm();
                loginForm.Show();

                // Tutup form saat ini (Form saat ini adalah Form yang memiliki tombol Logout)
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                // Tidak ada tindakan yang diperlukan jika pengguna memilih "No"
            }
        }
    }
}
