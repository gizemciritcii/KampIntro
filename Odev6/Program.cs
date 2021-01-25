using System;

namespace Odev6
{
    class Program
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            Urun urun2 = new Urun();
            Urun urun3 = new Urun();
            Urun urun4 = new Urun();
            Urun urun5 = new Urun();


            urun1.UrünTürü = "kitaplar";
            urun1.ÜrünAdı = "suç ve ceza";
            urun1.ÜrünId = 1235;

            urun2.UrünTürü = "elektronik";
            urun2.ÜrünAdı = "tablep";
            urun2.ÜrünId = 5468;

            urun3.UrünTürü = "kitaplar";
            urun3.ÜrünAdı = "tutunamayanlar";
            urun3.ÜrünId = 1245;

            urun4.UrünTürü = "ev ve yaşam";
            urun4.ÜrünAdı = "süpürge";
            urun4.ÜrünId = 8963;

            urun5.UrünTürü = "giyim";
            urun5.ÜrünAdı = "kadın montları";
            urun5.ÜrünId = 5555;


            Urun[] urunler = new Urun[];



            foreach (var item in collection)
            {

            }


            // Console.WriteLine("Hello World!");



        }

        class Urun
        {

            public string UrünTürü { get; set; }
            public string  ÜrünAdı { get; set; }
            public int ÜrünId{ get; set; }
        }
    }
}
