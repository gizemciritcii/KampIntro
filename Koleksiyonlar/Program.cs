using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] { "engin", "kerem", "gizem", "defne" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);
            isimler[4] = "ilker";


            List<string> isimler2 = new List<string>();
            isimler2.Add("engin");
        }
    }
}
