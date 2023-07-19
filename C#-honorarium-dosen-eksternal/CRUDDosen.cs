using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace C__honorarium_dosen_eksternal
{
    public partial class CRUDDosen : Form
    {
        string connectionString = ConfigurationManager.AppSettings["Connectionstring"];
        string id_dosen, nama_dosen, email, id_jenis_dosen, nama_bank, cabang_bank, no_rekening, npwp, tanggal_gabung_kampus, tanggal_gabung_industri, status, atasnama, kota, id_perusahaan, foto_dosen;
        string nama_jenis, nama_perusahaan, asal_perusahaan;

        byte[] pic;

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtNamaDosen.Text == "" || txtEmail.Text == "" || cbStatus.Text == "" || txtNamaBank.Text == "" ||
                    txtCabangBank.Text == "" || txtNoRekening.Text == "" || txtAtasNama.Text == "" ||
                    txtKota.Text == "")
            {
                MessageBox.Show("harap lengkapi semua data!");
                return;
            }

            if (ValidasiEmail(txtEmail.Text) == false)
            {
                MessageBox.Show("Format email tidak valid!");
                return;
            }

            if (txtGabungKampus.Value > DateTime.Today || txtGabungIndustri.Value > DateTime.Today)
            {
                MessageBox.Show("Tanggal gabung tidak boleh lebih dari hari ini.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(imgDosen.Image == null)
            {
                MessageBox.Show("Foto dosen harus diisi!");
                return;
            }

            try
            {
                using (Bitmap bitmap = new Bitmap(imgDosen.Image))
                {
                    using (MemoryStream stream = new MemoryStream())
                    {
                        bitmap.Save(stream, ImageFormat.Jpeg);
                        pic = stream.ToArray();

                        SqlConnection connection = new SqlConnection(connectionString);
                        SqlCommand com = new SqlCommand();
                        com.Connection = connection;
                        com.CommandText = "sp_UpdateDosen";
                        com.CommandType = CommandType.StoredProcedure;

                        com.Parameters.AddWithValue("@id_dosen", txtIDDosen.Text);
                        com.Parameters.AddWithValue("@nama_dosen", txtNamaDosen.Text);
                        com.Parameters.AddWithValue("@email", txtEmail.Text);
                        com.Parameters.AddWithValue("@id_jenis_dosen", (string) cbJenisDosen.SelectedValue);
                        com.Parameters.AddWithValue("@nama_bank", txtNamaBank.Text);
                        com.Parameters.AddWithValue("@cabang_bank", txtCabangBank.Text);
                        com.Parameters.AddWithValue("@no_rekening", txtNoRekening.Text);
                        com.Parameters.AddWithValue("@npwp", txtNpwp.Text);
                        com.Parameters.AddWithValue("@tanggal_gabung_kampus", txtGabungKampus.Value);
                        com.Parameters.AddWithValue("@tanggal_gabung_industri", txtGabungIndustri.Value);
                        com.Parameters.AddWithValue("@status", cbStatus.SelectedItem.ToString());
                        com.Parameters.AddWithValue("@atasnama", txtAtasNama.Text);
                        com.Parameters.AddWithValue("@kota", txtKota.Text);
                        com.Parameters.AddWithValue("@id_perusahaan", (string) cbAsalPerusahaan.SelectedValue);
                        com.Parameters.AddWithValue("@foto_dosen", pic);

                        connection.Open();

                        com.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Dosen berhasil diubah!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnSave.Enabled = true;
                // btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
                clear();
                loadDosen(emp);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubungi tim IT! " + ex.Message);
            }
        }

        private void loadDosen(string param)
        {
            this.getListDosenTableAdapter.FillBy1(this.honorariumDosenEksternalDataSet.getListDosen, param);
        }

        private void clear()
        {
            txtIDDosen.Text = "Otomatis";
            txtNamaDosen.Text = "";
            txtEmail.Text = "";
            txtNamaBank.Text = "";
            txtNoRekening.Text = "";
            txtCabangBank.Text = "";
            txtNpwp.Text = "";
            txtAtasNama.Text = "";
            txtKota.Text = "";
            imgDosen.Image = null;
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            loadDosen(txtSearch.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            // btnDelete.Enabled = false;
        }

        private void txtSearch_KeyUp_1(object sender, KeyEventArgs e)
        {
            loadDosen(txtSearch.Text);
        }

        public string GetReferensiDosen(string id_jenis_dosen)
        {
            string referensiDosen = "";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM dbo.getSpecificJenisDosen(@id_jenis_dosen)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id_jenis_dosen", id_jenis_dosen);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            referensiDosen = dataTable.Rows[0]["referensi_dosen"].ToString();
                        }
                    }
                }
            }

            return referensiDosen;

        }

        private void cbJenisDosen_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string referensi_dosen = GetReferensiDosen(cbJenisDosen.SelectedValue.ToString());
            
            cbAsalPerusahaan.Enabled = true;
            txtGabungIndustri.Enabled = true;
            if(referensi_dosen == "UMUM")
            {
                cbAsalPerusahaan.Enabled = false;
                txtGabungIndustri.Enabled = false;
            }
        }

        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = guna2DataGridView1.Rows[e.RowIndex];

                id_dosen = selectedRow.Cells["col_id_dosen"].Value.ToString();
                nama_dosen = selectedRow.Cells["col_nama_dosen"].Value.ToString();
                email = selectedRow.Cells["col_email"].Value.ToString();
                nama_jenis = selectedRow.Cells["col_nama_jenis"].Value.ToString();
                nama_bank = selectedRow.Cells["col_nama_bank"].Value.ToString();
                cabang_bank = selectedRow.Cells["col_cabang_bank"].Value.ToString();
                no_rekening = selectedRow.Cells["col_no_rekening"].Value.ToString();
                npwp = selectedRow.Cells["col_npwp"].Value.ToString();
                status = selectedRow.Cells["col_status"].Value.ToString();
                atasnama = selectedRow.Cells["col_atasnama"].Value.ToString();
                kota = selectedRow.Cells["col_kota"].Value.ToString();
                asal_perusahaan = selectedRow.Cells["col_asal_perusahaan"].Value.ToString();

                txtGabungKampus.Enabled = true;
                tanggal_gabung_kampus = selectedRow.Cells["col_tanggal_gabung_kampus"].Value.ToString();
                if (!string.IsNullOrEmpty(tanggal_gabung_kampus))
                {
                    if (DateTime.TryParse(tanggal_gabung_kampus, out DateTime tanggal))
                    {
                        txtGabungKampus.Value = tanggal;
                    }
                }
                else
                {
                    txtGabungKampus.Enabled = false; // Menonaktifkan txtGabungKampus karena nilai null
                }

                txtGabungIndustri.Enabled = true;
                tanggal_gabung_industri = selectedRow.Cells["col_tanggal_gabung_industri"].Value.ToString();
                if (!string.IsNullOrEmpty(tanggal_gabung_industri))
                {
                    if (DateTime.TryParse(tanggal_gabung_industri, out DateTime tanggal))
                    {
                        txtGabungIndustri.Value = tanggal;
                    }
                }
                else
                {
                    txtGabungIndustri.Enabled = false; // Menonaktifkan txtGabungKampus karena nilai null
                }

                txtIDDosen.Text = id_dosen;
                txtNamaDosen.Text = nama_dosen;
                txtEmail.Text = email;

                // Loop melalui setiap opsi ComboBox
                foreach (var item in cbJenisDosen.Items)
                {
                    // Mengambil nilai display dari setiap opsi
                    string displayValue = ((DataRowView)item)["nama_jenis"].ToString();

                    // Memeriksa jika nilai display cocok dengan yang diinginkan
                    if (displayValue == nama_jenis)
                    {
                        // Mengatur opsi terpilih berdasarkan nilai display
                        cbJenisDosen.SelectedItem = item;
                        break;
                    }
                }

                // Loop melalui setiap opsi ComboBox
                foreach (var item in cbAsalPerusahaan.Items)
                {
                    // Mengambil nilai display dari setiap opsi
                    string displayValue = ((DataRowView)item)["nama_perusahaan"].ToString();

                    // Memeriksa jika nilai display cocok dengan yang diinginkan
                    if (displayValue == asal_perusahaan)
                    {
                        // Mengatur opsi terpilih berdasarkan nilai display
                        cbAsalPerusahaan.SelectedItem = item;
                        break;
                    }
                }

                cbStatus.SelectedItem = status;

                txtNamaBank.Text = nama_bank;
                txtCabangBank.Text = cabang_bank;
                txtNoRekening.Text = no_rekening;
                txtNpwp.Text = npwp;
                txtAtasNama.Text = atasnama;
                txtKota.Text = kota;

                try
                {
                    pic = (byte[])selectedRow.Cells["col_foto_dosen"].Value;
                    if (pic != null && pic.Length > 0)
                    {
                        using (MemoryStream ms = new MemoryStream(pic))
                        {
                            imgDosen.Image = Image.FromStream(ms);
                        }
                    }
                    else
                    {
                        imgDosen.Image = null;
                    }
                }
                catch (Exception exc)
                {
                    imgDosen.Image = null;
                }

                btnSave.Enabled = false;
                btnUpdate.Enabled = true;
                // btnDelete.Enabled = true;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image File(.jpg; *.jpeg; *.png) |  *.jpg;.jpeg; *.png";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog.OpenFile()) != null)
                    {
                        string Filename = openFileDialog.FileName;
                        FileInfo fileInfo = new FileInfo(Filename);
                        if (myStream.Length > 512000)
                        {
                            MessageBox.Show("The file size is too big! Please select a file with a maximum size of 5 MB!");
                        }
                        else
                        {
                            imgDosen.Load(Filename);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hubungi tim IT! " + ex.Message);
                }
            }
        }

        string emp = "";

        public CRUDDosen()
        {
            InitializeComponent();
        }

        private void CRUDDosen_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            // btnDelete.Enabled = false;
            try
            {
                loadDosen(emp);
                this.getListJenisDosenTableAdapter.FillBy1(this.honorariumDosenEksternalDataSet.getListJenisDosen, emp);
                this.getListPerusahaanTableAdapter.FillBy7(this.honorariumDosenEksternalDataSet.getListPerusahaan, emp);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            cbStatus.Text = "AKTIF";
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
                MessageBox.Show("Kolom ini hanya boleh diisi huruf dan spasi.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Kolom ini hanya boleh diisi huruf dan spasi.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Kolom ini hanya boleh diisi huruf dan spasi.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        //Validasi No Rek
        private void txtNoRekening_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Memeriksa apakah karakter yang ditekan bukan angka atau kontrol (termasuk Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Mengabaikan karakter yang tidak valid dengan mengeset Handled ke true
                e.Handled = true;

                MessageBox.Show("Kolom ini hanya boleh diisi angka. ", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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

        //Validasi NPWP
        private void txtNpwp_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Memeriksa apakah karakter yang ditekan bukan angka atau kontrol (termasuk Backspace)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Mengabaikan karakter yang tidak valid dengan mengeset Handled ke true
                e.Handled = true;

                MessageBox.Show("Kolom ini hanya boleh diisi angka.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Kolom ini hanya boleh diisi huruf dan spasi.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Kolom ini hanya boleh diisi huruf dan spasi.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            try
            {
                if (imgDosen.Image == null)
                {
                    MessageBox.Show("harap lengkapi semua data!");
                    return;
                }

                if (txtNamaDosen.Text == "" || txtEmail.Text == "" || cbStatus.Text == "" || txtNamaBank.Text == "" ||
                    txtCabangBank.Text == "" || txtNoRekening.Text == "" || txtAtasNama.Text == "" ||
                    txtKota.Text == "")
                {
                    MessageBox.Show("harap lengkapi semua data!");
                    return;
                }

                if (ValidasiEmail(txtEmail.Text) == false)
                {
                    MessageBox.Show("Format email tidak valid!");
                    return;
                }

                if (txtGabungKampus.Value > DateTime.Today || txtGabungIndustri.Value > DateTime.Today)
                {
                    MessageBox.Show("Tanggal gabung tidak boleh lebih dari hari ini.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MemoryStream stream = new MemoryStream();
                imgDosen.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);

                pic = stream.ToArray();

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand com = new SqlCommand();
                com.Connection = connection;
                com.CommandText = "sp_CreateDosen";
                com.CommandType = CommandType.StoredProcedure;

                com.Parameters.AddWithValue("@nama_dosen", txtNamaDosen.Text);
                com.Parameters.AddWithValue("@email", txtEmail.Text);
                com.Parameters.AddWithValue("@id_jenis_dosen", (string) cbJenisDosen.SelectedValue);
                com.Parameters.AddWithValue("@nama_bank", txtNamaBank.Text);
                com.Parameters.AddWithValue("@cabang_bank", txtCabangBank.Text);
                com.Parameters.AddWithValue("@no_rekening", txtNoRekening.Text);
                com.Parameters.AddWithValue("@npwp", txtNpwp.Text);
                com.Parameters.AddWithValue("@tanggal_gabung_kampus", txtGabungKampus.Value);
                com.Parameters.AddWithValue("@tanggal_gabung_industri", txtGabungIndustri.Value);
                com.Parameters.AddWithValue("@status", cbStatus.SelectedItem.ToString());
                com.Parameters.AddWithValue("@atasnama", txtAtasNama.Text);
                com.Parameters.AddWithValue("@kota", txtKota.Text);
                com.Parameters.AddWithValue("@id_perusahaan", (string) cbAsalPerusahaan.SelectedValue);
                com.Parameters.AddWithValue("@foto_dosen", pic);

                connection.Open();
                int result = Convert.ToInt32(com.ExecuteNonQuery());
                connection.Close();

                MessageBox.Show("Dosen berhasil ditambah!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnSave.Enabled = true;
                btnUpdate.Enabled = false;
                // btnDelete.Enabled = false;
                loadDosen(emp);

                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubungi tim IT! " + ex.Message);
            }
        }
    }
}
