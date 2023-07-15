using Guna.UI2.WinForms;
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
    public partial class CRUDMatkul : Form
    {
        string connectionString = "integrated security=false; Data Source=10.8.9.99;User ID=sa;Password=polman; initial catalog=HonorariumDosenEksternal";
        string id_matkul, nama_matkul, Sks;
        public CRUDMatkul()
        {
            InitializeComponent();
        }


        string emp = "";
        private void CRUDMatkul_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            try
            {
                loadMatkul(emp);
                
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void loadMatkul(string param)
        {
            this.getListMatkulTableAdapter.Filter(this.honorariumDosenEksternalDataSet.getListMatkul, param);
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



        private void clear()
        {
            txtIDMatkul.Text = "Otomatis";
            txtMataKuliah.Text = "";
            txtSks.Text = "";
        }

        // update matkul
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand com = new SqlCommand();
            com.Connection = connection;  // Assign the SqlConnection object
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "sp_UpdateMatkul";  // Set the stored procedure name

            com.Parameters.AddWithValue("@id_matkul", txtIDMatkul.Text);
            com.Parameters.AddWithValue("@nama_matkul", txtMataKuliah.Text);
            com.Parameters.AddWithValue("@sks", txtSks.Text);
            try
            {
                connection.Open();
                com.ExecuteNonQuery();
                MessageBox.Show("Update berhasil", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
                loadMatkul(emp);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubungi tim IT! " + ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            loadMatkul(txtSearch.Text);
        }

        //delete matkul
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
                    com.CommandText = "sp_DeleteMatkul";
                    com.CommandType = CommandType.StoredProcedure;

                    com.Parameters.AddWithValue("@id_matkul", txtIDMatkul.Text);

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
                        loadMatkul(emp);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hubungi tim IT! " + ex.Message);
                }
            }
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            loadMatkul(txtSearch.Text);
        }

        private void tblMatkul_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = tblMatkul.Rows[e.RowIndex];
                id_matkul = selectedRow.Cells["col_id_matkul"].Value.ToString();
                nama_matkul = selectedRow.Cells["col_nama_matkul"].Value.ToString();
                Sks = selectedRow.Cells["col_sks"].Value.ToString();

                txtIDMatkul.Text = id_matkul;
                txtMataKuliah.Text = nama_matkul;
                txtSks.Text = Sks;

                btnSave.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }
    



        // save matkul
        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand com = new SqlCommand();
            com.Connection = connection;  // Assign the SqlConnection object
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "sp_CreateMatkul";  // Set the stored procedure name

            com.Parameters.AddWithValue("@nama_matkul", txtMataKuliah.Text);
            com.Parameters.AddWithValue("@sks" , txtSks.Text);
            try
            {
                connection.Open();
                com.ExecuteNonQuery();
                MessageBox.Show("Data saved successfully", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
                loadMatkul(emp);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubungi tim IT! " + ex.Message);
            }

        }
    }
}
