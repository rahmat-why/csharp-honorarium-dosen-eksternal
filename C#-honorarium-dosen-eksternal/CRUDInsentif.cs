using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__honorarium_dosen_eksternal
{
    public partial class CRUDInsentif : Form
    {
        string connectionString = ConfigurationManager.AppSettings["Connectionstring"];
        string id_golongan, nama_golongan, insentif, tahun_bawah, tahun_atas;

       
        public CRUDInsentif()
        {
            InitializeComponent();
        }
         
        

        string emp = "";
        private void CRUDInsentif_Load(object sender, EventArgs e)
        {

            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            try
            {
                loadInsentif(emp);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        private void loadInsentif(string param)
        {
            this.getListGolonganTableAdapter.FillBy(this.honorariumDosenEksternalDataSet.getListGolongan,param);
        }

        //Validasi Nama Golongan
        private void txtNamaGolongan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Mencegah karakter yang tidak valid dimasukkan
                MessageBox.Show("Hanya huruf, angka, spasi, dan backspace yang diperbolehkan!");
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

        // Table Golongan
        private void tblGolongan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = tblGolongan.Rows[e.RowIndex];
                id_golongan = selectedRow.Cells["col_id_golongan"].Value.ToString();
                nama_golongan = selectedRow.Cells["col_nama_golongan"].Value.ToString();
                
                insentif = selectedRow.Cells["col_insentif"].Value.ToString();
                decimal decimal_insentif = decimal.Parse(insentif);
                string format_decimal = decimal_insentif.ToString("N0", new CultureInfo("id-ID"));
                txtInsentifKehadiran.Text = format_decimal.Replace(".", "");

                tahun_bawah = selectedRow.Cells["col_tahun_batas_bawah"].Value.ToString();
                tahun_atas = selectedRow.Cells["col_tahun_batas_atas"].Value.ToString() ;

                txtIDGolongan.Text = id_golongan;
                txtNamaGolongan.Text = nama_golongan;
                txtTahunBatasBawah.Text = tahun_bawah;
                txtTahunBatasAtas.Text = tahun_atas;

                btnSave.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }


        // Update golongan
        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (txtNamaGolongan.Text == "" || txtInsentifKehadiran.Text == "" || txtTahunBatasBawah.Text == "")
            {
                MessageBox.Show("Semua data harus diisi!");
                return;
            }

            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand com = new SqlCommand();
                com.Connection = connection;  // Assign the SqlConnection object
                com.CommandType = CommandType.StoredProcedure;
                com.CommandText = "sp_UpdateGolongan";  // Set the stored procedure name

                com.Parameters.AddWithValue("@id_golongan", txtIDGolongan.Text);
                com.Parameters.AddWithValue("@nama", txtNamaGolongan.Text);
                com.Parameters.AddWithValue("@insentif_kehadiran", txtInsentifKehadiran.Text);
                com.Parameters.AddWithValue("@tahun_batas_bawah", txtTahunBatasBawah.Text);
                com.Parameters.AddWithValue("@tahun_batas_atas", txtTahunBatasAtas.Text);

                connection.Open();
                com.ExecuteNonQuery();
                MessageBox.Show("Insentif berhasil diubah!", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSave.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = true;
                clear();
                loadInsentif(emp);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubungi tim IT! " + ex.Message);
            }
        }

        // Search
        private void txtSearch_KeyUp_1(object sender, KeyEventArgs e)
        {
            loadInsentif(txtSearch.Text);
        }

        //clear
        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
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
                    com.CommandText = "sp_DeleteGolongan";
                    com.CommandType = CommandType.StoredProcedure;

                    com.Parameters.AddWithValue("@id_golongan", txtIDGolongan.Text);

                    connection.Open();
                    int result = Convert.ToInt32(com.ExecuteNonQuery());
                    connection.Close();

                    if (result != 0)
                    {
                        MessageBox.Show("Insentif berhasil dihapus!");
                      

                        btnSave.Enabled = true;
                        btnDelete.Enabled = false;
                        btnUpdate.Enabled = false;
                        clear();
                        loadInsentif(emp);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hubungi tim IT! " + ex.Message);
                }
            }
        }

        private void tblGolongan_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((e.ColumnIndex == 2) && e.Value != null && e.Value is decimal decimalValue)
            {
                e.Value = decimalValue.ToString("N0", new CultureInfo("id-ID"));
                e.FormattingApplied = true;
            }
        }

        // save golongan
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if (txtNamaGolongan.Text == "" || txtInsentifKehadiran.Text == "" || txtTahunBatasBawah.Text == "")
            {
                MessageBox.Show("Semua data harus diisi!");
                return;
            }

            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand com = new SqlCommand();
                com.Connection = connection;
                com.CommandType = CommandType.StoredProcedure;
                com.CommandText = "sp_CreateGolongan";

                com.Parameters.AddWithValue("@nama", txtNamaGolongan.Text);
                com.Parameters.AddWithValue("@insentif_kehadiran", txtInsentifKehadiran.Text);
                com.Parameters.AddWithValue("@tahun_batas_bawah", txtTahunBatasBawah.Text);

                com.Parameters.AddWithValue("@tahun_batas_atas", txtTahunBatasAtas.Text);
                connection.Open();
                com.ExecuteNonQuery();
                MessageBox.Show("Insentif berhasil disimpan!", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSave.Enabled = true;
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
                clear();
                loadInsentif(emp);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubungi tim IT! " + ex.Message);
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

        // validasi tahun batas atas
        private void txtTahunBatasAtas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; // Mencegah karakter yang tidak valid dimasukkan
                MessageBox.Show("Hanya angka yang diperbolehkan!");
            }
        }

        //clear
        private void clear()
        {
            txtIDGolongan.Text = "Otomatis";
            txtNamaGolongan.Text = "";
            txtInsentifKehadiran.Text = "";
            txtTahunBatasBawah.Text = "";
            txtTahunBatasAtas.Text = "";
        }
    }
}
