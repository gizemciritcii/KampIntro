using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {


            //string urunAdi = "elma";
            //double fiyati = 15;
            //string aciklama = "amasya elması";
           

            Urun urun1 = new Urun();
            urun1.Aciklama = "Diyarbakır karpuz";
            urun1.Adi = "karpuz";
            urun1.Fİyati = 90;

            Urun urun2 = new Urun();
            urun2.Aciklama = "Malatya kayısısı";
            urun2.Adi = "kayısı";
            urun2.Fİyati = 40;


            Urun[] urunler = new Urun[] { urun1, urun2 };
            // typesafe --tip güvenliği.
            foreach (Urun urun  in urunler)
            {
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fİyati);
                Console.WriteLine("...............................................");
                Console.WriteLine();
            }


            Console.WriteLine("...............metotlar.........................");

            SepetManager sepetManager = new SepetManager();

            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle2("armut","kış armutu",15,50);
      

            //  Console.WriteLine(urunler);
            // Console.WriteLine("Hello World!");
        }
    }
}
//Dont repeat yourself. kendini tekrar etme.
//Clean Code  best practice.