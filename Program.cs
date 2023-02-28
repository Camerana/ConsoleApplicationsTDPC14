using System;
using System.Collections.Generic;

namespace ConsoleApplicationsTDPC14
{
    internal class Program
    {
        /*
         - creare 100 oggetti che rappresentino
         prodotti diversi con caratteristiche:
            - nome
            - costo
            - produttore
            - numero
         */
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            for (int i = 0; i < 100; i++)
            {
                Product product = new Product();
                product.Name = "nome " + i;
                product.Manufacturer = "manufacturer " + i;
                product.Cost = i;
                product.Number = i * 10;

                products.Add(product);
            }
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine(products[i].Name + " " + products[i].Cost);
                Console.WriteLine(products[i].Manufacturer + " " + products[i].Number);
                Console.WriteLine("-------------------------------");
            }
        }
    }
}
