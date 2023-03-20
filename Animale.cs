using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ConsoleApplicationsTDPC14
{
    internal class Animale
    {
        public string Razza { get; set; }
        public int Eta { get; set; }

        public Animale()
        {
            Console.WriteLine("E' stato creato un animale");
        }
        public Animale(string razza, int eta)
        {
            this.Razza = razza;
            this.Eta = eta;
        }
    }
}
