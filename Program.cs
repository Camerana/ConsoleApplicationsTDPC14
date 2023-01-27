using System;

namespace ConsoleApplicationsTDPC14
{
    internal class Program
    {
        /*
         - chiedere all'utente 2 numeri
         - chiedere all'utente 2 stringhe
         - stampare su schermo la somma dei due numeri
         - stampare su schermo la "somma" delle due stringhe
         - stampare su schermo il numero maggiore e il numero minore nel formato:
            - "numero maggiore: {numeroMaggiore}"
            - "numero minore: {numeroMinore}"
         - stampare su schermo la stringa di lunghezza maggiore e minore nel formato:
            - "stringa di lunghezza maggiore: {stringaDiLunghezzaMaggiore}"
            - "stringa di lunghezza minore: {stringaDiLunghezzaMinore}"
         */
        /*
         - generare due numeri casuali compresi tra 1 e 5
         - chiedere all'utente una stringa di lunghezza maggiore di 20 caratteri
         - stampare su schermo la stringa a partire dall'indice dato dalla somma dei due caratteri
         */
        /*
         - leggere il contenuto di un file e salvarlo in una stringa
         - chidere all'utente una stringa da ricercare nel testo del file
         - stampare su schermo se la stringa è contenuta nel testo del file
         */
        /*
         - chiedere all'utente una stringa qualsiasi
         - chiedere all'utente una stringa da ricercare nella prima stringa
         - stampare su schermo la prima stringa evidenziando con un colore apposito le occorrenze
         della seconda stringa
         */
        static void Main(string[] args)
        {
        }

        /*
         - generare un numero casuale compreso tra 1 e 10
         - chiedere all'utente una stringa di lunghezza maggiore di 10 caratteri
            - se l'utente inserisce una stringha di lunghezza minore, stampare un
            messaggio di errore
         - tramite il numero casuale, stampare su schermo il carattere che si
         trova nella stringa all'indice corrispondente
         */
        //static void Main(string[] args)
        //{
        //    Random random = new Random();
        //    int numero = random.Next(1, 10);
        //    Console.WriteLine("inserisci una stringa di lunghezza maggiore di 10 caratteri");
        //    string input = Console.ReadLine();
        //    if (input.Length > 10)
        //        Console.WriteLine(input.Substring(numero, 1));
        //    else
        //        Console.WriteLine("la stringa è troppo corta");
        //}

        /*
         - data una stringa arbitraria:
            - chiedere all'utente una stringa qualsiasi
            - stampare su schermo se la stringa dell'utente è contenuta nella stringa iniziale
         */
        //static void Main(string[] args)
        //{
        //    string stringa = "questa è una stringa arbitraria";
        //    Console.WriteLine("inserisci una stringa");
        //    string input = Console.ReadLine();
        //    if (stringa.ToLowerInvariant().Contains(input.ToLowerInvariant()))
        //        Console.WriteLine("la stringa contiene l'input");
        //}

        /*
         - data una stringa arbitraria:
            - chiedere all'utente una stringa qualsiasi
            - stampare su schermo se la stringa iniziale comincia o finisce con 
            la stringa dell'utente
         */
        //static void Main(string[] args)
        //{
        //    string stringa = "questa è una stringa arbitraria";
        //    Console.WriteLine("inserisci una stringa");
        //    string input = Console.ReadLine();
        //    if (stringa.ToLowerInvariant().StartsWith(input.ToLowerInvariant()))
        //        Console.WriteLine("la stringa comincia con l'input");
        //    if (stringa.ToLowerInvariant().EndsWith(input.ToLowerInvariant()))
        //        Console.WriteLine("la stringa finisce con l'input");
        //}

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
