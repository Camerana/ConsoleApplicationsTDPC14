using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplicationsTDPC14.Animali
{
    public class Gatto : Animale
    {
        public override void FaiIlVerso()
        {
            Console.WriteLine(this.Nome + " fa miao");
        }
        public void FaiLeFusa()
        {
            Console.WriteLine(this.Nome + " fa le fusa");
        }
    }
}
