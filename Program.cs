using System;

namespace ConsoleApplicationsTDPC14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 50; i++)
            {
                for (int j = 0; j < 50; j++)
                {
                    for (int k = 0; k < 50; k++)
                    {
                        Console.WriteLine("i) " + i + " j) " + j + " k) " + k);
                        //vedo i, j e k
                    }
                    //vedo i e j
                }
                //vedo i
            }
        }

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
