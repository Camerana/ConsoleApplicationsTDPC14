using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace ConsoleApplicationsTDPC14
{
    internal class Program
    {
        /*
         creare il gioco di sasso, carta, forbici
         */
        /*
         creare un gioco in cui il giocatore deve indovinare
         un numero per 3 volte di seguito prendendolo da un pool
         di dimensione variabile a scelta dell'utente stesso:
            - chiedere all'utente il range dei numeri da generare
            - per 3 volte chiedere all'utente un numero
            - stampare su schermo quanti e quali numeri si sono indovinati
         */
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci la dimensione dell'array");
            int dimensione = int.Parse(Console.ReadLine());
            int[] numeri = new int[dimensione];

            Console.WriteLine("inserisci il numero minore del range");
            int numeroMinoreRange = int.Parse(Console.ReadLine());

            Console.WriteLine("inserisci il numero maggiore del range");
            int numeroMaggioreRange = int.Parse(Console.ReadLine());

            Random r = new Random();
            for (int i = 0; i < dimensione; i++)
                numeri[i] = r.Next(numeroMinoreRange, numeroMaggioreRange);

            for (int i = 0; i < 3; i++)
            {
                object[] result = GetNumero(numeri);
                if (Convert.ToBoolean(result[0]) == true)
                    Console.WriteLine("hai indovinato il numero " + result[1]);
            }
        }
        static object[] GetNumero(int[] numeri)
        {
            Console.WriteLine("indovina un numero");
            int numero = int.Parse(Console.ReadLine());
            bool found = numeri.Contains(numero);
            object[] objects = new object[2];
            objects[0] = found;
            objects[1] = numero;
            //Tuple<bool, int> values = new Tuple<bool, int>(found, numero);
            return objects;
        }

        /*
         creare 3 funzioni:
            1)- chiede all'utente i suoi dati anagrafici e il suo
            animale preferito
            2)- stampa su schermo i dati anagrafici dell'utente
            3)- stampa su schermo l'animale preferito dell'utente
         */
        //static void Main(string[] args)
        //{
        //    string dati = GetDati();
        //    string animalePreferito = GetAnimalePreferito();
        //    Stampa(dati, animalePreferito);
        //}
        //static string GetDati()
        //{
        //    Console.WriteLine("inserisci i tuoi dati anagrafici");
        //    string dati = Console.ReadLine();
        //    return dati;
        //}
        //static string GetAnimalePreferito()
        //{
        //    Console.WriteLine("inserisci il tuo animale preferito");
        //    string animalePreferito = Console.ReadLine();
        //    return animalePreferito;
        //}
        //static void Stampa(string dati, string animalePreferito)
        //{
        //    Console.WriteLine(dati);
        //    Console.WriteLine(animalePreferito);
        //}

        /*
         - creare un array di dimensione a scelta dell'utente
         - popolare completamente l'array di numeri casuali
         - tramite una funzione stampare su schermo tutti i numeri
        dell'array
         - stampare su schermo il numero maggiore tra quelli generati
         */
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("inserisci la dimensione dell'array");
        //    int dimensione = int.Parse(Console.ReadLine());
        //    int[] numeri = new int[dimensione];

        //    Random random = new Random();
        //    for (int i = 0; i < dimensione; i++)
        //        numeri[i] = random.Next(0, 20);

        //    PrintNumbers(numeri);

        //    Console.WriteLine("numero maggiore: " + numeri.Max());
        //}
        //static void PrintNumbers(int[] nums)
        //{
        //    for (int i = 0; i < nums.Length; i++)
        //        Console.WriteLine(i + ") " + nums[i]);
        //}

        /*
         - chiedere all'utente due stringhe
         - stampare su schermo la concatenazione delle due stringhe
         - stampare su schermo le due stringhe al contrario
         */
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("inserisci la prima stringa");
        //    string input1 = Console.ReadLine();
        //    Console.WriteLine("inserisci la seconda stringa");
        //    string input2 = Console.ReadLine();
        //    Console.WriteLine(input1 + input2);

        //    var charsInput1 = input1.Reverse();
        //    for (int i = 0; i < charsInput1.Count(); i++)
        //        Console.Write(charsInput1.ElementAt(i));

        //    Console.WriteLine();
        //    var charsInput2 = input2.Reverse();
        //    for (int i = 0; i < charsInput2.Count(); i++)
        //        Console.Write(charsInput2.ElementAt(i));
        //}


        /*
         creare due funzioni con queste caratteristiche:
            1)- accetti in ingresso una stringa e un numero intero
              - stampi la concatenazione della stringa e del numero
              - stampi il numero al quadrato
            2)- accetti in ingresso due booleani
              - stampi su schermo se entrambi i booleani sono true
         */
        //static void Main(string[] args)
        //{
        //    Funzione1("questa è la stringa", 10);
        //    Funzione2(true, true);
        //}
        //public static void Funzione1(string stringa, int numero)
        //{
        //    Console.WriteLine(stringa + numero);
        //    Console.WriteLine(numero * numero);
        //}
        //public static void Funzione2(bool bool1, bool bool2)
        //{
        //    if (bool1 && bool2)
        //        Console.WriteLine("Entrambi i booleani sono true");
        //}
        /*
         - tramite una funzione generare 3 numeri casuali compresi
            tra 0 e 10
         - tramite una seconda funzione stampare su schermo la somma
         e il prodotto dei tre numeri
         */
        //static void Main(string[] args)
        //{
        //    int[] numbers = GenerateRandomNumbers();
        //    PrintNumbers(numbers);
        //}
        //public static int[] GenerateRandomNumbers()
        //{
        //    Random random = new Random();
        //    int n1 = random.Next(0, 10);
        //    int n2 = random.Next(0, 10);
        //    int n3 = random.Next(0, 10);
        //    int[] result = new int[3];
        //    result[0] = n1;
        //    result[1] = n2;
        //    result[2] = n3;
        //    return result;
        //}
        //public static void PrintNumbers(int[] nums)
        //{
        //    int somma = 0;
        //    int prodotto = 1;
        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        somma = somma + nums[i];
        //        prodotto = prodotto * nums[i];
        //    }
        //    Console.WriteLine(somma);
        //    Console.WriteLine(prodotto);
        //}



        /*
         creare una funzione che:
            - accetti in ingresso 2 stringhe
            - stampi su schermo quella di lunghezza maggiore
            - stampi su schermo se la prima contiene la seconda
         */
        //static void Main(string[] args)
        //{
        //    string s1 = "sono la stringa 1";
        //    string s2 = "questa qui invece è la stringa 2";
        //    CompareStrings(s1, s2);
        //}
        //public static void CompareStrings(string stringa1, string stringa2)
        //{
        //    if (stringa1.Length > stringa2.Length)
        //        Console.WriteLine(stringa1);
        //    else
        //        Console.WriteLine(stringa2);

        //    if (stringa1.Contains(stringa2))
        //        Console.WriteLine("la stringa 1 contiene la stringa 2");
        //}




        /*
         - chiedere all'utente 2 stringhe e un numero
         - tramite una funzione stampare su schermo il numero moltiplicato
         per 10 e per 20
         - tramite una seconda funzione stampare su schermo il 5° carattere
         della prima stringa
         - tramite una terza funzione stampare su schermo la lettera finale
         della seconda stringa
         */
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("inserisci la prima stringa");
        //    string stringa1 = Console.ReadLine();
        //    Console.WriteLine("inserisci la seconda stringa");
        //    string stringa2 = Console.ReadLine();
        //    Console.WriteLine("inserisci il numero");
        //    int numero = int.Parse(Console.ReadLine());
        //    PrintNumber(numero);
        //    PrintFifthCharacter(stringa1);
        //    PrintLastCharacter(stringa2);
        //}
        //public static void PrintNumber(int num)
        //{
        //    Console.WriteLine(num * 10);
        //    Console.WriteLine(num * 20);
        //}
        //public static void PrintFifthCharacter(string value)
        //{
        //    if (!string.IsNullOrEmpty(value) && value.Length >= 5)
        //        Console.WriteLine(value[4]);
        //}
        //public static void PrintLastCharacter(string value)
        //{
        //    if (!string.IsNullOrEmpty(value))
        //        Console.WriteLine(value.Last());
        //}
    }
}
