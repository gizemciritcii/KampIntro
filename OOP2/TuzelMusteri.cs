using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //miras inheritance
    // mirasasta  musterinin içinde olan tüm özellikler tuzelde de kabul edilir.
    class TuzelMusteri:Musteri
    {
      
        public string SirketAdi { get; set; }


        public string VergiNo { get; set; }// Eğer ki bir nesnede bir değeri  kullanmak zorunda  gibi görünmüyorsa o nesneye ait görnmüyorsa orada hata yapıyorsun demektir.

    
}
}
