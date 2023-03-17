using System;

namespace ConsoleApplicationsTDPC14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "questo è l'input";
            string word = "l'input";

            //Utilities u = new Utilities();
            //u.StringContainsText(input, word);
            bool contains = Utilities.StringContainsText(input, word);
            int lenght = Utilities.GetStringLength(input);

            Product product = new Product();
            product.Name = "Acqua";
            product.Cost = "1.5";
            product.PrintData();

            Product product1 = new Product();
            product1.Name = "Biscotti";
            product1.Cost = "2";
            product1.PrintData();

            Product product2 = new Product();
            product2.Name = "Panino";
            product2.Cost = "3";
            product2.PrintData();
            //Product.PrintData();
            //product.ObjectsCount = 10;
            //Product.ObjectsCount = 10;
        }
    }
}
