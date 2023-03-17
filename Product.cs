using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplicationsTDPC14
{
    public class Product
    {
        private static int ObjectsCount = 0;
        public string Name { get; set; }
        public string Cost { get; set; }
        public Product()
        {
            Product.ObjectsCount++;
        }
        public void PrintData()
        {
            Console.WriteLine(this.Name + ": " + this.Cost);
        }
    }
}
