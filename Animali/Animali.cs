using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplicationsTDPC14.Animali
{
    public abstract class Animale
    {
        public string Razza { get; set; }
        public abstract void FaiIlVerso();
        //public virtual void Metodo1()
        //{
        //    Console.WriteLine("Metodo1");
        //}
        //public void Metodo2()
        //{
        //    Console.WriteLine("Metodo2");
        //}
    }
    public abstract class Cane : Animale
    {
        public string Altezza { get; set; }
    }
    public class Carlino : Cane
    {
        public override void FaiIlVerso()
        {
            Console.WriteLine("Il carlino fa bau");
        }
    }
    public class Bassotto : Cane
    {
        public override void FaiIlVerso()
        {
            Console.WriteLine("Il bassotto fa bau");
        }
    }
}
