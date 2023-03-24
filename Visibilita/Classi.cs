using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplicationsTDPC14.Visibilita
{
    public class ClasseMadre
    {
        public string Nome_Public { get; set; } = "Nome public"; //visibile ovunque
        protected string Nome_Protected { get; set; } = "Nome protected"; //visibile nella classe e nelle classi che ereditano
        private string Nome_Private { get; set; } = "Nome private"; //visibile solo nella classe
        public virtual void Stampa()
        {
            Console.WriteLine(this.Nome_Public);
            Console.WriteLine(this.Nome_Protected);
            Console.WriteLine(this.Nome_Private);
        }
    }

    public class ClasseFiglia0 : ClasseMadre
    {
        public override void Stampa()
        {
            Console.WriteLine(this.Nome_Public);
            Console.WriteLine(this.Nome_Protected);
            //Console.WriteLine(this.Nome_Private);
        }
    }

    public class ClasseFiglia1 : ClasseMadre
    {
        public override void Stampa()
        {
            Console.WriteLine(this.Nome_Public);
            Console.WriteLine(this.Nome_Protected);
            //Console.WriteLine(this.Nome_Private);
        }
    }

    public class ClasseNipote0 : ClasseFiglia0
    {
        public override void Stampa()
        {
            Console.WriteLine(this.Nome_Public);
            Console.WriteLine(this.Nome_Protected);
            //Console.WriteLine(this.Nome_Private);
        }
    }
}
