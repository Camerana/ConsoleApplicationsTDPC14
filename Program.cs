using System;
using System.Collections.Generic;

namespace ConsoleApplicationsTDPC14
{
    internal class Program
    {
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
