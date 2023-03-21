using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplicationsTDPC14.Prodotti
{
    public class Prodotto
    {
        public string Nome { get; set; }
        public string Costo { get; set; }
        public virtual void Stampa()
        {
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Costo: " + this.Costo);
        }
    }
    public class Biscotto : Prodotto
    {
        public override void Stampa()
        {
        }
    }
    public class Patatine : Prodotto
    {
        public int Salinita { get; set; }
        public override void Stampa()
        {
            base.Stampa();
            Console.WriteLine("Salinità: " + this.Salinita);
        }
    }
    public class SanCarlo : Patatine
    {
        public override void Stampa()
        {
        }
    }
    public class Pringles : Patatine
    {
        public int AltezzaCilindro { get; set; }
        public override void Stampa()
        {
            base.Stampa();
            Console.WriteLine("AltezzaCilindro: " + this.AltezzaCilindro);
        }
    }
}
