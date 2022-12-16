using Microsoft.VisualBasic;
using System;
using System.Globalization;

namespace ConsoleApplicationsTDPC14
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    string stringa = "questa è una stringa";
        //    int numero = 10;
        //    bool booleano = true;
        //    bool booleano2 = false;
        //    DateTime data = DateTime.Now;
        //    data = data.AddDays(-2);
        //    Console.WriteLine(stringa);
        //    Console.WriteLine(numero);
        //    Console.WriteLine(booleano);
        //    Console.WriteLine(booleano2);
        //    Console.WriteLine(data.ToString("yyyyMMdd"));
        //}
        /*
         - chiedere all'utente una stringa, un numero e un booleano
         - salvare in 3 variabili del tipo specifico i valori dell'utente
         - stampare su schermo i valori delle 3 variabili
         */
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Inserisci una stringa");
        //    string stringa = Console.ReadLine();

        //    Console.WriteLine("Inserisci un numero");
        //    int numero = int.Parse(Console.ReadLine());

        //    Console.WriteLine("Inserisci un booleano");
        //    bool booleano = bool.Parse(Console.ReadLine());

        //    Console.WriteLine(stringa);
        //    Console.WriteLine(numero);
        //    Console.WriteLine(booleano);
        //}
        /*
         dichiarare 3 numeri decimali arbitrari
         chiedere all'utente un quarto numero intero o decimale
         stampare su schermo la somma e media dei 4 numeri
         */
        //static void Main(string[] args)
        //{
        //    double numero1 = 15.6;
        //    double numero2 = 10.5;
        //    double numero3 = 12.3;
        //    Console.WriteLine("Inserisci un numero");
        //    double numero4 = double.Parse(Console.ReadLine());
        //    double somma = numero1 + numero2 + numero3 + numero4;
        //    Console.WriteLine("Somma: " + somma);
        //    Console.WriteLine("Media: " + (somma / 4));
        //}
        /*
         chiedere all'utente 4 numeri
         stampare su schermo somma, prodotto e media dei 4 numeri
         stampare su schermo una stringa così formattata:
            "[dataCorrente] - [somma] - [prodotto] - [media]"
         */
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Inserisci il numero 1");
        //    double numero1 = double.Parse(Console.ReadLine());
        //    Console.WriteLine("Inserisci il numero 2");
        //    double numero2 = double.Parse(Console.ReadLine());
        //    Console.WriteLine("Inserisci il numero 3");
        //    double numero3 = double.Parse(Console.ReadLine());
        //    Console.WriteLine("Inserisci il numero 4");
        //    double numero4 = double.Parse(Console.ReadLine());
        //    double somma = numero1 + numero2 + numero3 + numero4;
        //    double prodotto = numero1 * numero2 * numero3 * numero4;
        //    double media = somma / 4;
        //    Console.WriteLine(somma);
        //    Console.WriteLine(prodotto);
        //    Console.WriteLine(media);
        //    DateTime dataCorrente = DateTime.Now;
        //    Console.WriteLine("[" + dataCorrente + "] "
        //        + "-" + " [" + somma + "] "
        //        + "- [" + prodotto + "] - [" + media + "]");
        //}
        /*
         creare una variabile per salvare la data corrente
         stampare su schermo la data corrente
         stampare su schermo la data corrente + 1 giorno
         stampare su schermo la data corrente - 2 mesi
         stampare su schermo la data corrente + 15 anni
         stampare su schermo la data corrente nel formato
            "anno/mese/giorno/ora/minuto/secondo/millisecondo"
         */
        //static void Main(string[] args)
        //{
        //    DateTime currentDate = DateTime.Now;
        //    Console.WriteLine(currentDate);
        //    Console.WriteLine(currentDate.AddDays(1));
        //    Console.WriteLine(currentDate.AddMonths(-2));
        //    Console.WriteLine(currentDate.AddYears(15));
        //    Console.WriteLine(currentDate.Year + "/"
        //        + currentDate.Month + "/"
        //        + currentDate.Day + "/"
        //        + currentDate.Hour + "/"
        //        + currentDate.Minute + "/"
        //        + currentDate.Second + "/"
        //        + currentDate.Millisecond);
        //}
        /*
         chiedere all'utente 3 numeri
         generare 3 numeri casuali tra 0 e 10
         stampare la somma dei 6 numeri
         stampare la data corrente + tanti giorni quanto il risultato della somma
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci il numero 1");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci il numero 2");
            int numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Inserisci il numero 3");
            int numero3 = int.Parse(Console.ReadLine());

            Random r = new Random();
            int numero4 = r.Next(0, 11);
            int numero5 = r.Next(0, 11);
            int numero6 = r.Next(0, 11);

            int somma = numero1 + numero2 + numero3 + numero4 + numero5 + numero6;
            Console.WriteLine("somma: " + somma);

            DateTime currentTime = DateTime.Now;
            Console.WriteLine("data corrente + somma: " + currentTime.AddDays(somma));
        }
    }
}
