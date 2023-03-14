using System;

namespace ConsoleApplicationsTDPC14
{
    internal class Program
    {
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
        static void Main(string[] args)
        {
            User u = new User();
            u.Name = "Test";
            Console.WriteLine(u.Name);
        }
    }
}
