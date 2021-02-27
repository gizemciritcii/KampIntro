using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager//mulakat sorusu olabilir.
    {
        //method injection 
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerService)//tüm referansları tutuğu içinde interface ile tüm kredilere ulaşabiliriz.
        {

            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            // konutKrediManager.Hesapla();//  bu yanlış bir uygulama tüm başvurular buradaki konut kredisi ile hesaplanır.


            krediManager.Hesapla();//hangi  krediyi gönderirsem onun hesaplaması çalışır ve onun referansı çalışır.
            foreach (var logger in loggerService)
            {
                logger.Log();

            }

        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {

            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
            
            //Console.WriteLine();


        }
    }
}
