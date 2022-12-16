using System;

namespace ConsoleApplicationsTDPC14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci un numero");
            int numero = int.Parse(Console.ReadLine());
            if (numero == 5)
            {
                Console.WriteLine("il numero è uguale a 5");
            }
            else if (numero == 10)
            {
                Console.WriteLine("il numero è uguale a 10");
            }
            else if (numero == 15)
            {
                Console.WriteLine("il numero è uguale a 15");
            }
            else
            {
                Console.WriteLine("non so ancora");
            }
        }
    }
}
