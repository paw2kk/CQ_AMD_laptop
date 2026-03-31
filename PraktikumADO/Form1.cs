using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;        

namespace PraktikumADO
{
    public partial class Form1 : Form
    {

        SqlConnection conn;
        SqlConnection cmd;

        public Form1()
        {
            InitializeComponent();
        }
        private void Koneksi()
        {
            conn = new SqlConnection(
                "Data Source=LAPTOP-1QL3V291\\PAW;Initial Catalog=PraktikumADO;Integrated Security=True\"
                );
        }

        private void btnHitungMK_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi();
                conn.Open();

                string query = "SELECT COUNT(*) FROM MataKuliah";

                cmd = new SqlCommand(query, conn);

                int jumlah = (int)cmd.ExecuteScalar();

                txtHasil.Text = jumlah.ToString();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi();
                conn.Open();

                MessageBox.Show("Koneksi ke database berhasil");

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHitungMhs_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi();
                conn.Open();

                string query = "SELECT COUNT(*) FROM Mahasiswa";

                cmd = new SqlCommand(query, conn);

                int jumlah = (int)cmd.ExecuteScalar();

                txtHasil.Text = jumlah.ToString();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi();
                conn.Open();

                string query = "UPDATE Mahasiswa SET Alamat ='Yogyakarta' WHERE NIM = '2311010001'";

                cmd = new SqlCommand(query, conn);

                int hasil = cmd.ExecuteNonQuery();

                MessageBox.Show("Jumlah baris terpengaruh : " + hasil);

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHitungDosen_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi();
                conn.Open();    
                
                string query = "SELECT COUNT(*) FROM Dosen";

                cmd = new SqlCommand(query, conn);

                int jumlah = (int)cmd.ExecuteScalar();

                txtHasilDosen.Text = jumlah.ToString();

                conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateSKS_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi();
                conn.Open();

                string query = "UPDATE MataKuliah SET SKS = 4 WHERE KodeMK = 'IF210101'";

                cmd = new SqlCommand(query, conn);
                
                int hasil = cmd.ExecuteNonQuery();

                MessageBox.Show("Jumlah baris terpengaruh : " + hasil);

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
