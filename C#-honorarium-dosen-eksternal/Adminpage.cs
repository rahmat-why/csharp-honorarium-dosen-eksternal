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
    public partial class Adminpage : Form
    {
        public Adminpage()
        {
            InitializeComponent();
        }



        private void btnUser_Click(object sender, EventArgs e)
        {
            CRUDUser user = new CRUDUser();
            user.TopLevel = false;
            PanelMenu.Controls.Add(user);
            user.BringToFront();
            user.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Yakin ingin keluar?", "Logout!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
              
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void btnMatkul_Click(object sender, EventArgs e)
        {
            CRUDMatkul matkul = new CRUDMatkul();
            matkul.TopLevel = false;
            PanelMenu.Controls.Add(matkul);
            matkul.BringToFront();
            matkul.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
           CRUDInsentif insentif = new CRUDInsentif();
            insentif.TopLevel = false;
            PanelMenu.Controls.Add(insentif);
            insentif.BringToFront();
            insentif.Show();
        }

        private void btnProdi_Click(object sender, EventArgs e)
        {

            CRUDProdi prodi = new CRUDProdi();
            prodi.TopLevel = false;
            PanelMenu.Controls.Add(prodi);
            prodi.BringToFront();
            prodi.Show();

        }

  

        private void btnDosen_Click_1(object sender, EventArgs e)
        {
            CRUDDosen dosen = new CRUDDosen();
            dosen.TopLevel = false;
            PanelMenu.Controls.Add(dosen);
            dosen.BringToFront();
            dosen.Show();

        }

        private void btnKategoriDosen_Click(object sender, EventArgs e)
        {
            CRUDKategoriDosen KategoriDosen = new CRUDKategoriDosen();
            KategoriDosen.TopLevel = false;
            PanelMenu.Controls.Add(KategoriDosen);
            KategoriDosen.BringToFront();
            KategoriDosen.Show();
        }

        private void txtPerusahaan_Click(object sender, EventArgs e)
        {
            CRUDPerusahaan perusahaan = new CRUDPerusahaan();   
            perusahaan.TopLevel = false;
            PanelMenu.Controls.Add(perusahaan);
            perusahaan.BringToFront();
            perusahaan.Show();
           /*Absensi absensi = new Absensi();
            absensi.TopLevel = false;
            PanelMenu.Controls.Add(absensi);
            absensi.BringToFront();
            absensi.Show();*/
        }
    }
}
