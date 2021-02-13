using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //encapsulation
        public void Add(Produck produck)
        {
            Console.WriteLine(produck.ProduckName + "eklendi.");

        }

        public void Update(Produck produck)
        {

            Console.WriteLine(produck.ProduckName + "güncellendi.");
        }
        

    }
}