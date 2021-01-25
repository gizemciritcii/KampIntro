using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
   public  class SepetManager
    {
        // naming convertion
        // isimlendirme  kuralı .

        public void Ekle(Urun urun)//metot // parametre almış oldu metotumuz urun nesnesini ekleyinceü 
        {
            Console.WriteLine("sepete eklendi: " + urun.Adi);
        }


        public void Ekle2(string urunAdi,string aciklama, double fiyat, int stok)
        {
            Console.WriteLine("tebrikler sepete eklendi"+urunAdi);
        }
    }
}
