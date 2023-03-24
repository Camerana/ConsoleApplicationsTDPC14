using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplicationsTDPC14.Animali
{
    public class Bassotto : Cane
    {
        public int Altezza { get; set; }
        public override void StampaDati()
        {
            base.StampaDati();
            Console.WriteLine("Altezza: " + this.Altezza);
        }
    }
}
