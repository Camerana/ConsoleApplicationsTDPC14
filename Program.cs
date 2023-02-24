using System;
using System.Collections.Generic;

namespace ConsoleApplicationsTDPC14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeri = new int[] {
                10,20,30
            };
            List<string> stringhe = new List<string>() {
                "stringa 1", "stringa 2", "stringa 3"
            };
            for (int i = 0; i < numeri.Length; i++)
                Console.WriteLine(numeri[i]);
            for (int i = 0; i < stringhe.Count; i++)
                Console.WriteLine(stringhe[i]);
            foreach (int numero in numeri)
                Console.WriteLine(numero);
            foreach (string stringa in stringhe)
                Console.WriteLine(stringa);
        }
    }
}
