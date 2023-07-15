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
    public partial class Absensi : Form
    {
        string connectionString = "integrated security=false; Data Source=10.8.9.99;User ID=sa;Password=polman; initial catalog=HonorariumDosenEksternal";
        string id_absensi, id_dosen, id_matkul, id_prodi, kelas, tanggal_mengajar, sks;

        public Absensi()
        {
            InitializeComponent();
        }

        private void txtNamaJenis_TextChanged(object sender, EventArgs e)
        {

        }

        public void ShowDefaultAbsensi()
        {
            DateTime currentDate = DateTime.Now;
            DateTime start = currentDate.AddMonths(-2).AddDays(16 - currentDate.Day);
            txtTanggalAwal.Value = start;

            DateTime end = start.AddMonths(1).AddDays(15 - start.Day);
            txtTanggalAkhir.Value = end;
        }

        // Save Absensi
        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand com = new SqlCommand();
            com.Connection = connection;
            com.CommandText = "sp_CreateAbsensi";
            com.CommandType = CommandType.StoredProcedure;

            com.Parameters.AddWithValue("@id_dosen", (string)cmbIDDosen.SelectedValue);
            com.Parameters.AddWithValue("@id_matkul", (string)cmbIDMatkul.SelectedValue);
            com.Parameters.AddWithValue("@id_prodi", (string)cmbIDProdi.SelectedValue);
            com.Parameters.AddWithValue("@kelas", txtKelas.Text);
            com.Parameters.AddWithValue("@tanggal_mengajar", txtTanggalMengajar.Value);
            com.Parameters.AddWithValue("@sks", txtSKS.Text);

            com.Parameters.AddWithValue("@id_user", "USR005");
            

            try
            {
                connection.Open();
                com.ExecuteNonQuery();
                MessageBox.Show("Simpan data berhasil ", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
                loadAbsensi(txtTanggalAwal.Value.ToString("yyyy-MM-dd"), txtTanggalAkhir.Value.ToString("yyyy-MM-dd"), cmbJenis.SelectedValue.ToString(), "");
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
            btnDelete.Enabled = false;
        }


        // Delete absensi
 
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
                    com.CommandText = "sp_DeleteAbsensi";
                    com.CommandType = CommandType.StoredProcedure;

                    com.Parameters.AddWithValue("@id_absensi", txtIDAbsensi.Text);

                    connection.Open();
                    int result = Convert.ToInt32(com.ExecuteNonQuery());
                    connection.Close();

                    if (result != 0)
                    {
                        MessageBox.Show("Data Berhasil Dihapus!");
                        clear();
                        loadAbsensi(txtTanggalAwal.Value.ToString("yyyy-MM-dd"), txtTanggalAkhir.Value.ToString("yyyy-MM-dd"), cmbJenis.SelectedValue.ToString(), "");

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hubungi tim IT! " + ex.Message);
                }
            }
        }

        //tbl Absensi
        private void tblAbsensi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < tblAbsensi.Rows.Count)
            {
                DataGridViewRow selectedRow = tblAbsensi.Rows[e.RowIndex];
                id_absensi = selectedRow.Cells["col_Absensi"].Value.ToString();
                id_dosen = selectedRow.Cells["col_nama_dosen"].Value.ToString();
                id_matkul = selectedRow.Cells["nama_matkul"].Value.ToString();
                id_prodi = selectedRow.Cells["col_Nama_Prodi"].Value.ToString();
                kelas = selectedRow.Cells["col_Kelas"].Value.ToString();
                tanggal_mengajar = selectedRow.Cells["col_tanggal_mengajar"].Value.ToString();
                sks = selectedRow.Cells["col_sks"].Value.ToString();

                txtIDAbsensi.Text = id_absensi;
                cmbIDDosen.Text = id_dosen;
                cmbIDMatkul.Text = id_matkul;
                cmbIDProdi.Text = id_prodi;
                txtKelas.Text = kelas;
                txtTanggalMengajar.Value = DateTime.Parse(tanggal_mengajar);
                txtSKS.Text = sks;
                btnDelete.Enabled = true;
                btnSave.Enabled = false;
            }
        }

        private void txtTanggalAwal_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void clear()
        {
            txtIDAbsensi.Text = "Otomatis";
            txtKelas.Text = "";
            txtSKS.Text = "";
            cmbIDDosen.Text = "";
            cmbIDMatkul.Text = "";
            cmbIDProdi.Text = "";
        
        }

        string emp = "";

        private void loadAbsensi(string tanggal_awal, string tanggal_akhir, string IDjenis, string param)
        {
            this.getListAbsensiTableAdapter.FillBy1(this.honorariumDosenEksternalDataSet.getListAbsensi, tanggal_awal, tanggal_akhir, IDjenis, param);
        }


        private void Absensi_Load(object sender, EventArgs e)
        {
            ShowDefaultAbsensi();
            this.getListJenisDosenTableAdapter.FillBy3(this.honorariumDosenEksternalDataSet.getListJenisDosen, emp);
            this.getListDosenTableAdapter.FillBy2(this.honorariumDosenEksternalDataSet.getListDosen, emp);
            this.getListMatkulTableAdapter.FillBy1(this.honorariumDosenEksternalDataSet.getListMatkul, emp);
            this.getListProdiTableAdapter.FillBy3(this.honorariumDosenEksternalDataSet.getListProdi,emp);
            btnDelete.Enabled = false;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string tanggal_awal = txtTanggalAwal.Value.ToString("yyyy-MM-dd");
            string tanggal_akhir = txtTanggalAkhir.Value.ToString("yyyy-MM-dd");
            string IDjenis = cmbJenis.SelectedValue.ToString(); // Sesuaikan dengan nilai dari kontrol IDjenis yang ada di form
            string param = ""; // Sesuaikan dengan nilai dari kontrol param yang ada di form
            //MessageBox.Show(tanggal_awal + "-" + tanggal_akhir + "-" + cmbJenis.SelectedValue.ToString());
            loadAbsensi(tanggal_awal, tanggal_akhir, IDjenis, param);
        }

        private void txtSearch_KeyUp_1(object sender, KeyEventArgs e)
        {
            string tanggal_awal = txtTanggalAwal.Value.ToString("yyyy-MM-dd");
            string tanggal_akhir = txtTanggalAkhir.Value.ToString("yyyy-MM-dd");
            string IDjenis = cmbJenis.SelectedValue.ToString(); // Sesuaikan dengan nilai dari kontrol IDjenis yang ada di form
            string param = txtSearch.Text; // Menggunakan nilai dari txtSearch sebagai parameter pencarian
            loadAbsensi(tanggal_awal, tanggal_akhir, IDjenis, param);
        }
    }
}
