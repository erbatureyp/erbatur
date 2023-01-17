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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenciekleme gösterbakalım = new Ogrenciekleme();
            gösterbakalım.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Yonetimekleme gösterbakalım = new Yonetimekleme();
            gösterbakalım.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dersekleme gösterbakalım = new Dersekleme();
            gösterbakalım.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ogrencidersekleme gösterbakalım = new Ogrencidersekleme();
            gösterbakalım.ShowDialog();
        }

        private void öğrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ogrenciekleme gösterbakalım = new Ogrenciekleme();
            gösterbakalım.ShowDialog();
        }

        private void öğrenciListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OgrenciListeleme gösterbakalım = new OgrenciListeleme();
            gösterbakalım.ShowDialog();
        }

        private void öğrenciGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ogrenciguncelleme gösterbakalım = new Ogrenciguncelleme();
            gösterbakalım.ShowDialog();
        }

        private void yönetimEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Yonetimekleme gösterbakalım = new Yonetimekleme();
            gösterbakalım.ShowDialog();
        }

        private void yönetimGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yonetimguncelle gösterbakalım = new yonetimguncelle();
            gösterbakalım.ShowDialog();
        }

        private void yönetimListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YonetimListeleme gösterbakalım = new YonetimListeleme();
            gösterbakalım.ShowDialog();
        }

        private void dersEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dersekleme gösterbakalım = new Dersekleme();
            gösterbakalım.ShowDialog();
        }

        private void dersGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dersguncelleme gösterbakalım = new Dersguncelleme();
            gösterbakalım.ShowDialog();
        }

        private void dersListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DersListeleme gösterbakalım = new DersListeleme();
            gösterbakalım.ShowDialog();
        }
    }
}
