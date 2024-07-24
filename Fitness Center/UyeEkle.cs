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

namespace Fitness_Center
{
    public partial class UyeEkle : Form
    {
        public UyeEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ckoylu\Documents\fitness.mdf;Integrated Security=True;Connect Timeout=30");

        private void UyeEkle_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || comboBox1.Text == "" || textBox4.Text == "" || comboBox2.Text == "")
            {
                MessageBox.Show("Eksik Bilgi Girildi.");
            }
            else
                try
                {
                    baglanti.Open();
                    string query = "insert into UyeTbl values('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.SelectedItem + "','" + textBox3.Text + "','" + textBox4.Text + "','" + comboBox2.SelectedItem + "' )";
                    SqlCommand komut = new SqlCommand(query, baglanti);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Üye Eklendi.");
                    baglanti.Close();
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    comboBox1.Text = "";
                    comboBox2.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata alındı" + ex.Message);
                }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Giris loginSayfasi = new Giris();
            loginSayfasi.Show();
            this.Hide();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            AnaSayfa anaSayfayaGit = new AnaSayfa();
            anaSayfayaGit.Show();
            this.Hide();
        }
    }
}
