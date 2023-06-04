using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalilPazarlama2
{
    internal class Depo
    {
        Urun[] urunler;

        public Depo()
        {
            urunler = new Urun[5];
        }

        public void Ekle(Urun u)
        {
            for (int i = 0; i < urunler.Length; i++)
            {
                if (urunler[i] == null)
                {
                    urunler[i] = u;
                    break;
                }
            }
        }
        public void Listele()
        {
            for (int i = 0; i < urunler.Length; i++)
            {
                if (urunler[i] != null)
                {
                    Console.WriteLine($"{i+1}) {urunler[i].isim} {urunler[i].fiyat} TL - Adet {urunler[i].stok}");
                }
            }
        }

        public double SatisYap(int urunno, int Adet)
        {
            Urun secilen = urunler[urunno - 1];

            if (secilen.stok >= Adet)
            {
                double toplam = secilen.fiyat * Adet;
                urunler[urunno - 1].stok -= Adet;
                return toplam;
            }
            else
            {
                Console.WriteLine("Stok Yetersiz");
                return 0;
            }
        }
    }
}
