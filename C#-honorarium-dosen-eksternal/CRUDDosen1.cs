using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__honorarium_dosen_eksternal
{
    public partial class CRUDDosen : Form
    {
        public CRUDDosen()
        {
            InitializeComponent();
        }

       

        private void CRUDDosen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'honorariumDosenEksternalDataSet.dosen' table. You can move, or remove it, as needed.
            //this.dosenTableAdapter.Fill(this.honorariumDosenEksternalDataSet.dosen);
            // TODO: This line of code loads data into the 'honorariumDosenEksternalDataSet.perusahaan_astra' table. You can move, or remove it, as needed.
            //this.perusahaan_astraTableAdapter.Fill(this.honorariumDosenEksternalDataSet.perusahaan_astra);
            // TODO: This line of code loads data into the 'honorariumDosenEksternalDataSet.jenis_dosen' table. You can move, or remove it, as needed.
            // this.jenis_dosenTableAdapter.Fill(this.honorariumDosenEksternalDataSet.jenis_dosen);

            {
                btnSave.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                try
                {
                    this.getListDosenTableAdapter.FillBy1(this.honorariumDosenEksternalDataSet.getListDosen, nama_dosenToolStripTextBox.Text);
                }
                catch (System.Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show(ex.Message);
                }

            }
        }

        //Validasi Nama Dosen
        private void txtNamaDosen_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Memeriksa apakah karakter yang ditekan adalah huruf
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Mengabaikan karakter yang tidak valid dengan mengeset Handled ke true
                e.Handled = true;

                // Menampilkan pesan kesalahan
                MessageBox.Show("Hanya huruf dan spasi yang diizinkan.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Validasi Nama Bank
        private void txtNamaBank_KeyPress(object sender, KeyPressEventArgs e)
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

        //Validasi Cabang Bank
        private void txtCabangBank_KeyPress(object sender, KeyPressEventArgs e)
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


        //Validasi No Rek
        private void txtNoRekening_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Memeriksa apakah karakter yang ditekan adalah angka
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                string input = txtNoRekening.Text + e.KeyChar;

                // Memeriksa panjang input
                if (input.Length > 16)
                {
                    // Mengabaikan karakter yang tidak valid dengan mengeset Handled ke true
                    e.Handled = true;

                    // Menampilkan pesan kesalahan
                    MessageBox.Show("Hanya Boleh Angka dan Panjang maksimum adalah 16 karakter.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Validasi NPWP
        private void txtNpwp_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Memeriksa apakah karakter yang ditekan bukan angka atau kontrol (termasuk Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Mengabaikan karakter yang tidak valid dengan mengeset Handled ke true
                e.Handled = true;

                MessageBox.Show("Hanya angka yang diperbolehkan!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Menggabungkan karakter yang ditekan dengan teks yang ada
            string input = txtNpwp.Text;
            if (e.KeyChar != (char)Keys.Back)
            {
                input += e.KeyChar;
            }

            // Memeriksa panjang input
            if (input.Length > 25)
            {
                // Mengabaikan karakter yang tidak valid dengan mengeset Handled ke true
                e.Handled = true;
            }

            // Menampilkan pesan kesalahan jika panjang input melebihi 25 karakter
            if (input.Length > 25)
            {
                MessageBox.Show("Panjang maksimum adalah 25 karakter.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Validasi Atas Nama
        private void txtAtasNama_KeyPress(object sender, KeyPressEventArgs e)
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

        //validasi Tanggal Gabung Kampus
        private void txtGabungKampus_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Mengabaikan karakter yang bukan angka, karakter kontrol (seperti tombol backspace), atau karakter spasi
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            // Menggabungkan karakter yang ditekan dengan teks yang ada
            string input = txtGabungKampus.Text + e.KeyChar;

            // Memeriksa apakah panjang input telah mencapai 8 karakter (format: ddMMyyyy)
            if (input.Length >= 8)
            {
                // Mengambil tanggal dari input
                string inputDate = input.Substring(0, 2);
                string inputMonth = input.Substring(2, 2);
                string inputYear = input.Substring(4, 4);

                // Membuat objek DateTime dari input
                DateTime date;
                if (DateTime.TryParseExact(inputDate + inputMonth + inputYear, "ddMMyyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                {
                    // Membandingkan dengan tanggal saat ini
                    if (date > DateTime.Today)
                    {
                        e.Handled = true;

                        // Menampilkan pesan kesalahan
                        MessageBox.Show("Tanggal tidak boleh melebihi hari ini.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        //validasi Tanggal Gabung Industri
        private void txtGabungIndustri_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Mengabaikan karakter yang bukan angka, karakter kontrol (seperti tombol backspace), atau karakter spasi
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            // Menggabungkan karakter yang ditekan dengan teks yang ada
            string input = txtGabungIndustri.Text + e.KeyChar;

            // Memeriksa apakah panjang input telah mencapai 8 karakter (format: ddMMyyyy)
            if (input.Length >= 8)
            {
                // Mengambil tanggal dari input
                string inputDate = input.Substring(0, 2);
                string inputMonth = input.Substring(2, 2);
                string inputYear = input.Substring(4, 4);

                // Membuat objek DateTime dari input
                DateTime date;
                if (DateTime.TryParseExact(inputDate + inputMonth + inputYear, "ddMMyyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
                {
                    // Membandingkan dengan tanggal saat ini
                    if (date > DateTime.Today)
                    {
                        e.Handled = true;

                        // Menampilkan pesan kesalahan
                        MessageBox.Show("Tanggal tidak boleh melebihi hari ini.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        //Validasi Kota
        private void txtKota_KeyPress(object sender, KeyPressEventArgs e)
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

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.getListDosenTableAdapter.FillBy1(this.honorariumDosenEksternalDataSet.getListDosen, nama_dosenToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        //Validasi Email
        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool validEmail = ValidasiEmail(txtEmail.Text);

            if (!validEmail)
            {
                MessageBox.Show("Format Email salah!");
                // Kode untuk menangani email yang tidak valid
            }
        }

        public static bool ValidasiEmail(string email)
        {
            // Pola regular expression untuk validasi email
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            // Lakukan validasi menggunakan Regex.IsMatch
            return Regex.IsMatch(email, pattern);
        }


        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
