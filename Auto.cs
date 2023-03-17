using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplicationsTDPC14
{
    public class Auto
    {
        public string Modello { get; set; }
        public string Colore { get; set; }
        //costruttore
        public Auto()
        {
            this.Modello = "Panda";
            this.Colore = "Nero";
            Console.WriteLine("Creato oggetto con: " + this.Modello + " " + this.Colore);
        }
    }
}
