using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplicationsTDPC14.EsseriViventi
{
    internal class Vertebrato : EssereVivente
    {
        public override void Nutriti()
        {
            Console.WriteLine(this.Nome + " " + this.Specie + " mangia");
        }
        public void Muoviti()
        {
            Console.WriteLine(this.Nome + " " + this.Specie + " si muove");
        }
    }
}
