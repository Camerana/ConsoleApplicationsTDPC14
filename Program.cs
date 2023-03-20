using System;
using System.Collections.Generic;

namespace ConsoleApplicationsTDPC14
{
    internal class Program
    {
        /*
         Simulare una lotteria:
            - chiedere all'utente 3 numeri
            - estrarre 5 numeri casuali
            - stampare su schermo se l'utente ha indovinato
            dei numeri e quali
         */
        /*
         Simulare una lotteria con biglietti:
            - creare una classe Giocatore con:
                - properties:
                    - lista di biglietti comprati
            - creare una classe Biglietto con:
                - properties:
                    - Luogo di acquisto
                    - Seriale
            - permettere all'utente di comprare n biglietti
            - creare una lista di biglietti estraibili
            - estrarre un biglietto dalla lista e stampare 
            su schermo i dati del biglietto estratto
            - comunicare all'utente se ha vinto
         */
        static void Main(string[] args)
        {
            List<Biglietto> bigliettiEstraibili = new List<Biglietto>();
            for (int i = 0; i < 200; i++)
            {
                Biglietto b = new Biglietto();
                b.LuogoDiAcquisto = "Città " + i;
                b.Seriale = i;
                bigliettiEstraibili.Add(b);
            }
            Giocatore giocatore = new Giocatore();
            Console.WriteLine("Quanti biglietti vuoi comprare ?");
            int input = int.Parse(Console.ReadLine());

            Random r = new Random();
            for (int i = 0; i < input; i++)
            {
                int bigliettoRandom = r.Next(0, bigliettiEstraibili.Count);
                Biglietto bigliettoComprato = bigliettiEstraibili[bigliettoRandom];
                giocatore.Biglietti.Add(bigliettoComprato);
            }
            int indiceBigliettoVincitore = r.Next(0, bigliettiEstraibili.Count);
            Biglietto bigliettoVincitore = bigliettiEstraibili[indiceBigliettoVincitore];

            Console.WriteLine(bigliettoVincitore.LuogoDiAcquisto + ": " + bigliettoVincitore.Seriale);

            foreach (Biglietto biglietto in giocatore.Biglietti)
            {
                if (biglietto.Seriale == bigliettoVincitore.Seriale)
                    Console.WriteLine("Hai vinto !");
            }
        }
        //static void Main(string[] args)
        //{
        //    Animale a = new Animale();
        //    a.Razza = "Elefante";
        //    a.Eta = 56;

        //    Animale a1 = new Animale("Cavallo", 12);
        //}
        //static void Main(string[] args)
        //{
        //    Prodotto p = new Prodotto();
        //    p.Nome = "Biscotti";
        //    p.Costo = 15;
        //    Console.WriteLine(p.Nome + ": " + p.Costo);
        //}
    }
}
