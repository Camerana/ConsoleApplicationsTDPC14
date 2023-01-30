using System;

namespace ConsoleApplicationsTDPC14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Console.WriteLine("entro in print");
            Print();
            Console.WriteLine("sono uscito da print");
           
            GetValueString();
            string valueString = GetValueString();

            GetValueInt();
            int valueInt = GetValueInt();

            Console.WriteLine(valueString);
            Console.WriteLine(valueInt);
        }
        static void Print()
        {
            Console.WriteLine("sono Print");
        }
        static string GetValueString()
        {
            Console.WriteLine("sono GetValueString");
            return "value";
        }
        static int GetValueInt()
        {
            Console.WriteLine("sono GetValueInt");
            return 10;
        }
    }
}
