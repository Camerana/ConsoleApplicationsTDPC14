using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplicationsTDPC14.Libreria
{
    public class Libreria
    {
        public List<Scaffale> Scaffali { get; set; } = new List<Scaffale>();
    }
    public class Scaffale
    {
        public List<Prodotto> Prodotti { get; set; } = new List<Prodotto>();
    }
    public abstract class Prodotto
    {
        public string Nome { get; set; }
        public string Autore { get; set; }
    }
    public class Libro : Prodotto
    {
        public int NumeroPagine { get; set; }
    }
    public class DVD : Prodotto
    {
        public int Durata { get; set; }
    }
}
