using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__honorarium_dosen_eksternal
{
    public partial class CRUDKategoriDosen : Form
    {
        string connectionString = ConfigurationManager.AppSettings["Connectionstring"];
        string id_jenis_dosen, nama_jenis, kompensasi_mengajar, transport_mengajar, persentasePph21Npwp, persentasePph21NoNpwp, referensi_dosen;

      
        public CRUDKategoriDosen()
        {
            InitializeComponent();
        }



        string emp = "";
        private void CRUDKategoriDosen_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            try
            {
                loadkategori(emp);
            
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void loadkategori(string param)
        {
            this.getListJenisDosenTableAdapter.FillBy2(this.honorariumDosenEksternalDataSet.getListJenisDosen, param);
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
            string input = txtKompensasiMengajar.Text;
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
            // Memeriksa apakah karakter yang ditekan bukan angka atau bukan tombol kontrol
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Mencegah karakter yang tidak valid ditampilkan pada TextBox
                e.Handled = true;
            }
        }


        //Validasi Persentase PPH21 Npwp
        private void txtPersentasePPH21NPWP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Mencegah karakter yang tidak valid dimasukkan
                MessageBox.Show("Hanya angka dan titik desimal yang diperbolehkan!");
            }
        }



        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result1 == DialogResult.Yes)
            {
                try
                {
                    SqlConnection connection = new SqlConnection(connectionString);
                    SqlCommand com = new SqlCommand();
                    com.Connection = connection;
                    com.CommandText = "sp_DeleteJenisDosen";
                    com.CommandType = CommandType.StoredProcedure;

                    com.Parameters.AddWithValue("@id_jenis_dosen", txtIDJenisDosen.Text);

                    connection.Open();
                    int result = Convert.ToInt32(com.ExecuteNonQuery());
                    connection.Close();

                    if (result != 0)
                    {
                        MessageBox.Show("Data berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnSave.Enabled = true;
                        btnDelete.Enabled = false;
                        btnUpdate.Enabled = false;
                        clear();
                        loadkategori(emp);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hubungi tim IT! " + ex.Message);
                }
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand com = new SqlCommand();
                com.Connection = connection;
                com.CommandType = CommandType.StoredProcedure;
                com.CommandText = "sp_UpdateJenisDosen";

                com.Parameters.AddWithValue("@id_jenis_dosen", txtIDJenisDosen.Text);
                com.Parameters.AddWithValue("@nama_jenis", txtNamaJenis.Text);
                com.Parameters.AddWithValue("@kompensasi_mengajar", txtKompensasiMengajar.Text);
                com.Parameters.AddWithValue("@transport_mengajar", txtTranspotMengajar.Text);
                com.Parameters.AddWithValue("@persentase_pph21_npwp", txtPersentasePPH21NPWP.Text);
                com.Parameters.AddWithValue("@persentase_pph21_nonnpwp", txtPresentasePPH21NonNpwp.Text);
                com.Parameters.AddWithValue("@referensi_dosen", cmbReferensiDosen.SelectedItem.ToString());

                connection.Open();
                int result = com.ExecuteNonQuery();
                connection.Close();

                if (result > 0)
                {
                    MessageBox.Show("Update berhasil!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Update gagal!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                btnSave.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;

                clear();
                loadkategori(emp);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubungi tim IT! " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            loadkategori(txtSearch.Text);
        }

        private void tblKategoriDosen_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = tblKategoriDosen.Rows[e.RowIndex];

                // Retrieve the data from the selected row
                id_jenis_dosen = selectedRow.Cells["col_id_jenis_dosen"].Value.ToString();
                nama_jenis = selectedRow.Cells["col_nama_jenis"].Value.ToString();
                kompensasi_mengajar = selectedRow.Cells["col_kompensasi"].Value.ToString();
                transport_mengajar = selectedRow.Cells["col_Transport"].Value.ToString();
                persentasePph21Npwp = selectedRow.Cells["col_npwp"].Value.ToString();
                persentasePph21NoNpwp = selectedRow.Cells["col_NonNpwp"].Value.ToString();
                referensi_dosen = selectedRow.Cells["col_referensi"].Value.ToString() ;


                txtIDJenisDosen.Text = id_jenis_dosen;
                txtNamaJenis.Text = nama_jenis;
                txtKompensasiMengajar.Text = kompensasi_mengajar;
                txtPersentasePPH21NPWP.Text = persentasePph21Npwp;
                txtPresentasePPH21NonNpwp.Text = persentasePph21NoNpwp;
                txtTranspotMengajar.Text = transport_mengajar;

                foreach (var item in cmbReferensiDosen.Items)
                {
                    // Mengambil nilai display dari setiap opsi
                    string displayValue = item.ToString();

                    // Memeriksa jika nilai display cocok dengan yang diinginkan
                    if (displayValue == referensi_dosen)
                    {
                        // Mengatur opsi terpilih berdasarkan nilai display
                        cmbReferensiDosen.SelectedItem = item;
                        break;
                    }
                }

                btnSave.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }
        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            loadkategori(txtSearch.Text);
        }

        //Validasi Persentase PPH21 NonNpwp
        private void txtPresentasePPH21NonNpwp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Mencegah karakter yang tidak valid dimasukkan
                MessageBox.Show("Hanya angka dan titik desimal yang diperbolehkan!");
            }
        }

        // clear kategori
        private void clear()
        {
            txtIDJenisDosen.Text = "Otomatis";
            txtNamaJenis.Text = "";
            txtKompensasiMengajar.Text = "";
            txtPersentasePPH21NPWP.Text = "";
            txtTranspotMengajar.Text = "";
            txtPresentasePPH21NonNpwp.Text = "";
            cmbReferensiDosen.Text = "";
        }

        // Save Kaegori
        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand com = new SqlCommand();
            com.Connection = connection; 
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "sp_CreateJenisDosen";

            if (txtNamaJenis.Text == "" || txtKompensasiMengajar.Text == "" || txtTranspotMengajar.Text == "" ||
                txtPersentasePPH21NPWP.Text == "" || txtPresentasePPH21NonNpwp.Text == "" || cmbReferensiDosen.SelectedItem == null)
            {
                MessageBox.Show("Semua data harus diisi!");
                return;
            }

            com.Parameters.AddWithValue("@nama_jenis", txtNamaJenis.Text);
            com.Parameters.AddWithValue("@kompensasi_mengajar", txtKompensasiMengajar.Text);
            com.Parameters.AddWithValue("@transport_mengajar", txtTranspotMengajar.Text);
            com.Parameters.AddWithValue("@persentase_pph21_npwp", txtPersentasePPH21NPWP.Text);
            com.Parameters.AddWithValue("@persentase_pph21_nonnpwp", txtPresentasePPH21NonNpwp.Text);
            com.Parameters.AddWithValue("@referensi_dosen", cmbReferensiDosen.SelectedItem.ToString());

            try
            {
                connection.Open();
                com.ExecuteNonQuery();
                MessageBox.Show("Data saved successfully", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSave.Enabled = true;
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
                clear();
                loadkategori(emp);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubungi tim IT! " + ex.Message);
            }
        }
    
    }
}
