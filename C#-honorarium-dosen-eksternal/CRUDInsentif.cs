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
    public partial class CRUDInsentif : Form
    {
        public CRUDInsentif()
        {
            InitializeComponent();
        }

        private void CRUDInsentif_Load(object sender, EventArgs e)
        {
       
            try
            {
                this.getListGolonganTableAdapter.FillBy(this.honorariumDosenEksternalDataSet.getListGolongan, nama_golonganToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        //Validasi Nama Golonga
        private void txtNamaGolongan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Mencegah karakter yang tidak valid dimasukkan
                MessageBox.Show("Hanya huruf yang diperbolehkan!");
            }
        }

        //Validasi Insentif Kehadiran
        private void txtInsentifKehadiran_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Mencegah karakter yang tidak valid dimasukkan
                MessageBox.Show("Hanya angka yang diperbolehkan!");
            }
        }

        //Validasi Tahun Batas Bawah
        private void txtTahunBatasBawah_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Mencegah karakter yang tidak valid dimasukkan
                MessageBox.Show("Hanya angka yang diperbolehkan!");
            }
        }

        private void txtTahunBatasAtas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Mencegah karakter yang tidak valid dimasukkan
                MessageBox.Show("Hanya angka yang diperbolehkan!");
            }

        }
    }
}
