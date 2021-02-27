using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.MusteriNo = "11111";
            musteri1.Adi = "engin";
            musteri1.Soyadi = "demiroğ";
            musteri1.TcNo = "555";
            musteri1.Id = 1;

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "55555555";
            musteri2.SirketAdi = "kodlamaio";
            musteri2.VergiNo = "84524555";


            Musteri musteri3 = new GercekMusteri();// iki clasında ref tutabiliyor.
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager musterimanager = new CustomerManager();
            musterimanager.Ekle(musteri1);
            musterimanager.Ekle(musteri2);
        }
    }
}
