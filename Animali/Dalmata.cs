using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplicationsTDPC14.Animali
{
    public class Dalmata : Cane
    {
        public int NumeroMacchie { get; set; }
        public override void StampaDati()
        {
            base.StampaDati();
            Console.WriteLine("NumeroMacchie: " + this.NumeroMacchie);
        }
    }
}
