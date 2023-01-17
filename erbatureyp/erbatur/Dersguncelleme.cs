using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace erbatur
{
    public partial class Dersguncelleme : Form
    {
        public Dersguncelleme()
        {
            InitializeComponent();
        }
        context dbislem = new context();
        ders veriler = new ders();

        private void button1_Click(object sender, EventArgs e)
        {
            int idal = Convert.ToInt32(textBox1.Text);
            var idsorgula = dbislem.dersverileri.Find(idal);
            textBox2.Text = idsorgula.ad;
            textBox3.Text = idsorgula.kredisi.ToString();
            textBox4.Text = idsorgula.okulyonetimid.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idal = Convert.ToInt32(textBox1.Text);
            var idsorgula = dbislem.dersverileri.Find(idal);
            idsorgula.ad = textBox2.Text;
            idsorgula.kredisi = Convert.ToInt32(textBox3.Text);
            idsorgula.okulyonetimid = Convert.ToInt32(textBox4.Text);
            dbislem.SaveChanges();
            var za = from i in dbislem.dersverileri
                     select i;
            dataGridView1.DataSource = za.ToList();
        }
    }
}
