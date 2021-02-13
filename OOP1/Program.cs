using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Produck product1 = new Produck();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProduckName = "masa";
            product1.UnitsInStock = 3;
            product1.UnitPrice = 500;


            //pascalCase
            Produck product2 = new Produck { Id = 2, CategoryId = 5,
                UnitPrice = 600, ProduckName = "kalem", UnitsInStock = 5 };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

         

        }
    }
}
