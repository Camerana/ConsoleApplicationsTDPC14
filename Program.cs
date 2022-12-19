using System;

namespace ConsoleApplicationsTDPC14
{
    internal class Program
    {
        /*
         - generare 5 numeri casuali compresi fra 0 e 20
         - stampare su schermo le coppie di numeri uguali con il formato:
            - es: "il numero1 e il numero2 sono uguali !" 
         */
        //static void Main(string[] args)
        //{
        //    Random r = new Random();
        //    int maxnumber = 5;
        //    int numero1 = r.Next(0, maxnumber);
        //    int numero2 = r.Next(0, maxnumber);
        //    int numero3 = r.Next(0, maxnumber);
        //    int numero4 = r.Next(0, maxnumber);
        //    int numero5 = r.Next(0, maxnumber);
        //    Console.WriteLine(numero1);
        //    Console.WriteLine(numero2);
        //    Console.WriteLine(numero3);
        //    Console.WriteLine(numero4);
        //    Console.WriteLine(numero5);

        //    if (numero1 == numero2)
        //        Console.WriteLine("il numero1 e il numero2 sono uguali !");
        //    else if (numero1 == numero3)
        //        Console.WriteLine("il numero1 e il numero3 sono uguali !");
        //    else if (numero1 == numero4)
        //        Console.WriteLine("il numero1 e il numero4 sono uguali !");
        //    else if (numero1 == numero5)
        //        Console.WriteLine("il numero1 e il numero5 sono uguali !");

        //    if (numero2 == numero3)
        //        Console.WriteLine("il numero2 e il numero3 sono uguali !");
        //    else if (numero2 == numero4)
        //        Console.WriteLine("il numero2 e il numero4 sono uguali !");
        //    else if (numero2 == numero5)
        //        Console.WriteLine("il numero2 e il numero4 sono uguali !");

        //    if (numero3 == numero4)
        //        Console.WriteLine("il numero3 e il numero4 sono uguali !");
        //    else if (numero3 == numero5)
        //        Console.WriteLine("il numero3 e il numero5 sono uguali !");

        //    if (numero4 == numero5)
        //        Console.WriteLine("il numero4 e il numero5 sono uguali !");
        //}
        /*
         - estrarre 5 numeri casuali compresi fra 1 e 20
         - chiedere all'utente 4 numeri
         - stampare su schermo se l'utente è riuscito a indovinare qualche numero
           - es: "hai fatto ambo !", "hai fatto terna !".. etc..
         */
        //static void Main(string[] args)
        //{
        //    Random r = new Random();
        //    int maxnumber = 21;
        //    int totaleNumeri = 5;

        //    int[] numeriEstratti = new int[totaleNumeri];
        //    for (int i = 0; i < totaleNumeri; i++)
        //        numeriEstratti[i] = r.Next(0, maxnumber);

        //    int totaleNumeriUtente = 5;
        //    int[] numeriUtente = new int[totaleNumeriUtente];
        //    for (int i = 0; i < totaleNumeriUtente; i++)
        //    {
        //        Console.WriteLine("inserisci il numero " + (i + 1));
        //        numeriUtente[i] = int.Parse(Console.ReadLine());
        //    }
        //    int numeriIndovinati = 0;
        //    for (int i = 0; i < totaleNumeri; i++)
        //        for (int j = 0; j < totaleNumeriUtente; j++)
        //            if (numeriEstratti[i] == numeriUtente[j])
        //                numeriIndovinati++;

        //    if (numeriIndovinati == 2)
        //        Console.WriteLine("hai fatto ambo");
        //    else if (numeriIndovinati == 3)
        //        Console.WriteLine("hai fatto terna");
        //    else if (numeriIndovinati == 4)
        //        Console.WriteLine("hai fatto quaterna");
        //    else if (numeriIndovinati == 5)
        //        Console.WriteLine("hai fatto cinquina");
        //}
        /*
         - creare due stringhe con valore arbitrario
         - chiedere all'utente una terza stringa
         - stampare su schermo le seguenti valutazioni:
            - se la stringa dell'utente è uguale a una delle due variabili
            - se la stringa dell'utente è di lunghezza maggiore o minore di ciascuna 
            delle due variabili
         */
        static void Main(string[] args)
        {
            string stringa1 = "stringa 1";
            string stringa2 = "sono la stringa 2";
            Console.WriteLine("inserisci una stringa");
            string input = Console.ReadLine();

            if (input == stringa1)
                Console.WriteLine("l'input utente è uguale alla stringa 1");
            if (input == stringa2)
                Console.WriteLine("l'input utente è uguale alla stringa 2");

            if (input.Length > stringa1.Length)
                Console.WriteLine("l'input è di lunghezza maggiore alla stringa 1");
            else if (input.Length < stringa1.Length)
                Console.WriteLine("l'input è di lunghezza minore alla stringa 1");
            else if (input.Length == stringa1.Length)
                Console.WriteLine("l'input è di lunghezza uguale alla stringa 1");

            if (input.Length > stringa2.Length)
                Console.WriteLine("l'input è di lunghezza maggiore alla stringa 2");
            else if (input.Length < stringa2.Length)
                Console.WriteLine("l'input è di lunghezza minore alla stringa 2");
            else if (input.Length == stringa2.Length)
                Console.WriteLine("l'input è di lunghezza uguale alla stringa 2");

        }
    }
}
