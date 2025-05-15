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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Veritabani_15May_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string SqlConnectionString="";

        private void btnBaglan_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=172.20.112.108;Database=bgt;User Id=bgt;Password=bgt;";

            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();
                    label4.Text = "Bağlantı başarılı.";
                    label4.ForeColor = Color.Green;
                    SqlConnectionString = connectionString;
                }
                catch (Exception ex)
                {
                    label4.Text = "Bağlantı başarısız: " + ex.Message;
                    label4.ForeColor = Color.Red;
                }
            }
        }
        //Server=172.20.112.108;Database=bgt;User Id=bgt;Password=bgt;
        private void btnTumOgrenciler_Click(object sender, EventArgs e)
        {
            using (SqlConnection baglanti = new SqlConnection(SqlConnectionString))
            {
                string sorgu = "SELECT * FROM Ogrenci";


                SqlDataAdapter adapter = new SqlDataAdapter(sorgu, baglanti);
                    DataTable tablo = new DataTable();
                    adapter.Fill(tablo);

                    dataGridView1.DataSource = tablo;
             
            }
        }

        private void btnAdAra_Click(object sender, EventArgs e)
        {
            using (SqlConnection baglanti = new SqlConnection(SqlConnectionString))
            {
                string sorgu = "SELECT * FROM Ogrenci WHERE Ad = @ad ";

                SqlDataAdapter adapter = new SqlDataAdapter(sorgu, baglanti);
                adapter.SelectCommand.Parameters.AddWithValue("@ad",   textBoxAdAra.Text );
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }

        }

        private void btnSirala_Click(object sender, EventArgs e)
        {
            using (SqlConnection baglanti = new SqlConnection(SqlConnectionString))
            {
                string sorgu = "SELECT TOP 1 * FROM Ogrenci ORDER BY DogumTarihi DESC";
                SqlDataAdapter adapter = new SqlDataAdapter(sorgu, baglanti);
                
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void btnBolumAra_Click(object sender, EventArgs e)
        {
            using (SqlConnection baglanti = new SqlConnection(SqlConnectionString))
            {
                string sorgu = "SELECT * FROM Ogrenci WHERE Bolum LIKE @bolum";
                SqlDataAdapter adapter = new SqlDataAdapter(sorgu, baglanti);
                adapter.SelectCommand.Parameters.AddWithValue("@bolum", textBoxBolumAra.Text);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {
            
            using (SqlConnection baglanti= new SqlConnection(SqlConnectionString))
            {
                string sorgu = "INSERT INTO Ogrenci (Ad,Soyad,DogumTarihi,Bolum) VALUES (@Ad,@Soyad,@DogumTarihi,@Bolum)";

                SqlCommand command = new SqlCommand(sorgu, baglanti);

                DateTime dogumTarihi = dateTimePickerDogumTarihi.Value;
                
                command.Parameters.AddWithValue("@Ad", textBoxAd.Text);
                command.Parameters.AddWithValue("@Soyad", textBoxSoyad.Text);
                command.Parameters.AddWithValue("@DogumTarihi", dogumTarihi);
                command.Parameters.AddWithValue("@Bolum", textBoxBolum.Text);

                    baglanti.Open();
                    command.ExecuteNonQuery();
                textBoxAd.Text = "";
                textBoxSoyad.Text = "";
                textBoxBolum.Text = "";
                dateTimePickerDogumTarihi.Value = DateTime.Now;
            }

        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            using (SqlConnection baglanti = new SqlConnection(SqlConnectionString))
            {
                baglanti.Open();
                string sorgu = "DELETE FROM Ogrenci WHERE OgrenciID= @id";
                SqlCommand adapter = new SqlCommand(sorgu, baglanti);
                adapter.Parameters.AddWithValue("@id", textBoxOgrenciID.Text);
                adapter.ExecuteNonQuery();
                
                string sorgu2 = "SELECT * FROM Ogrenci";
                SqlDataAdapter adapter2 = new SqlDataAdapter(sorgu2, baglanti);
                DataTable tablo = new DataTable();
                adapter2.Fill(tablo);
                dataGridView1.DataSource = tablo;
            }
        }
    }
}
