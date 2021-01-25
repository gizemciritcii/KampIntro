using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string Adi = "engin";
            int Yas = 36;

            Kurs kurs1 = new Kurs();
            Kurs kurs2 = new Kurs();
            Kurs kurs3 = new Kurs();
            Kurs kurs4 = new Kurs();

            kurs1.Egitmen = "engin";
            kurs1.IzlenmeOranı = 100000;
            kurs1.KkursAdi = "c#";

            kurs2.Egitmen = "engin";
            kurs2.IzlenmeOranı = 100000;
            kurs2.KkursAdi = "c#";


            kurs3.Egitmen = "engin";
            kurs3.IzlenmeOranı = 100000;
            kurs3.KkursAdi = "c#";

            kurs4.Egitmen = "engin";
            kurs4.IzlenmeOranı = 100000;
            kurs4.KkursAdi = "c#";


            Kurs[] kurslar = new Kurs[] { kurs1,kurs2,kurs3,kurs4};

            foreach (var kurs in kurslar )
            {
                Console.WriteLine(kurs.KkursAdi+ ":"+ kurs.IzlenmeOranı);
            }



           // Console.WriteLine(kurs1.KkursAdi+kurs1.Egitmen+kurs1.IzlenmeOranı);
        }
        class Kurs
        {
            public string KkursAdi { get; set; }
            public string Egitmen { get; set; }
            public int IzlenmeOranı { get; set; }
        }

    }
}
