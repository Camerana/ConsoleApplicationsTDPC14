using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplicationsTDPC14
{
    internal class Distributore
    {
        public List<Prodotto> Prodotti { get; set; } = new List<Prodotto>();

        public void Stampa()
        {
            foreach (Prodotto prodotto in this.Prodotti)
            {
                Console.WriteLine(prodotto.Nome + ": " + prodotto.Costo);
            }
        }
    }
}
