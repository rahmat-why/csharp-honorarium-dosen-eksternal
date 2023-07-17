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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            txtUser.Focus();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUser.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("Username atau password tidak boleh kosong!");
                }
                else
                {
                    DataTable result = VerifyUser(txtUser.Text, txtPassword.Text);

                    if (result.Rows.Count > 0) // jika sukses
                    {
                        string idUser = result.Rows[0]["id_user"].ToString();
                        string namaUser = result.Rows[0]["nama"].ToString();
                        string role = result.Rows[0]["role"].ToString();

                        txtUser.Text = namaUser;

                        if (role == "ADMIN")
                        {
                            // Mengatur keadaan halaman sesuai dengan peran (role)
                            Adminpage adminPage = new Adminpage();
                            adminPage.Show();
                            MessageBox.Show("Selamat datang, Admin!");
                        }
                        else if (role == "DAAA")
                        {
                            // Mengatur keadaan halaman sesuai dengan peran (role)
                            DAAAPage daaaPage = new DAAAPage();
                            daaaPage.Show();
                            MessageBox.Show("Selamat datang, DAAA!");
                        }
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Username / Password Salah :C", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesealahan: " + ex.Message);
            }
        }




        private void btnShow_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar)
            {
                txtPassword.UseSystemPasswordChar = false;
                btnShow.Image = Properties.Resources.show;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                btnShow.Image = Properties.Resources.hide;
            }
        }
        public DataTable VerifyUser(string username, string password) // cek username password
        {
            string connectionString = ConfigurationManager.AppSettings["Connectionstring"];
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("SELECT * FROM dbo.VerifyUser(@username, @password)", connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        return dataTable;
                    }
                }
            }
        }

        private void txtUser_Click(object sender, EventArgs e)
        {
            txtPassword.PlaceholderForeColor = Color.White;
        }
    }
}
