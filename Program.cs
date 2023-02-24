using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ConsoleApplicationsTDPC14
{
    internal class Program
    {
        /*
         - chiedere all'utente un numero
         - tramite un ciclo stampare tutti i numeri da 0 fino al numero
            scelto dall'utente
        */
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Inserisci un numero");
        //    int input = int.Parse(Console.ReadLine());

        //    if (input >= 0)
        //    {
        //        for (int i = 0; i < input; i++)
        //            Console.WriteLine(i);
        //    }
        //    else
        //    {
        //        for (int i = 0; i > input; i--)
        //            Console.WriteLine(i);
        //    }
        //}
        /*
         - chiedere all'utente un numero
         - generare un numero di stringhe pari al numero
            scelto dall'utente
         - tramite un foreach stampare le stringhe al contrario
         */
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Inserisci un numero");
        //    int input = int.Parse(Console.ReadLine());
        //    List<string> strings = new List<string>();
        //    for (int i = 0; i < input; i++)
        //        strings.Add("stringa " + i);
        //    foreach (string s in strings)
        //        Console.WriteLine(string.Join("", s.Reverse()));
        //}
        /*
         - chiedere all'utente una stringa
         - stampare ciascun carattere della stringa
            separandoli con uno spazio vuoto
            - es:
                "stringa"
                "s t r i n g a"
         */
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Inserisci una stringa");
        //    string input = Console.ReadLine();

        //    var result = string.Join(" ", input.ToCharArray());
        //    Console.WriteLine(result);
        //}
        /*
         - chiedere all'utente 3 stringhe
         - inserire le stringhe in una lista
         - passare la lista a una funzione
         - tramite la funzione, con un foreach, stampare
            il contenuto della lista
         */
        //static void Main(string[] args)
        //{
        //    List<string> strings = new List<string>();
        //    Console.WriteLine("Inserisci la stringa 1");
        //    strings.Add(Console.ReadLine());
        //    Console.WriteLine("Inserisci la stringa 2");
        //    strings.Add(Console.ReadLine());
        //    Console.WriteLine("Inserisci la stringa 3");
        //    strings.Add(Console.ReadLine());

        //    PrintStringsList(strings);
        //}
        //static void PrintStringsList(List<string> strings)
        //{
        //    foreach (string s in strings)
        //        Console.WriteLine(s);
        //}
        /*
         - chiedere all'utente un booleano
         - se il booleano è true, generare 4 numeri casuali,
            inserirli in un array e stampare il contenuto
            dell'array tramite un foreach
         - se il booleano è false, chiedere all'utente 2 stringhe,
            inserirle in una lista e stampare il contenuto
            della lista tramite un for
         */
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Inserisci un booleano");
        //    bool input = bool.Parse(Console.ReadLine());

        //    //if(input == true)
        //    if (input)
        //    {
        //        Random random = new Random();
        //        int[] numbers = new int[4];
        //        for (int i = 0; i < 4; i++)
        //            numbers[i] = random.Next();

        //        foreach (int number in numbers)
        //            Console.WriteLine(number);
        //    }
        //    else
        //    {
        //        List<string> strings = new List<string>();
        //        Console.WriteLine("Inserisci la prima stringa");
        //        strings.Add(Console.ReadLine());
        //        Console.WriteLine("Inserisci la seconda stringa");
        //        strings.Add(Console.ReadLine());

        //        for (int i = 0; i < strings.Count; i++)
        //            Console.WriteLine(strings[i]);
        //    }
        //}
        /*
         - creare un array di contenuto arbitrario
         - creare una lista di contenuto arbitrario
         - creare una lista il cui contenuto sia l'unione di quelli
            dell'array e della prima lista
         - tramite un foreach stampare il contenuto della seconda
            lista
         */
        //static void Main(string[] args)
        //{
        //    string[] stringsArray = new string[] {
        //        "array string 1", "array string 2", "array string 3", "array string 4"
        //    };
        //    List<string> stringsList = new List<string>() {
        //        "list string 1", "list string 2", "list string 3"
        //    };
        //    List<string> unionList = stringsArray.Concat(stringsList).ToList();
        //    foreach (string s in unionList)
        //        Console.WriteLine(s);
        //}

        //static void Main(string[] args)
        //{
        //    int[] numbers = new int[] {
        //        10,20,30
        //    };
        //    List<string> strings = new List<string>() {
        //        "stringa 1", "stringa 2", "stringa 3"
        //    };
        //    for (int i = 0; i < numbers.Length; i++)
        //        Console.WriteLine(numbers[i]);
        //    for (int i = 0; i < strings.Count; i++)
        //        Console.WriteLine(strings[i]);
        //    foreach (int n in numbers)
        //        Console.WriteLine(n);
        //    foreach (string s in strings)
        //        Console.WriteLine(s);


        //    List<int> numbersList = new List<int>() {
        //        10,20,30
        //    };

        //    PrintNumbersList(numbers);

        //    PrintNumbersList(numbersList);
        //}

        //static void PrintNumbersList(int[] numbers)
        //{
        //    for (int i = 0; i < numbers.Length; i++)
        //        Console.WriteLine(numbers[i]);
        //}
        //static void PrintNumbersList(List<int> numbers)
        //{
        //    foreach (int numero in numbers)
        //        Console.WriteLine(numero);
        //}
    }
}
