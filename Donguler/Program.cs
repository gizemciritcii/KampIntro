using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Dersler = new string[] { "a dersi", "b dersi", "java" };         
            
         
            for (int i = 0; i <Dersler.Length; i++)
            {
                Console.WriteLine(Dersler[i]);
            }
        }
    }
}
