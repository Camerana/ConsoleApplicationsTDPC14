using ConsoleApplicationsTDPC14.Immergiti;
using System.Collections.Generic;

namespace ConsoleApplicationsTDPC14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bassotto bassotto = new Bassotto();
            Labrador labrador = new Labrador();
            UBoat uBoat = new UBoat();

            Immersione(bassotto);
            Immersione(labrador);
            Immersione(uBoat);

        }
        static void Immersione(IImmergiti oggetto)
        {
            oggetto.Immergiti();
        }
    }
}
