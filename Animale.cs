using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplicationsTDPC14
{
    internal class Animale
    {
        public string Razza { get; set; }
        public string Eta { get; set; }
        private string colore;
        public string Colore
        {
            get
            {
                return this.colore;
            }
            set
            {
                if (value == "bianco" || value == "nero")
                    this.colore = value;
            }
        }
    }
}
