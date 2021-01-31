using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class SepetManager
            // naming convetion
            // syntax
    
    
    { 
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete Eklendi:" + " " + urun.Adi);

        }
        public void Ekle2(string Adi, string Fiyati, String Aciklama, int StokAdedi)
        {
            Console.WriteLine("Tebriks.Sepete ürün eklendi : " +Adi, Fiyati, Aciklama, StokAdedi  );


        }
    }




    
}
