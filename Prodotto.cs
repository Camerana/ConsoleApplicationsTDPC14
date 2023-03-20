using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplicationsTDPC14
{
    internal class Prodotto
    {
        public string Nome { get; set; }
        private double costo;
        public double Costo
        {
            get
            {
                return this.costo;
            }
            set
            {
                if (value > 10)
                    Console.WriteLine("Valore maggiore di 10");
                else
                    this.costo = value;
            }
        }
    }
}
