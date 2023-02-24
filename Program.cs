using System;
using System.Collections.Generic;

namespace ConsoleApplicationsTDPC14
{
    internal class Program
    {
        //aggiornamento alle 7.50
        /*
         - chiedere all'utente 3 stringhe
         - inserire le stringhe in una lista
         - passare la lista a una funzione
         - tramite la funzione, con un foreach, stampare
            il contenuto della lista
         */
        /*
         - chiedere all'utente un booleano
         - se il booleano è true, generare 4 numeri casuali,
            inserirli in un array e stampare il contenuto
            dell'array tramite un foreach
         - se il booleano è false, chiedere all'utente 2 stringhe,
            inserirle in una lista e stampare il contenuto
            della lista tramite un for
         */
        /*
         - creare un array di contenuto arbitrario
         - creare una lista di contenuto arbitrario
         - creare una lista il cui contenuto sia l'unione di quelli
            dell'array e della prima lista
         - tramite un foreach stampare il contenuto della seconda
            lista
         */
        static void Main(string[] args)
        {
            int[] numbers = new int[] {
                10,20,30
            };
            List<string> strings = new List<string>() {
                "stringa 1", "stringa 2", "stringa 3"
            };
            for (int i = 0; i < numbers.Length; i++)
                Console.WriteLine(numbers[i]);
            for (int i = 0; i < strings.Count; i++)
                Console.WriteLine(strings[i]);
            foreach (int n in numbers)
                Console.WriteLine(n);
            foreach (string s in strings)
                Console.WriteLine(s);


            List<int> numbersList = new List<int>() {
                10,20,30
            };

            PrintNumbersList(numbers);

            PrintNumbersList(numbersList);
        }

        static void PrintNumbersList(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
                Console.WriteLine(numbers[i]);
        }
        static void PrintNumbersList(List<int> numbers)
        {
            foreach (int numero in numbers)
                Console.WriteLine(numero);
        }
    }
}
