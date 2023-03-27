using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplicationsTDPC14.Veicoli
{
    public abstract class Veicolo
    {
        public int Cilindrata { get; set; }
        public string Carburante { get; set; }
        public int NumeroRuote { get; set; }
        public abstract void Accendi();
    }
    public abstract class Auto : Veicolo
    {
        public int NumeroPorte { get; set; }
        public void InserisciFrenoAMano() { }
    }
    public class Fiesta : Auto
    {
        public override void Accendi()
        {
            Console.WriteLine("La fiesta si accende");
        }
    }
    public class Panda : Auto
    {
        public override void Accendi()
        {
            Console.WriteLine("La panda si accende");
        }
    }

    public abstract class Moto : Veicolo
    {
        public string TipoSella { get; set; }
        public void Impenna() { }
    }
    public class Aprilia : Moto
    {
        public override void Accendi()
        {
            Console.WriteLine("L'aprilia si accende");
        }
    }
    public class Ducati : Moto
    {
        public string BrevettoSuono { get; set; }
        public override void Accendi()
        {
            Console.WriteLine("La ducati si accende");
        }
    }
}
