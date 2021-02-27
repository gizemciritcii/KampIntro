using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class TasitKrediManager : IKrediManager
        //kredimanagerda mevcut olan hesapla metoduna erişim sağlamak için kullandık. kod tekrarından ve kod karmaşıklığını  en aza indirmiş olduk.
    {

        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            //
            //

            Console.WriteLine("taşıt kredisi ödeme planı hesaplandı.");
        }

    }
}
