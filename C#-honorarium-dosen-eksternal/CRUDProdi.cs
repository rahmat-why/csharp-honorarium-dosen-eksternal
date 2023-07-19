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
using System.Configuration;

namespace C__honorarium_dosen_eksternal
{
    public partial class CRUDProdi : Form
    {
        string connectionString = ConfigurationManager.AppSettings["Connectionstring"];
        string id_prodi, nama_prodi, singkatan, transport;
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

        string emp = "";
        private void CRUDProdi_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            try
            {
                loadProdi(emp);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        // clear
        private void clear()
        {
            txtIDProdi.Text = "Otomatis";
            txtNamaProdi.Text = "";
            txtSingkatan.Text = "";
            cmbTransport.Text = "";
        }




        //Search
        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            loadProdi(txtSearch.Text);
        }


        // delete
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
                    com.CommandText = "sp_DeleteProdi";
                    com.CommandType = CommandType.StoredProcedure;

                    com.Parameters.AddWithValue("@id_prodi", txtIDProdi.Text);

                    connection.Open();
                    int result = Convert.ToInt32(com.ExecuteNonQuery());
                    connection.Close();

                    MessageBox.Show("Program studi berhasil dihapus!");
                    btnSave.Enabled = true;
                    btnDelete.Enabled = false;
                    btnUpdate.Enabled = false;
                    clear();
                    loadProdi(emp);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hubungi tim IT! " + ex.Message);
                }
            }
        }

        //btn Update
        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (txtNamaProdi.Text == "" || txtSingkatan.Text == "" || cmbTransport.Text == "")
            {
                MessageBox.Show("Harap lengkapi semua data!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand com = new SqlCommand();
                com.Connection = connection;  // Assign the SqlConnection object
                com.CommandType = CommandType.StoredProcedure;
                com.CommandText = "sp_UpdateProdi";  // Set the stored procedure name

                com.Parameters.AddWithValue("@id_prodi", txtIDProdi.Text);
                com.Parameters.AddWithValue("@nama_prodi", txtNamaProdi.Text);
                com.Parameters.AddWithValue("@singkatan", txtSingkatan.Text);
                com.Parameters.AddWithValue("@transport", cmbTransport.SelectedItem.ToString());

                connection.Open();
                com.ExecuteNonQuery();
                MessageBox.Show("Program studi berhasil diubah!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSave.Enabled = true;
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
                clear();
                loadProdi(emp);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubungi tim IT! " + ex.Message);
            }

        }

        //btn Save
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            if(txtNamaProdi.Text == "" || txtSingkatan.Text == "" || cmbTransport.Text == "")
            {
                MessageBox.Show("Harap lengkapi semua data!", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand com = new SqlCommand();
                com.Connection = connection;  // Assign the SqlConnection object
                com.CommandType = CommandType.StoredProcedure;
                com.CommandText = "sp_CreateProdi";  // Set the stored procedure name

                com.Parameters.AddWithValue("@nama_prodi", txtNamaProdi.Text);
                com.Parameters.AddWithValue("@singkatan", txtSingkatan.Text);
                com.Parameters.AddWithValue("@transport", cmbTransport.Text);

                connection.Open();
                com.ExecuteNonQuery();
                MessageBox.Show("Program studi berhasil disimpan!", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSave.Enabled = true;
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
                clear();
                loadProdi(emp);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hubungi tim IT! " + ex.Message);
            }
        }


        // clear
        private void btnClear_Click_1(object sender, EventArgs e)
        {
            clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void tblProdi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = tblProdi.Rows[e.RowIndex];
                id_prodi = selectedRow.Cells["col_id_prodi"].Value.ToString();
                nama_prodi = selectedRow.Cells["col_nama_prodi"].Value.ToString();
                singkatan = selectedRow.Cells["col_singkatan"].Value.ToString();
                transport = selectedRow.Cells["col_transport"].Value.ToString();

                txtIDProdi.Text = id_prodi;
                txtNamaProdi.Text = nama_prodi;
                txtSingkatan.Text = singkatan;
                cmbTransport.Text = transport;


                btnSave.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }
        //Load Data
        private void loadProdi(string param)
        {
            this.getListProdiTableAdapter.FillBy(this.honorariumDosenEksternalDataSet.getListProdi, param);
        }
    }
}
