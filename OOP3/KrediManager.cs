using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface  IKrediManager //inrerfaceler de implement edilen sınıfın referansını tutabilir
    {

        public void Hesapla();
        //imza aynı içerisi farklı durumlarda class değil  interface olarak tanımlarız şablon görevi görür.
        // 

        void BiseyYap();
       
    }//interfaceler birbirinin alternatifi olan fakat kod içerikleri faarklı olan durumlar için kullanırız.
}
