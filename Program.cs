using ConsoleApplicationsTDPC14.EsseriViventi;
using ConsoleApplicationsTDPC14.Visibilita;
using System;
using System.Net.NetworkInformation;

namespace ConsoleApplicationsTDPC14
{
    internal class Program
    {
        /*aggiornamento alle 21.15
         Creare una classe madre arbitraria con:
            - una property public
            - una property protected
            - una property private
            - un metodo public
            - un metodo protected
            - un metodo private
         Creare una classe figlia arbitraria che eredita dalla classe madre con:
            - una property private
            - un metodo private
         Creare una classe nipote arbitraria che eredita dalla classe figlia con:
            - una property public
         Istanziare:
            - un oggetto di tipo classe madre
            - un oggetto di tipo classe figlia
            - un oggetto di tipo classe nipote
         Valorizzare le properties degli oggetti
         Eseguirne i metodi
         */
        static void Main(string[] args)
        {

        }
        //static void Main(string[] args)
        //{
        //    ClasseMadre cm = new ClasseMadre();
        //    //cm.Nome_Public = "Nome public";
        //    cm.Stampa();

        //    ClasseFiglia0 cf0 = new ClasseFiglia0();
        //    //cf0.Nome_Public = "Nome public";
        //    cf0.Stampa();

        //    ClasseFiglia1 cf1 = new ClasseFiglia1();
        //    //cf1.Nome_Public = "Nome public";
        //    cf1.Stampa();

        //    ClasseNipote0 cn0 = new ClasseNipote0();
        //    //cn0.Nome_Public = "Nome public";
        //    cn0.Stampa();
        //}
        /* aggiornamento alle 8.15
         creare una classe EssereVivente con
            properties:
                - specie
                - nome
            metodi:
                - nutriti
         creare una classe Vertebrato : EssereVivente con:
            - metodi:
                - nutriti
                - muoviti
         creare una classe Pianta : EssereVivente con:
            - properties:
                - profondità radici
            - metodi:
                - nutriti
         - istanziare due oggetti di tipo Vertebrato e due di tipo Pianta,
         valorizzarne le properties e invocarne i metodi
         */
        //static void Main(string[] args)
        //{
        //    Vertebrato gatto = new Vertebrato();
        //    gatto.Nome = "Pallina";
        //    gatto.Specie = "Gatto";
        //    gatto.Nutriti();
        //    gatto.Muoviti();

        //    Vertebrato topo = new Vertebrato();
        //    topo.Nome = "Groviera";
        //    topo.Specie = "Topo";
        //    topo.Nutriti();
        //    topo.Muoviti();

        //    Pianta pino = new Pianta();
        //    pino.Nome = "Pinuccio";
        //    pino.Specie = "Pino";
        //    pino.ProfonditaRadici = 2;
        //    pino.Nutriti();

        //    Pianta quercia = new Pianta();
        //    quercia.Nome = "Lercia";
        //    quercia.Specie = "Quercia";
        //    quercia.ProfonditaRadici = 3;
        //    quercia.Nutriti();
        //}
    }
}
