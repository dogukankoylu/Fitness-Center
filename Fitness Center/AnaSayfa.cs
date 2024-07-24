using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitness_Center
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UyeEkle uyeEkleEkrani = new UyeEkle();
            uyeEkleEkrani.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GuncelleSil guncelleSil = new GuncelleSil();
            guncelleSil.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Odemeler odemeler = new Odemeler();
            odemeler.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UyeleriGoruntule uyeler = new UyeleriGoruntule();
            this.Hide();
            uyeler.Show();
        }
    }
}
