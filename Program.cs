using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplicationsTDPC14
{
    internal class Program
    {
        //esempio di tryparse
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("inserisci un numero");
        //    string inputString = Console.ReadLine();
        //    int input = 0;
        //    bool parseWasSuccessful = int.TryParse(inputString, out input);
        //}
        /*
         - chiedere all'utente un numero qualsiasi
         - ciclare sul numero dell'utente e ad ogni iterazione
         aggiungere una stringa in un array
         - chidere all'utente un secondo numero
         - aggiungere in una lista un numero di elementi
         presi dall'array pari al secondo numero indicato dall'utente
         */
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("inserisci un numero");
        //    string dimension = Console.ReadLine();

        //    string[] stringsArray = new string[int.Parse(dimension)];
        //    for (int i = 0; i < stringsArray.Length; i++)
        //        stringsArray[i] = "stringa" + i;

        //    Console.WriteLine("inserisci un secondo numero");
        //    int elementsNumber = int.Parse(Console.ReadLine());

        //    if (elementsNumber <= stringsArray.Length)
        //    {
        //        List<string> stringsList = new List<string>();
        //        for (int i = 0; i < elementsNumber; i++)
        //        {
        //            stringsList.Add(stringsArray[i]);
        //        }
        //    }
        //    else
        //        Console.WriteLine("l'array non contiene " + elementsNumber + " elementi");
        //}

        /*
         - tramite una funzione restituire un array di stringhe qualsiasi
         - tramite una seconda funzione restituire una lista di numeri decimali
         qualsiasi
         - chiamare entrambe le funzioni nel Main e stampare gli elementi
         delle collection restituite
         */
        //static void Main(string[] args)
        //{
        //    string[] strings = GetStrings();
        //    List<double> numbers = GetNumbers();

        //    Console.WriteLine(numbers);

        //    for (int i = 0; i < strings.Length; i++)
        //        Console.WriteLine(strings[i]);
        //    for (int i = 0; i < numbers.Count; i++)
        //        Console.WriteLine(numbers[i]);
        //}
        //static string[] GetStrings()
        //{
        //    return new string[] {
        //        "stringa1", "stringa2", "stringa3"
        //    };
        //}
        //static List<double> GetNumbers()
        //{
        //    return new List<double>()
        //    {
        //        10.5, 12, 89, 51.8
        //    };
        //}

        /*
         - creare un array di stringhe arbitrarie
         - tramite un ciclo popolare una lista di stringhe
         con tutti gli elementi contenuti nell'array
         - tramite un secondo ciclo stampare il contenuto
         sia dell'array che della lista
         */
        //static void Main(string[] args)
        //{
        //    string[] stringsArray = new string[]
        //    {
        //        "stringa1", "stringa2", "stringa3", "stringa4"
        //    };
        //    List<string> stringsList = new List<string>();

        //    for (int i = 0; i < stringsArray.Length; i++)
        //        stringsList.Add(stringsArray[i]);

        //    for (int i = 0; i < stringsArray.Length; i++)
        //    {
        //        Console.WriteLine("array dice: " + stringsArray[i]);
        //        Console.WriteLine("lista dice: " + stringsList[i]);
        //    }
        //}

        /*
         - creare un array di numeri casuali
         - creare un secondo array di numeri casuali
         - creare una lista di numeri il cui contenuto sia
         l'unione degli elementi dei due array
         */
        //static void Main(string[] args)
        //{
        //    int dimension = 10;
        //    int[] numbersArray1 = new int[dimension];
        //    int[] numbersArray2 = new int[dimension];

        //    Random r = new Random();
        //    for (int i = 0; i < dimension; i++)
        //    {
        //        numbersArray1[i] = r.Next(0, 50);
        //        numbersArray2[i] = r.Next(0, 50);
        //    }
        //    //opzione 1: cicli (se non voglio mischiarli..)
        //    List<int> numbersList1 = new List<int>();
        //    for (int i = 0; i < dimension; i++)
        //        numbersList1.Add(numbersArray1[i]);
        //    for (int i = 0; i < dimension; i++)
        //        numbersList1.Add(numbersArray2[i]);

        //    //opzione 2: concat nel costruttore della lista
        //    List<int> numbersList2 = new List<int>(numbersArray1.Concat(numbersArray2));

        //    //opzione 3: concat e ToList
        //    List<int> numbersList3 = numbersArray1.Concat(numbersArray2).ToList();
        //}


        //static void Main(string[] args)
        //{
        //    int[] numbersArray = new int[5];
        //    numbersArray[0] = 2;
        //    numbersArray[1] = 25;
        //    numbersArray[2] = 1;
        //    numbersArray[3] = 88;
        //    numbersArray[4] = 91;
        //    //numbersArray[5] = 105; //<- errore

        //    List<int> numbersList = new List<int>();
        //    numbersList.Add(0);
        //    numbersList.Add(10);
        //    numbersList.Add(20);
        //    numbersList.Add(30);
        //    numbersList.Add(30);
        //    numbersList.Add(50);
        //    numbersList.Add(770);
        //    numbersList.Add(80);
        //    numbersList.Add(90);
        //    numbersList.Add(100);

        //    Console.WriteLine("--array");

        //    for (int i = 0; i < numbersArray.Length; i++)
        //        Console.WriteLine(numbersArray[i]);

        //    Console.WriteLine("--lista");

        //    //esempio di remove in posizione 1
        //    numbersList.Remove(numbersList[1]);

        //    //esempio di remove di un elemento per value
        //    numbersList.Remove(770);

        //    for (int i = 0; i < numbersList.Count; i++)
        //        Console.WriteLine(numbersList[i]);


        //    List<int> numbersList1 = new List<int>();
        //    List<string> strings = new List<string>();
        //    strings.Add("stringa1");
        //    //strings.Add(12);
        //    //strings.Add(true);
        //}
    }
}
