using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            bool sistemeGirisYapmisMİ = false;
            double dolarDun = 7.65;
            double dolarBugun = 7.65;


            if (dolarBugun<dolarDun)
            {
                Console.WriteLine("dolar düştü işareti");

            }
           else  if(dolarBugun>dolarDun)
            {
                Console.WriteLine("dolar yükseldi işareti");
            }
            else
            {
                Console.WriteLine("kur değişmedi");    
            }
            }
        }
    }

