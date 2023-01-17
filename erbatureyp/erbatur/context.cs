using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace erbatur
{
    internal class context : DbContext
    {
        public context() : base("SQLEBAGLAN")
        {
               
        }
        public DbSet<ogrenci> ogrenciverileri { get; set; }
        public DbSet<okulyonetim> okulyonetimverileri { get; set; }
        public DbSet<ders> dersverileri { get; set; }
        public DbSet<ogrenciders> ogrencidersverileri { get; set; }
        
    }
}
