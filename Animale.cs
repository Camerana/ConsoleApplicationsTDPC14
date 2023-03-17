using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplicationsTDPC14
{
    internal class Animale
    {
        public string Razza { get; set; }
        public string Colore { get; set; }
        public void Mangia()
        {
            Console.WriteLine(this.Razza + " " + this.Colore + " mangia");
        }
        public void FaiIlVerso()
        {
            Console.WriteLine(this.Razza + " " + this.Colore + " fa il verso");
        }
    }
}
