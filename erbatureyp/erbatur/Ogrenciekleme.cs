using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace erbatur
{
    public partial class Ogrenciekleme : Form
    {
        public Ogrenciekleme()
        {
            InitializeComponent();
        }
        context dbislem = new context();
        ogrenci veriler = new ogrenci();

        private void button1_Click(object sender, EventArgs e)
        {
            dbislem.ogrenciverileri.Add(new ogrenci
            {
                AdSoyad = textBox1.Text,
                KayitTarih = textBox2.Text,
                OgrenciNo = Convert.ToInt32(textBox3.Text),
                DTarih = textBox4.Text,
                Bolum = textBox5.Text,
            });
            dbislem.SaveChanges();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                var za = from i in dbislem.ogrenciverileri
                         select i;
                dataGridView1.DataSource = za.ToList();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ogrenciguncelleme guncelleform = new Ogrenciguncelleme();
            guncelleform.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string aranacak = textBox6.Text;
            var arabakalım = (from i in dbislem.ogrenciverileri
                              where i.OgrenciNo.ToString().Contains(aranacak)
                              select i).ToList();
            dataGridView1.DataSource = arabakalım;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Ogrenciekleme_Load(object sender, EventArgs e)
        {

        }
    }
}
