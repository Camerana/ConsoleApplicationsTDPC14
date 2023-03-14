using System;
using System.Runtime.CompilerServices;

namespace ConsoleApplicationsTDPC14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User u = new User();
            u.Name = "Test";
            Console.WriteLine(u.Name);
        }
    }
}
