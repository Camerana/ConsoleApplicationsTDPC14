using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplicationsTDPC14
{
    internal class Program
    {
        //aggiornamento alle 7.40
        /*
         - creare un array di stringhe arbitrarie
         - tramite un ciclo popolare una lista di stringhe
         con tutti gli elementi contenuti nell'array
         - tramite un secondo ciclo stampare il contenuto
         sia dell'array che della lista
         */
        /*
         - creare un array di numeri casuali
         - creare un secondo array di numeri casuali
         - creare una lista di numeri il cui contenuto sia
         l'unione degli elementi dei due array
         */
        static void Main(string[] args)
        {
            int[] numbersArray = new int[5];
            numbersArray[0] = 2;
            numbersArray[1] = 25;
            numbersArray[2] = 1;
            numbersArray[3] = 88;
            numbersArray[4] = 91;
            //numbersArray[5] = 105; //<- errore

            List<int> numbersList = new List<int>();
            numbersList.Add(0);
            numbersList.Add(10);
            numbersList.Add(20);
            numbersList.Add(30);
            numbersList.Add(30);
            numbersList.Add(50);
            numbersList.Add(770);
            numbersList.Add(80);
            numbersList.Add(90);
            numbersList.Add(100);

            Console.WriteLine("--array");

            for (int i = 0; i < numbersArray.Length; i++)
                Console.WriteLine(numbersArray[i]);

            Console.WriteLine("--lista");

            //esempio di remove in posizione 1
            numbersList.Remove(numbersList[1]);

            //esempio di remove di un elemento per value
            numbersList.Remove(770);

            for (int i = 0; i < numbersList.Count; i++)
                Console.WriteLine(numbersList[i]);


            List<int> numbersList1 = new List<int>();
            List<string> strings = new List<string>();
            strings.Add("stringa1");
            //strings.Add(12);
            //strings.Add(true);
        }
    }
}
