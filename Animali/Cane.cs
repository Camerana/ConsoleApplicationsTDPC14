using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplicationsTDPC14.Animali
{
    public class Cane : Animale
    {
        public override void FaiIlVerso()
        {
            Console.WriteLine(this.Nome + " fa bau");
        }
        public void RiportaLaPalla()
        {
            Console.WriteLine(this.Nome + " riporta la palla");
        }
    }
}
