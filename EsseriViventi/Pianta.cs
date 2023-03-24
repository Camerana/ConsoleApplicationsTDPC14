using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplicationsTDPC14.EsseriViventi
{
    internal class Pianta : EssereVivente
    {
        public int ProfonditaRadici { get; set; }
        public override void Nutriti()
        {
            Console.WriteLine(this.Nome + " "
                + this.Specie + " con radici di profondità "
                + this.ProfonditaRadici + " fa la fotosintesi");
        }
    }
}
