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
    public partial class Ogrencidersekleme : Form
    {
        public Ogrencidersekleme()
        {
            InitializeComponent();
        }
        context dbislem = new context();
        ogrenciders veriler = new ogrenciders();
        private void ogrencidersekle_Load(object sender, EventArgs e)
        {
            var za = from i in dbislem.dersverileri
                     select i.id;
                     
            comboBox1.DataSource = za.ToList();
            var zaa = from i in dbislem.ogrenciverileri
                     select i.id;

            comboBox2.DataSource = za.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dbislem.ogrencidersverileri.Add(new ogrenciders
            {
                Ogrenciid = Convert.ToInt32(comboBox1.Text),
                Dersid = Convert.ToInt32(comboBox2.Text),

            });
            dbislem.SaveChanges();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
