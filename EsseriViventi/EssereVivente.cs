using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplicationsTDPC14.EsseriViventi
{
    public class EssereVivente
    {
        public string Specie { get; set; }
        public string Nome { get; set; }
        public virtual void Nutriti() { }
    }
}
