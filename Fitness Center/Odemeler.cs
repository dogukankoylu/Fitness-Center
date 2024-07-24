using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Fitness_Center
{
    public partial class Odemeler : Form
    {
        public Odemeler()
        {
            InitializeComponent();
        }
        
        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ckoylu\Documents\fitness.mdf;Integrated Security=True;Connect Timeout=30");
        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Text = "";
            textBox4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AnaSayfa anasayfa = new AnaSayfa();
            this.Hide();
            anasayfa.Show();
        }
        private void uyeler()
        {
            baglanti.Open();
            string query = "select * from OdemeTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder sqlCom = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();

        }
        private void adSoyadiDoldur()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select UAdSoyad from UyeTbl", baglanti);
            SqlDataReader rdr = komut.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("UAdSoyad", typeof(string));
            dt.Load(rdr);
            comboBox1.ValueMember = "UAdSoyad";
            comboBox1.DataSource = dt;
            baglanti.Close();

        }

        private void Odemeler_Load(object sender, EventArgs e)
        {
            try
            {
                adSoyadiDoldur();
                uyeler();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Alındı" + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Eksik Bilgi Girildi");
            }
            else
            {
                string odemePeriyot = dateTimePicker1.Value.Month.ToString() + dateTimePicker1.Value.Year.ToString();
                baglanti.Open();
                string sqlQuery = "Select count(*) from OdemeTbl where OUye=@OUye and OAy=@OAy and OTutar=@OTutar";
                SqlDataAdapter sda = new SqlDataAdapter(sqlQuery, baglanti);
                sda.SelectCommand.Parameters.AddWithValue("@OUye", comboBox1.SelectedValue.ToString());
                sda.SelectCommand.Parameters.AddWithValue("@OAy", odemePeriyot);
                sda.SelectCommand.Parameters.AddWithValue("@OTutar", textBox4.Text);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                int kayitSayisi = Convert.ToInt32(dt.Rows[0][0]);

                if (kayitSayisi > 0)
                {
                    MessageBox.Show("Zaten Ödeme Yapıldı");
                }
                else
                {

                    string query = "insert into OdemeTbl (OAy, OUye, OTutar) values (@OAy, @OUye, @OTutar)";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.Parameters.AddWithValue("@OAy", odemePeriyot);
                    komut.Parameters.AddWithValue("@OUye", comboBox1.SelectedValue.ToString());
                    komut.Parameters.AddWithValue("@OTutar", textBox4.Text);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Ödeme Yapıldı");
                }
                baglanti.Close();
                uyeler();
            }

        }
    }
}
