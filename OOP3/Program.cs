using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program//İNTERFACE(ARAYÜZ)
    {
        static void Main(string[] args)
        {
           IKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
            // ıhtiyacKrediManager.Hesapla();


            IKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            IKrediManager konutKrediManager = new KonutKrediManager();
            // konutKrediManager.Hesapla();

            ILoggerService databaseLoggerServise = new DatebaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(ıhtiyacKrediManager);
            basvuruManager.BasvuruYap(tasitKrediManager, new List<ILoggerService> { new DatebaseLoggerService(),new FileLoggerService()});

            List<IKrediManager> krediler = new List<IKrediManager>() { ıhtiyacKrediManager,tasitKrediManager,konutKrediManager };
           // basvuruManager.KrediOnBilgilendirmesiYap(krediler);



        }
    }
}
