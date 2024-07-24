namespace Fitness_Center
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void Giris_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Eksik Bilgi Girildi.");
            }
            else if(textBox1.Text == "admin" &&  textBox2.Text == "1234")
            {
                AnaSayfa anasayfa = new AnaSayfa();
                anasayfa.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanýcý adý veya þifre hatalý");
            }
        }
    }
}
