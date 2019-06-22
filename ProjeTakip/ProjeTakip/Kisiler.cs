using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjeTakip
{
    class Kisi
    {
        string ad;
        int id;
        string sifre;


        public Kisi(string ad, int id, string sifre)
        {
            this.ad = ad;
            this.id = id;
            this.sifre = sifre;
        }

        public string Ad { get => ad; set => ad = value; }
        public string Sifre { get => sifre; set => sifre = value; }
        public int Id { get => id; set => id = value; }
    }
}
