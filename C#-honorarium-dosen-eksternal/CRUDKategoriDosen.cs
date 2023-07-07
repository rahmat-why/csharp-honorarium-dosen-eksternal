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
    public partial class CRUDKategoriDosen : Form
    {
        public CRUDKategoriDosen()
        {
            InitializeComponent();
        }

        private void CRUDKategoriDosen_Load(object sender, EventArgs e)
        {
            try
            {
                btnSave.Enabled = true;
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
               
                this.getListJenisDosenTableAdapter.FillBy(this.honorariumDosenEksternalDataSet.getListJenisDosen, nama_jenisToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        //Validasi Nama Jenis
        private void txtNamaJenis_KeyPress(object sender, KeyPressEventArgs e)
        { // Memeriksa apakah karakter yang ditekan adalah huruf atau spasi
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Mengabaikan karakter yang tidak valid dengan mengeset Handled ke true
                e.Handled = true;

                // Menampilkan pesan kesalahan
                MessageBox.Show("Hanya huruf dan spasi yang diizinkan.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        //Validasi Kompensasi Pengajar
        private void txtTKompensasiMengajar_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Memeriksa apakah karakter yang ditekan adalah angka atau tombol Backspace
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Mengabaikan karakter yang tidak valid dengan mengeset Handled ke true

                MessageBox.Show("Hanya angka yang diperbolehkan!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Menggabungkan karakter yang ditekan dengan teks yang ada
            string input = txtTKompensasiMengajar.Text;
            if (e.KeyChar != (char)Keys.Back)
            {
                input += e.KeyChar;
            }

            // Memeriksa panjang input
            if (input.Length > 25)
            {
                e.Handled = true; // Mengabaikan karakter yang tidak valid dengan mengeset Handled ke true
            }

            // Menampilkan pesan kesalahan jika panjang input melebihi 25 karakter
            if (input.Length > 25)
            {
                MessageBox.Show("Panjang maksimum adalah 25 karakter.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        //Validasi Transpot Mengajar
        private void txtTranspotMengajar_KeyPress(object sender, KeyPressEventArgs e)
        {

        } 

        //Validasi Persentase PPH21 Npwp
        private void txtPersentasePPH21NPWP_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        //Validasi Persentase PPH21 NonNpwp
        private void txtPresentasePPH21NonNpwp_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
