using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__honorarium_dosen_eksternal
{
    public partial class CRUDInsentif : Form
    {
        string connectionString = "integrated security=false; Data Source=10.8.9.99;User ID=sa;Password=polman; initial catalog=HonorariumDosenEksternal";
        string id_golongan, nama_golongan, insentif, tahun_bawah, tahun_atas;
        public CRUDInsentif()
        {
            InitializeComponent();
        }


        string emp = "";
        private void CRUDInsentif_Load(object sender, EventArgs e)
        {
       
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

        // Update Golongan
        private void btnUpdate_Click(object sender, EventArgs e)
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
            try
            {
                connection.Open();
                com.ExecuteNonQuery();
                MessageBox.Show("Update data berhasil ", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
                loadInsentif(emp);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubungi tim IT! " + ex.Message);
            }
        }

        //Delete Golongan
        private void btnDelete_Click(object sender, EventArgs e)
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
                        MessageBox.Show("Data Berhasil Dihapus!");
                        clear();
                        btnDelete.Enabled = true;
                        btnSave.Enabled = false;
                        btnUpdate.Enabled = false;
                        loadInsentif(emp);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hubungi tim IT! " + ex.Message);
                }
            }
        }

        // Clear
        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        // Search
        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            loadInsentif(txtSearch.Text);
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
                tahun_bawah = selectedRow.Cells["col_tahun_bawah"].Value.ToString();
                tahun_atas = selectedRow.Cells["col_tahun_atas"].Value.ToString() ;

                txtIDGolongan.Text = id_golongan;
                txtNamaGolongan.Text = nama_golongan;
                txtInsentifKehadiran.Text = insentif;
                txtTahunBatasBawah.Text = tahun_bawah;
                txtTahunBatasAtas.Text = tahun_atas;


                btnSave.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
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


        //Save Golongan
        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand com = new SqlCommand();
            com.Connection = connection;  // Assign the SqlConnection object
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "sp_CreateGolongan";  // Set the stored procedure name

            com.Parameters.AddWithValue("@nama", txtNamaGolongan.Text);
            com.Parameters.AddWithValue("@insentif_kehadiran", txtInsentifKehadiran.Text);
            com.Parameters.AddWithValue("@tahun_batas_bawah", txtTahunBatasBawah.Text);
            com.Parameters.AddWithValue("@tahun_batas_atas", txtTahunBatasAtas.Text);
            try
            {
                connection.Open();
                com.ExecuteNonQuery();
                MessageBox.Show("Simpan data berhasil ", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
                loadInsentif(emp);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubungi tim IT! " + ex.Message);
            }
        }
    }
}
