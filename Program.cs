using System;

namespace ConsoleApplicationsTDPC14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dimensione = 3;
            int[] numeri = new int[dimensione];
            numeri[0] = 12;
            numeri[1] = 2;
            numeri[2] = 10;

            string[] stringhe = new string[dimensione];
            stringhe[0] = "stringa1";
            stringhe[1] = "stringa2";
            stringhe[2] = "stringa3";

            for (int i = 0; i < dimensione; i++)
            {
                Console.WriteLine(numeri[i]);
                Console.WriteLine(stringhe[i]);
            }
        }
    }
}
