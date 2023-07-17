using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C__honorarium_dosen_eksternal
{
    public partial class CRUDUser : Form
    {
        string connectionString = ConfigurationManager.AppSettings["Connectionstring"];

        public CRUDUser()
        {
            InitializeComponent();
        }
        public string GenerateId()
        {
            string newId = string.Empty;

            try
            {
               
                SqlConnection connection = new SqlConnection(connectionString);
                string query = "SELECT dbo.GenerateUserID() AS newId";
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    newId = reader["newId"].ToString();
                }

                reader.Close();
                connection.Close();
            }
            catch (SqlException e)
            {
                // Handle any errors that occur during the execution
                MessageBox.Show(e.ToString());
            }

            return newId;
        }

        string emp = "";

        private void CRUDUser_Load(object sender, EventArgs e)
        {
           
            try
            {
                loadUser(emp);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
       
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            

        }
        //Validasi Nama
        private void txtNamaUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Mengabaikan karakter yang tidak valid dengan mengeset Handled ke true
                e.Handled = true;

                // Menampilkan pesan kesalahan
                MessageBox.Show("Hanya huruf dan spasi yang diizinkan.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Validasi Userame
        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Memeriksa apakah karakter yang ditekan adalah spasi
            if (char.IsWhiteSpace(e.KeyChar))
            {
                // Mengabaikan karakter yang tidak valid dengan mengeset Handled ke true
                e.Handled = true;

                // Menampilkan pesan kesalahan
                MessageBox.Show("Spasi tidak diizinkan.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Validasi Password
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                // Mengabaikan karakter yang tidak valid dengan mengeset Handled ke true
                e.Handled = true;

                // Menampilkan pesan kesalahan
                MessageBox.Show("Spasi tidak diizinkan.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Memeriksa apakah CAPS LOCK diaktifkan
            if (Control.ModifierKeys == Keys.CapsLock)
            {
                // Menampilkan pesan peringatan
                MessageBox.Show("CAPS LOCK aktif. Pastikan penggunaan huruf kapital sesuai.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

   

        //Fungsi Clear
        private void clear()
        {
            txtIDUser.Text = "Otomatis";
            txtNamaUser.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            cmbRole.Text = "";
           
        }

        private void loadUser(string param)
        {
            this.getListUsersTableAdapter.Filter(this.honorariumDosenEksternalDataSet.getListUsers, param);
        }

        private void tblUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = tblUser.Rows[e.RowIndex];
                string id_user = selectedRow.Cells["col_id_user"].Value.ToString();
                string nama_user = selectedRow.Cells["col_nama_user"].Value.ToString();
                string username = selectedRow.Cells["col_username"].Value.ToString();
                string role = selectedRow.Cells["col_role"].Value.ToString();

                txtIDUser.Text = id_user;
                txtNamaUser.Text = nama_user;
                txtUsername.Text = username;
                cmbRole.Text = role;

                btnSave.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            loadUser(txtSearch.Text);
        }


        //Create User
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand insert = new SqlCommand("sp_CreateUser", connection);
            insert.CommandType = CommandType.StoredProcedure;

            insert.Parameters.AddWithValue("nama", txtNamaUser.Text);
            insert.Parameters.AddWithValue("username", txtUsername.Text);
            insert.Parameters.AddWithValue("password", txtPassword.Text);
            insert.Parameters.AddWithValue("Role", cmbRole.Text);
            try
            {
                connection.Open();
                insert.ExecuteNonQuery();
                MessageBox.Show("Data berhasil diSave", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSave.Enabled = true;
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
                clear();
                loadUser(emp);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to saved : " + ex.Message);
            }

            this.getListUsersTableAdapter.Filter(this.honorariumDosenEksternalDataSet.getListUsers, emp);
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            clear();
            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        //Update User
        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            SqlCommand update = new SqlCommand("sp_UpdateUser", connection);
            update.CommandType = CommandType.StoredProcedure;

            update.Parameters.AddWithValue("id_user", txtIDUser.Text);
            update.Parameters.AddWithValue("nama", txtNamaUser.Text);
            update.Parameters.AddWithValue("username", txtUsername.Text);
            update.Parameters.AddWithValue("password", txtPassword.Text);
            update.Parameters.AddWithValue("Role", cmbRole.Text);

            try
            {
                connection.Open();
                update.ExecuteNonQuery();
                MessageBox.Show("Data berhasil diDelete", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnSave.Enabled = true;
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
                clear();
                loadUser(emp);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to saved: " + ex.Message);
            }
        }

        //Delete User
        private void btnDelete_Click_1(object sender, EventArgs e)
        {

        }
    }
}
