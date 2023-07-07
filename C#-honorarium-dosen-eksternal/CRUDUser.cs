using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        
        public CRUDUser()
        {
            InitializeComponent();
        }
        public string GenerateId()
        {
            string newId = string.Empty;

            try
            {
                string connectionString = "integrated security=true; data source=.; initial catalog= HonorariumDosenEksternal";
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

        private void CRUDUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'honorariumDosenEksternalDataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.honorariumDosenEksternalDataSet.users);
            try
            {
                this.getListUsersTableAdapter.Filter(this.honorariumDosenEksternalDataSet.getListUsers, namaToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            GenerateId();
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

        private void filterToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.getListUsersTableAdapter.Filter(this.honorariumDosenEksternalDataSet.getListUsers, namaToolStripTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        //Fungsi Clear
        private void clear()
        {
            txtIDUser.Text = "";
            txtNamaUser.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            cmbRole.Text = "";
           
        }

        //Create User
        private void btnSave_Click(object sender, EventArgs e)
        {
            string connectionstring = "integrated security =false; data source = 10.8.9.99; initial catalog = HonorariumDosenEksternal; user=sa; password=polman";
            SqlConnection connection = new SqlConnection(connectionstring);

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
                MessageBox.Show("Data saved successfully", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to saved : " + ex.Message);
            }

            this.getListUsersTableAdapter.Filter(this.honorariumDosenEksternalDataSet.getListUsers, namaToolStripTextBox.Text);
        }

        //Delete User
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string connectionstring = "integrated security =false; data source = 10.8.9.99; initial catalog = HonorariumDosenEksternal; user=sa; password=polman";
            SqlConnection connection = new SqlConnection(connectionstring);

            SqlCommand delete = new SqlCommand("sp_DeleteUser", connection);
            delete.CommandType = CommandType.StoredProcedure;

            delete.Parameters.AddWithValue("id_user" , txtIDUser.Text);
            try
            {
                connection.Open();
                delete.ExecuteNonQuery();
                MessageBox.Show("Data Update successfully", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to update: " + ex.Message);
            }
        }

        //Update User
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            string connectionstring = "integrated security =false; data source = 10.8.9.99; initial catalog = HonorariumDosenEksternal; user=sa; password=polman";
            SqlConnection connection = new SqlConnection(connectionstring);

            SqlCommand update= new SqlCommand("sp_UpdateUser", connection);
            update.CommandType = CommandType.StoredProcedure;


            update.Parameters.AddWithValue("nama", txtNamaUser.Text);
            update.Parameters.AddWithValue("username", txtUsername.Text);
            update.Parameters.AddWithValue("password", txtPassword.Text);
            update.Parameters.AddWithValue("Role", cmbRole.Text);

            try
            {
                connection.Open();
                update.ExecuteNonQuery();
                MessageBox.Show("Update Data successfully", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
                btnSave.Enabled = false;
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to saved: " + ex.Message);
            }

        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;

        }
    }
}
