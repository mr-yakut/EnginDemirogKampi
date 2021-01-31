using System;
 
namespace Metodlar

{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Id = 1;
            urun1.Adi = "Nike";
            urun1.Fiyati = "150 TL";
            urun1.Aciklamasi = "Dünyanın en hızlı ayakkabısı!";

            Urun urun2 = new Urun();
            urun2.Id = 2;
            urun2.Adi = "Puma";
            urun2.Fiyati = "85 TL";
            urun2.Aciklamasi = "Dünyanın en rahat ayakkabısı!";

            Urun urun3 = new Urun();
            urun3.Id = 3;
            urun3.Adi = "Adidas";
            urun3.Fiyati = "490 TL";
            urun3.Aciklamasi = "Dünyanın en pahalı ayakkabısı!";

            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine("Ürün kodu:" + " " + urun.Id);
                Console.WriteLine("Ürün adı:" + " " + urun.Adi);
                Console.WriteLine("Ürün fiyatı:" + " " + urun.Fiyati);
                Console.WriteLine("Ürün açıklaması:" + " " + urun.Aciklamasi);
                Console.WriteLine("\n");

            }
            Console.WriteLine("--------Metodlar-------");
            // instance - örnek
            //encapsulation
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle(urun3);
            
            sepetManager.Ekle2("Armut", "15", "Yeşil Armut" , 9);
            sepetManager.Ekle2("Elma", "32", "Sarı Elma", 15);
            sepetManager.Ekle2("Muz", "89", "Taze Muz", 22);

        }
    }
}
