using System;
using System.Collections.Generic;

namespace ConsoleApplicationsTDPC14
{
    internal class Program
    {
        /*
         - chiedere all'utente i suoi dati anagrafici
        (es: nome, cognome, età...)
         - creare una classe che abbia le properties
        chieste all'utente
         - istanziare un oggetto con i dati chiesti
        all'utente
         - stampare su schermo le properties
        dell'oggetto
         */
        static void Main(string[] args)
        {
            Utente u = new Utente();

            Console.WriteLine("inserisci il tuo nome");
            u.Nome = Console.ReadLine();
            Console.WriteLine("inserisci il tuo cognome");
            u.Cognome = Console.ReadLine();
            Console.WriteLine("inserisci la tua età");
            u.Eta = int.Parse(Console.ReadLine());
            Console.WriteLine("inserisci il tuo indirizzo");
            u.Indirizzo = Console.ReadLine();

            Console.WriteLine(u.Nome);
            Console.WriteLine(u.Cognome);
            Console.WriteLine(u.Eta);
            Console.WriteLine(u.Indirizzo);
        }

        /*
         - creare una classe Gioco con properties:
            - public string Nome
            - public int Anno
         - creare 10 oggetti di tipo Gioco e
         valorizzarne le properties
         - tramite un ciclo stampare su schermo
         le properties dei 10 oggetti
         */
        //static void Main(string[] args)
        //{
        //    List<Gioco> giochi = new List<Gioco>();
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Gioco g = new Gioco();
        //        g.Nome = "g " + i;
        //        g.Anno = 2000 + i;
        //        giochi.Add(g);
        //    }
        //    foreach (Gioco gioco in giochi)
        //        Console.WriteLine(gioco.Nome + " " + gioco.Anno);
        //    for (int i = 0; i < giochi.Count; i++)
        //        Console.WriteLine(giochi[i].Nome + " " + giochi[i].Anno);
        //}

        /*
         - creare 100 oggetti che rappresentino
         prodotti diversi con caratteristiche:
            - nome
            - costo
            - produttore
            - numero
         */
        //static void Main(string[] args)
        //{
        //    List<Product> products = new List<Product>();
        //    for (int i = 0; i < 100; i++)
        //    {
        //        Product product = new Product();
        //        product.Name = "nome " + i;
        //        product.Manufacturer = "manufacturer " + i;
        //        product.Cost = i;
        //        product.Number = i * 10;

        //        products.Add(product);
        //    }
        //    for (int i = 0; i < products.Count; i++)
        //    {
        //        Console.WriteLine(products[i].Name + " " + products[i].Cost);
        //        Console.WriteLine(products[i].Manufacturer + " " + products[i].Number);
        //        Console.WriteLine("-------------------------------");
        //    }
        //}
    }
}
