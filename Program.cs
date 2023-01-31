using System;
using System.Globalization;

namespace ConsoleApplicationsTDPC14
{
    internal class Program
    {
        /*
         - chiedere all'utente i suoi dati anagrafici
         e tramite un ciclo for stamparli 5 volte
         - tramite una funzione (con return) chiedere
         all'utente un numero e tramite un'altra funzione
         stampare il numero e il quadrato del numero
         */
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci il tuo nome");
            string nome = Console.ReadLine();
            Console.WriteLine("inserisci il tuo cognome");
            string cognome = Console.ReadLine();
            for (int i = 0; i < 5; i++)
                Console.WriteLine(nome + " " + cognome);

            PrintNumber(GetNumber());
        }
        static int GetNumber()
        {
            Console.WriteLine("inserisci un numero");
            string input = Console.ReadLine();
            return int.Parse(input);
        }
        static void PrintNumber(int number)
        {
            Console.WriteLine(number);
            Console.WriteLine(number * number);
        }

        /*
         - tramite un ciclo for chiamare 20 volte una
         funzione che abbia un numero in ingresso
         e lo stampi su schermo
         */
        //static void Main(string[] args)
        //{
        //    for(int i = 0; i < 20; i++)
        //    {
        //        PrintNumber(i);
        //    }
        //}
        //static void PrintNumber(int number)
        //{
        //    Console.WriteLine(number);
        //}

        /*
         tramite l'uso del ciclo for stampare su schermo
         un poligono di lato 10 (caratteri)
         */
        //static void Main(string[] args)
        //{
        //    int dimensione = 4;
        //    for (int i = 0; i < dimensione; i++)
        //    {
        //        string linea = "";
        //        for (int j = 0; j < dimensione; j++)
        //        {
        //            linea += "0";
        //        }
        //        Console.WriteLine(linea);
        //    }
        //}


        /*
         - creare una funzione che restituisca
         una stringa arbitraria
         - tramite una seconda funzione stampare
         su schermo la stringa arbitraria
         */
        //static void Main(string[] args)
        //{
        //    PrintString(GetString());
        //}
        //static string GetString()
        //{
        //    return "stringa arbitraria";
        //}
        //static void PrintString(string s)
        //{
        //    Console.WriteLine(s);
        //}
        /*
         - tramite un ciclo for stampare su schermo
         25 numeri casuali
         - tramite un secondo ciclo for stampare su
         schermo 25 booleani casuali
         */
        //static void Main(string[] args)
        //{
        //    Random random = new Random();
        //    for (int i = 0; i < 25; i++)
        //        Console.WriteLine(random.Next());
        //    for (int i = 0; i < 25; i++)
        //    {
        //        int n = random.Next(0, 2);
        //        if (n == 0)
        //            Console.WriteLine("False");
        //        else
        //            Console.WriteLine("True");
        //    }
        //}

        /*
         - chiedere all'utente due stringhe e stamparle
         su schermo 50 volte ciascuna
         */
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("inserisci la stringa 1");
        //    string stringa1 = Console.ReadLine();
        //    Console.WriteLine("inserisci la stringa 2");
        //    string stringa2 = Console.ReadLine();
        //    for (int i = 0; i < 50; i++)
        //    {
        //        Console.WriteLine(stringa1);
        //        Console.WriteLine(stringa2);
        //    }
        //}


        //static void Main(string[] args)
        //{
        //    for (int i = 0; i < 50; i++)
        //    {
        //        for (int j = 0; j < 50; j++)
        //        {
        //            for (int k = 0; k < 50; k++)
        //            {
        //                Console.WriteLine("i) " + i + " j) " + j + " k) " + k);
        //                //vedo i, j e k
        //            }
        //            //vedo i e j
        //        }
        //        //vedo i
        //    }
        //}

        //static void Main(string[] args)
        //{
        //    int[] numeri = new int[5];
        //    numeri[0] = 0;
        //    numeri[1] = 25;
        //    numeri[2] = 3;
        //    numeri[3] = 12;
        //    numeri[4] = 78;
        //    for (int i = 0; i < numeri.Length; i++)
        //    {
        //        Console.WriteLine(i + ") " + numeri[i]);
        //    }

        //    int arrayLength = 50;
        //    string[] strings = new string[arrayLength];
        //    for (int i = 0; i < arrayLength; i++)
        //    {
        //        string newIndex = i + " new";
        //        strings[i] = newIndex;
        //    }
        //    for (int i = 0; i < strings.Length; i++)
        //    {
        //        Console.WriteLine(strings[i]);
        //    }
        //}
    }
}
