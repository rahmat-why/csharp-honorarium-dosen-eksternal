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
    public partial class CRUDMatkul : Form
    {
        public CRUDMatkul()
        {
            InitializeComponent();
        }



        private void CRUDMatkul_Load(object sender, EventArgs e)
        {
          
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                this.getListMatkulTableAdapter.Filter(this.honorariumDosenEksternalDataSet.getListMatkul, nama_matkulToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void filterToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.getListMatkulTableAdapter.Filter(this.honorariumDosenEksternalDataSet.getListMatkul, nama_matkulToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        
        //validasi nama matkul
        private void txtMataKuliah_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Memeriksa apakah karakter yang ditekan adalah huruf atau spasi
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Mengabaikan karakter yang tidak valid dengan mengeset Handled ke true
                e.Handled = true;

                // Menampilkan pesan kesalahan
                MessageBox.Show("Hanya huruf dan spasi yang diizinkan.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // validasi sks
        private void txtSks_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Memeriksa apakah karakter yang ditekan adalah angka
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Mengabaikan karakter yang tidak valid dengan mengeset Handled ke true
                e.Handled = true;

                // Menampilkan pesan kesalahan
                MessageBox.Show("Hanya angka yang diizinkan.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
