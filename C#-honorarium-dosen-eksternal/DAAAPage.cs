﻿using System;
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
    public partial class DAAAPage : Form
    {
        ADTUser userlogin;
        public DAAAPage(ADTUser login)
        {
            InitializeComponent();
            labelLogin.Text = login.getNama() + " - " + login.getRole();
            userlogin = login;
        }

        private void btnAbsensi_Click(object sender, EventArgs e)
        {
            Absensi absensi = new Absensi(userlogin);
            absensi.TopLevel = false;
            PanelMenu.Controls.Add(absensi);
            absensi.BringToFront();
            absensi.Show();
        }

        private void btnLaporanDosen_Click(object sender, EventArgs e)
        {
            ReportDosen reportDosen = new ReportDosen(userlogin);
            reportDosen.TopLevel = false;
            PanelMenu.Controls.Add(reportDosen);
            reportDosen.BringToFront();
            reportDosen.Show();
        }

        private void btnLaporanProdi_Click(object sender, EventArgs e)
        {
            ReportProdi reportProdi = new ReportProdi(userlogin);
            reportProdi.TopLevel = false;
            PanelMenu.Controls.Add(reportProdi);
            reportProdi.BringToFront();
            reportProdi.Show();
        }

        private void btnLaporanTransfer_Click(object sender, EventArgs e)
        {
            ReportTransfer reportTransfer = new ReportTransfer(userlogin);
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
