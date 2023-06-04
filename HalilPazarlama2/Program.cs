using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HalilPazarlama2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Depo depo = new Depo();
            double genelToplam = 0;
            #region Urun Tanımlamaları

            Urun u = new Urun();
            u.isim = "Domates";
            u.stok = 50;
            u.birim = "KG";
            u.fiyat = 22;

            depo.Ekle(u);

            Urun u1 = new Urun("Elma", "KG", 50, 15);
            depo.Ekle(u1);

            depo.Ekle(new Urun("Karton", "Adet", 100, 5));

            #endregion


            #region Menü Yazdırma

            //depo.Listele();

            #endregion

            #region Satış
            

            string secenek = "e";

            while (secenek == "e")
            {
                depo.Listele();

                Console.WriteLine("Satın alamak istediğiniz ürünün numarasını giriniz");
                int no = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Kaç Adet Alacaksınız");
                int adet = Convert.ToInt32(Console.ReadLine());

                genelToplam += depo.SatisYap(no, adet);

                Console.WriteLine("Alışverişe devam edilsin mi?");
                Console.WriteLine("Devam İçin 'e' tuşuna basın");
                Console.WriteLine("Çıkmak için herhangi bir tuşa basınız");
                secenek = Console.ReadLine();
                Console.Clear();
            }
            Console.WriteLine("Toplam = " + genelToplam);
            #endregion
        }
    }
}
