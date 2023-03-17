using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplicationsTDPC14
{
    //classe normale
    public class Product
    {
        //field statico
        private static int ObjectsCount = 0;

        //property normale
        public string Name { get; set; }
        //property normale
        public string Cost { get; set; }
        
        //costruttore
        public Product()
        {
            Product.ObjectsCount++;
        }

        //metodo normale
        public void PrintData()
        {
            Console.WriteLine(this.Name + ": " + this.Cost);
        }
    }
}
