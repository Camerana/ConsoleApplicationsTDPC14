using ConsoleApplicationsTDPC14.Animali;
using System;

namespace ConsoleApplicationsTDPC14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carlino ca = new Carlino();
            ca.Razza = "";
            ca.Altezza = "";
            Stampa(ca);

            Bassotto ba = new Bassotto();
            ba.Razza = "";
            ba.Altezza = "";
            Stampa(ba);
        }

        public static void Stampa(Animale animale)
        {
            animale.FaiIlVerso();
        }
    }
}
