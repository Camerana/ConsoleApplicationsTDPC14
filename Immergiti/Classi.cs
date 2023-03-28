using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplicationsTDPC14.Immergiti
{
    public interface IImmergiti
    {
        public void Immergiti();
    }
    public abstract class Animale { }
    public abstract class Cane : Animale, IImmergiti
    {
        public abstract void Immergiti();
    }
    public class Bassotto : Cane
    {
        public override void Immergiti()
        {
            Console.WriteLine("Il bassotto si immerge");
        }
    }
    public class Labrador : Cane
    {
        public override void Immergiti()
        {
            Console.WriteLine("Il labrador si immerge");
        }
    }

    public abstract class Aracnide : Animale { }
    public class Scorpione : Aracnide { }

    public abstract class Veicolo { }
    public abstract class Auto : Veicolo { }
    public class Panda : Auto { }
    public class Fiesta : Auto { }
    public abstract class Sottomarino : Veicolo, IImmergiti
    {
        public string Modello { get; set; }
        public virtual void Immergiti()
        {
            Console.WriteLine("Il sottomarino si immerge");
        }
    }
    public class UBoat : Sottomarino
    {

    }
}
