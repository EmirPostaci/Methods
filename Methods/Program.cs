using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] meyveler = new string[] { };
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Urunfiyati = 12;
            urun1.Aciklama = "Amasya elmasi";
            urun1.Stokadedi = "Son 1 ürün";

            Urun urun2 = new Urun();
            urun2.Adi = "Mandalina";
            urun2.Urunfiyati = 20;
            urun2.Aciklama = "Fethiye Mandalinasi";
            urun2.Stokadedi = "Son 2 ürün";
            Urun[] urunler = new Urun[] {urun1,urun2 };
            foreach (var urunlerim in urunler)
            {
                Console.WriteLine(urunlerim.Adi);
                Console.WriteLine(urunlerim.Urunfiyati);
                Console.WriteLine(urunlerim.Aciklama);
                Console.WriteLine(urunlerim.Stokadedi);
                Console.WriteLine("\n");
            }
            Console.WriteLine("--Metotlar--");
            //Encapsulation
            SepetManager sepetmanagerimiz = new SepetManager();
            sepetmanagerimiz.Ekle(urun1);
            sepetmanagerimiz.Ekle(urun2);
           
        }
    }
}
