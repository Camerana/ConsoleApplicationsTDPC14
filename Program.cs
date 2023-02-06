using System;

namespace ConsoleApplicationsTDPC14
{
    internal class Program
    {
        /*
         - creare due array di numeri interi
         - popolare il primo array di numeri casuali
         - copiare tutti gli elementi del primo array nel
         secondo
         - creare un terzo array che contenga gli elementi
         di entrambi gli array
         - stampare gli elementi di tutti e tre gli array
         */
        static void Main(string[] args)
        {
            int dimension = 10;
            int[] numbers1 = new int[dimension];
            int[] numbers2 = new int[dimension];

            Random random = new Random();
            for (int i = 0; i < dimension; i++)
                numbers1[i] = random.Next();

            for (int i = 0; i < dimension; i++)
                numbers2[i] = numbers1[i];

            int totalDimension = dimension * 2;
            int[] numbers3 = new int[totalDimension];

            for (int i = 0; i < dimension; i++)
                numbers3[i] = numbers1[i];

            for (int i = 0; i < dimension; i++)
                numbers3[dimension + i] = numbers2[i];

            PrintArray(numbers1);
            PrintArray(numbers2);
            PrintArray(numbers3);
        }
        static void PrintArray(int[] numeri)
        {
            for (int i = 0; i < numeri.Length; i++)
                Console.WriteLine(numeri[i]);
        }
        /*
         - creare un array di stringhe di dimensione 5
         - popolare l'array con stringhe arbitrarie
         - chiedere all'utente quale stringa vuole stampare
         - stampare su schermo la stringa scelta dall'utente
         */
        //static void Main(string[] args)
        //{
        //    string[] stringhe = new string[5];
        //    for (int i = 0; i < stringhe.Length; i++)
        //        stringhe[i] = "string numero " + i;
        //    Console.WriteLine("quale stringa vuoi stampare ?");
        //    int input = int.Parse(Console.ReadLine());
        //    if (input >= 0 && input < stringhe.Length)
        //        Console.WriteLine(stringhe[input]);
        //}
        /*
         - creare una funzione che restituisca un array
         di numeri casuali
         - chiamare la funzione 2 volte e stampare tutti
         i numeri che restituisce
         */
        //static void Main(string[] args)
        //{
        //    for (int i = 0; i < 2; i++)
        //    {
        //        int[] numbers = GetNumbersArray();
        //        for (int j = 0; j < numbers.Length; j++)
        //            Console.WriteLine(numbers[j]);
        //    }
        //}
        //static int[] GetNumbersArray()
        //{
        //    Random random = new Random();
        //    int dimension = random.Next(5, 20);
        //    int[] numbers = new int[dimension];
        //    for (int i = 0; i < dimension; i++)
        //        numbers[i] = random.Next();
        //    return numbers;
        //}
        //static void Main(string[] args)
        //{
        //    int dimensione = 3;
        //    int[] numeri = new int[dimensione];
        //    numeri[0] = 12;
        //    numeri[1] = 2;
        //    numeri[2] = 10;

        //    string[] stringhe = new string[dimensione];
        //    stringhe[0] = "stringa1";
        //    stringhe[1] = "stringa2";
        //    stringhe[2] = "stringa3";

        //    for (int i = 0; i < dimensione; i++)
        //    {
        //        Console.WriteLine(numeri[i]);
        //        Console.WriteLine(stringhe[i]);
        //    }
        //}
    }
}
