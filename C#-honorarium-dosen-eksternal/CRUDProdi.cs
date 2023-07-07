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
    public partial class CRUDProdi : Form
    {
        public CRUDProdi()
        {
            InitializeComponent();
        }

        //Validasi Nama Prodi
        private void txtNamaProdi_KeyPress(object sender, KeyPressEventArgs e)
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

        //Validasi Singkatan
        private void txtSingkatan_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Memeriksa apakah karakter yang ditekan adalah huruf
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Mengabaikan karakter yang tidak valid dengan mengeset Handled ke true
                e.Handled = true;

                // Menampilkan pesan kesalahan jika karakter yang ditekan bukan spasi
                if (e.KeyChar != ' ')
                {
                    e.Handled = true;
                    MessageBox.Show("Hanya huruf yang diizinkan.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CRUDProdi_Load(object sender, EventArgs e)
        {
            try
            {
                this.getListProdiTableAdapter.FillBy(this.honorariumDosenEksternalDataSet.getListProdi, nama_prodiToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
