using System;

namespace ConsoleApplicationsTDPC14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringa = "questa è una stringa";

            string stringa2 = stringa.Substring(5);
            string stringa3 = stringa.Substring(5, 10);

            string stringa4 = stringa.Replace("questa", "quella");
            string stringa5 = stringa.ToUpperInvariant();
            string stringa6 = stringa.ToLowerInvariant();
            string stringa7 = stringa.Remove(5, 6);
            string[] parole = stringa.Split(' ');

            Console.WriteLine(stringa);
            //Console.WriteLine(stringa2);
            //Console.WriteLine(stringa3);
            //Console.WriteLine(stringa4);
            //Console.WriteLine(stringa5);
            //Console.WriteLine(stringa6);
            //Console.WriteLine(stringa7);
            //for (int i = 0; i < parole.Length; i++)
            //    Console.WriteLine(parole[i]);
            Console.ReadKey();
        }
    }
}
