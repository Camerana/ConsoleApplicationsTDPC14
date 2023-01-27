using System;

namespace ConsoleApplicationsTDPC14
{
    internal class Program
    {
        /*
         - generare un numero casuale compreso tra 1 e 10
         - chiedere all'utente una stringa di lunghezza maggiore di 10 caratteri
            - se l'utente inserisce una stringha di lunghezza minore, stampare un
            messaggio di errore
         - tramite il numero casuale, stampare su schermo il carattere che si
         trova nella stringa all'indice corrispondente
         */
        /*
         - data una stringa arbitraria:
            - chiedere all'utente una stringa qualsiasi
            - stampare su schermo se la stringa dell'utente è contenuta nella stringa iniziale
         */
        /*
         - data una stringa arbitraria:
            - chiedere all'utente una stringa qualsiasi
            - stampare su schermo se la stringa iniziale comincia o finisce con 
            la stringa dell'utente
         */
        static void Main(string[] args)
        {
            string stringa = "questA è uNA sTriNGa";

            string parola = "QueSTa";

            bool contains = stringa.ToLowerInvariant().Contains(parola.ToLowerInvariant());
            Console.WriteLine(contains);
        }

        /*
         - chiedere all'utente 3 stringhe
         - stampare le 3 stringhe tutte in minuscolo e in maiuscolo
         - stampare i primi 3 caratteri di ciascuna stringa
            - attenzione alle stringhe di lunghezza minore di 3 caratteri
         */
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("inserisci la stringa 1");
        //    string stringa1 = Console.ReadLine();
        //    Console.WriteLine("inserisci la stringa 2");
        //    string stringa2 = Console.ReadLine();
        //    Console.WriteLine("inserisci la stringa 3");
        //    string stringa3 = Console.ReadLine();

        //    Console.WriteLine("stringa 1:");
        //    Console.WriteLine(stringa1.ToLowerInvariant());
        //    Console.WriteLine(stringa1.ToUpperInvariant());
        //    if (stringa1.Length >= 3)
        //        Console.WriteLine(stringa1.Substring(0, 3));
        //    Console.WriteLine("----------");

        //    Console.WriteLine("stringa 2:");
        //    Console.WriteLine(stringa2.ToLowerInvariant());
        //    Console.WriteLine(stringa2.ToUpperInvariant());
        //    if (stringa2.Length >= 3)
        //        Console.WriteLine(stringa2.Substring(0, 3));
        //    Console.WriteLine("----------");

        //    Console.WriteLine("stringa 3:");
        //    Console.WriteLine(stringa3.ToLowerInvariant());
        //    Console.WriteLine(stringa3.ToUpperInvariant());
        //    if (stringa3.Length >= 3)
        //        Console.WriteLine(stringa3.Substring(0, 3));
        //}

        /*
         - generare un numero casuale compreso fra 1 e 10
         - data una stringa di lunghezza di 15 caratteri:
            - stampare la stringa a partire dall'indice corrispondente al numero
            generato
         - sostituire ogni occorrenza di un carattere a scelta nella stringa
         con "Y" e stampare il risultato su schermo
         */
        //static void Main(string[] args)
        //{
        //    Random random = new Random();
        //    int randomNumber = random.Next(1, 10);

        //    string stringa = "sono una string";

        //    Console.WriteLine(stringa.Substring(randomNumber));

        //    Console.WriteLine(stringa.Replace("o", "Y"));
        //}


        //ESEMPI
        //static void Main(string[] args)
        //{
        //    string stringa = "questa è una stringa";

        //    string stringa2 = stringa.Substring(5);
        //    string stringa3 = stringa.Substring(5, 10);

        //    string stringa4 = stringa.Replace("questa", "quella");
        //    string stringa5 = stringa.ToUpperInvariant();
        //    string stringa6 = stringa.ToLowerInvariant();
        //    string stringa7 = stringa.Remove(5, 6);
        //    string[] parole = stringa.Split(' ');
        //    bool contains = stringa.Contains("gegeasgae");
        //    bool startsWith = stringa.StartsWith("questa");
        //    bool endsWith = stringa.EndsWith("stringa");

        //    Console.WriteLine(stringa);
        //    //Console.WriteLine(stringa2);
        //    //Console.WriteLine(stringa3);
        //    //Console.WriteLine(stringa4);
        //    //Console.WriteLine(stringa5);
        //    //Console.WriteLine(stringa6);
        //    //Console.WriteLine(stringa7);
        //    //for (int i = 0; i < parole.Length; i++)
        //    //    Console.WriteLine(parole[i]);
        //    //Console.WriteLine(contains);
        //    //Console.WriteLine(startsWith);
        //    //Console.WriteLine(endsWith);
        //    Console.ReadKey();
        //}
    }
}
