using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace erbatur
{
    internal class ogrenci
    {
        public int id { get; set; }
        public string AdSoyad { get; set; }
        public string KayitTarih { get; set; }
        public int OgrenciNo { get; set; }
        public string DTarih { get; set; }
        public string Bolum { get; set; }
    }
}
