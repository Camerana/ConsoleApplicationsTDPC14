using System;

namespace ConsoleApplicationsTDPC14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Prodotto p = new Prodotto();
            p.Nome = "Biscotti";
            p.Costo = 15;
            Console.WriteLine(p.Nome + ": " + p.Costo);
        }
    }
}
