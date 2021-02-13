using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>//T type yani tipten geliyor.Buraya istediğimiz değer tipini class yazabiliriz.
    {
        T[] items;// direk calss içinde olduğu için tüm metotlardan ulaşılabilir.
        public MyList()//constructor
        {
            items = new T[0];
        }
        public  void  Add(T item) // hangi değer döndürürsen onun değerni lmış olur T.
        {

            T[] tempArray = items;//geçiçi referans.
            items = new T[items.Length+1]; //dizinin eleman sayısnı +1 artırıyoruz.

            for (int i = 0; i <tempArray.Length; i++)
            {
                items[i] = tempArray[i];


            }
            items[items.Length - 1] = item;
            } 
        
    }
}
