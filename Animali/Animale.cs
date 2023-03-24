using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplicationsTDPC14.Animali
{
    public class Animale
    {
        public string Nome { get; set; }
        public virtual void FaiIlVerso()
        {
        }
        public virtual void StampaDati()
        {
            Console.WriteLine("Nome: " + this.Nome);
        }
    }
}
