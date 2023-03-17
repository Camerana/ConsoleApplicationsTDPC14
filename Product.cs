using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplicationsTDPC14
{
    public class Product
    {
        public string Name { get; set; }
        public string Cost { get; set; }
        public void PrintData()
        {
            Console.WriteLine(this.Name + ": " + this.Cost);
        }
    }
}
