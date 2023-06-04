using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalilPazarlama2
{
    internal class Urun
    {
        public string isim;
        public string birim;
        public int stok;
        public double fiyat;

        //Default Constructor
        public Urun(){}
        //Overload Constructor
        public Urun(string isim, string birim, int stok, double fiyat)
        {
            this.isim = isim;
            this.birim = birim;
            this.stok = stok;
            this.fiyat = fiyat;
        }
    }
}
