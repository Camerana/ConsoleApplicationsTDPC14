using System;
using System.Collections.Generic;

namespace ConsoleApplicationsTDPC14
{
    internal class Program
    {
        /*
         - creare una classe Animale con caratteristiche:
            - razza
            - eta
            - colore
         - generare un numero casuale tra 1 e 5
         - creare n oggetti di tipo Animale equivalenti al numero estratto
         - attribuire valori qualsiasi a ciascun animale, ma
            fare in modo che il colore possa essere solo "bianco" o "nero"
         */
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 5);
            for (int i = 0; i < number; i++)
            {
                Animale animale = new Animale();
                animale.Eta = "10";
                animale.Razza = "Elefante";
                animale.Colore = "nero";

                Console.WriteLine(animale.Eta + " " + animale.Razza + " " + animale.Colore);
            }
        }
        /*
         - creare una classe Prodotto con le seguenti properties:
            - Nome
            - Costo
         - chiedere all'utente nome e costo di un prodotto e istanziarne
         un oggetto
         - fare in modo che si possano settare nomi solo di lunghezza
         maggiore di 5 caratteri
         - stampare su schermo i valori delle properties dell'oggetto
         istanziato
         */
        //static void Main(string[] args)
        //{
        //    Prodotto p = new Prodotto();
        //    Console.WriteLine("Inserisci il nome");
        //    p.Nome = Console.ReadLine();
        //    Console.WriteLine("Inserisci il costo");
        //    p.Costo = Console.ReadLine();

        //    Console.WriteLine(p.Nome);
        //    Console.WriteLine(p.Costo);
        //}
        //static void Main(string[] args)
        //{
        //    User u = new User();
        //    u.Name = "Test";
        //    Console.WriteLine(u.Name);
        //}
    }
}
