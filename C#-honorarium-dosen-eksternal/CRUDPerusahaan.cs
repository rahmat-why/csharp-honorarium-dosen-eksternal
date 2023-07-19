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
    public partial class CRUDPerusahaan : Form
    {
        string connectionString = ConfigurationManager.AppSettings["Connectionstring"];
        string ID_perusahaan, nama_perusahaan, singkatan;

        public CRUDPerusahaan()
        {
            InitializeComponent();
        }

        string emp = "";

        private void CRUDPerusahaan_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            try
            {
                loadPerusahaan(emp);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void loadPerusahaan(string param)
        {
            this.getListPerusahaanTableAdapter.FillBy5(this.honorariumDosenEksternalDataSet.getListPerusahaan,param);
        }

        private void txtNamaPerusahaan_KeyPress(object sender, KeyPressEventArgs e)
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

        private void clear()
        {
            txtIDPerusahaan.Text = "Otomatis";
            txtNamaPerusahaan.Text = "";
            txtSingkatan.Text = "";
        }
        private void tblPerusahaan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = tblPerusahaan.Rows[e.RowIndex];
                ID_perusahaan = selectedRow.Cells["col_id_perusahaan"].Value.ToString();
                nama_perusahaan = selectedRow.Cells["col_nama_perusahaan"].Value.ToString();
                singkatan = selectedRow.Cells["col_singkatan_perusahaan"].Value.ToString();

                txtIDPerusahaan.Text = ID_perusahaan;
                txtNamaPerusahaan.Text = nama_perusahaan;
                txtSingkatan.Text = singkatan;

                btnSave.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }
        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            loadPerusahaan(txtSearch.Text);
        }

        //Delete Perusahaan
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
                    com.CommandText = "sp_DeletePerusahaan";
                    com.CommandType = CommandType.StoredProcedure;

                    com.Parameters.AddWithValue("@id_perusahaan", txtIDPerusahaan.Text);

                    connection.Open();
                    int result = Convert.ToInt32(com.ExecuteNonQuery());
                    connection.Close();

                    if (result != 0)
                    {
                        MessageBox.Show("Perusahaan berhasil dihapus!");
                        btnSave.Enabled = true;
                        btnDelete.Enabled = false;
                        btnUpdate.Enabled = false;
                        clear();
                        loadPerusahaan(emp);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hubungi tim IT! " + ex.Message);
                }
            }
        }

        //Update Perusahanaan
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand com = new SqlCommand();
            com.Connection = connection;  // Assign the SqlConnection object
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "sp_UpdatePerusahaan";  // Set the stored procedure name

            com.Parameters.AddWithValue("@id_perusahaan", txtIDPerusahaan.Text);
            com.Parameters.AddWithValue("@nama_perusahaan", txtNamaPerusahaan.Text);
            com.Parameters.AddWithValue("@singkatan_perusahaan", txtSingkatan.Text);

            try
            {
                connection.Open();
                com.ExecuteNonQuery();
                MessageBox.Show("Perusahaan berhasil diubah!", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSave.Enabled = true;
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
                clear();
                loadPerusahaan(emp);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("duplicate key") || ex.Message.Contains("unique constraint"))
                {
                    MessageBox.Show("Singkatan sudah digunakan!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Hubungi tim IT! " + ex.Message);
                }
            }
        }

        private void txtSingkatan_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Memeriksa apakah karakter yang dimasukkan adalah huruf (A-Z atau a-z)
            if (!char.IsLetter(e.KeyChar))
            {
                // Cek apakah karakter yang ditekan adalah huruf atau backspace
                if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
                {
                    // Jika bukan huruf atau backspace, maka batalkan input karakter tersebut
                    e.Handled = true;
                    MessageBox.Show("Hanya huruf kapital yang diizinkan.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Mengubah huruf menjadi huruf kapital (uppercase)
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        // Save Perusahaan
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand com = new SqlCommand())
                {
                    com.Connection = connection;
                    com.CommandType = CommandType.StoredProcedure;
                    com.CommandText = "sp_CreatePerusahaan";

                    com.Parameters.AddWithValue("@nama_perusahaan", txtNamaPerusahaan.Text);
                    com.Parameters.AddWithValue("@singkatan_perusahaan", txtSingkatan.Text);

                    try
                    {
                        connection.Open();
                        com.ExecuteNonQuery();
                        MessageBox.Show("Perusahaan berhasil ditambah!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnSave.Enabled = true;
                        btnDelete.Enabled = false;
                        btnUpdate.Enabled = false;
                        clear();
                        loadPerusahaan(emp);
                    }
                    catch (Exception ex)
                    {
                        if (ex.Message.Contains("duplicate key") || ex.Message.Contains("unique constraint"))
                        {
                            MessageBox.Show("Singkatan sudah digunakan!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show("Hubungi tim IT! " + ex.Message);
                        }
                    }
                }
            }
        }
    }
}
