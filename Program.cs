using System;

namespace ConsoleApplicationsTDPC14
{
    internal class Program
    {
        /*creare una classe Animale con
            - properties:
                - Razza
                - Colore
            - metodi:
                - Mangia
                - Fai il verso
          - creare 3 oggetti di tipo Animale,
            popolarne le properties e invocarne
            i metodi
         */
        static void Main(string[] args)
        {
            Animale a1 = new Animale();
            a1.Razza = "Coniglio";
            a1.Colore = "Bianco";
            a1.Mangia();
            a1.FaiIlVerso();

            Animale a2 = new Animale();
            a2.Razza = "Gatto";
            a2.Colore = "Arancione";
            a2.Mangia();
            a2.FaiIlVerso();

            Animale a3 = new Animale();
            a3.Razza = "Elefante";
            a3.Colore = "Grigio";
            a3.Mangia();
            a3.FaiIlVerso();

        }
        /*
         - creare una classe Veicolo con:
            - properties:
                - Model
                - Plate
                - MaxSpeed
            - metodi con contenuto arbitrario:
                - Start
                - Stop
         - creare 2 oggetti di tipo Veicolo
         - valorizzare le properties dei due oggetti e
         invocarne i metodi         
         */
        //static void Main(string[] args)
        //{
        //    Veicolo v1 = new Veicolo();
        //    v1.Model = "Panda";
        //    v1.Plate = "FG546TH";
        //    v1.MaxSpeed = 100;

        //    Veicolo v2 = new Veicolo();
        //    v2.Model = "500";
        //    v2.Plate = "GH451ZY";
        //    v2.MaxSpeed = 90;

        //    v1.Start();
        //    v1.Stop();

        //    v2.Start();
        //    v2.Stop();
        //}
        //static void Main(string[] args)
        //{
        //    string input = "questo è l'input";
        //    string word = "l'input";

        //    //Utilities u = new Utilities();
        //    //u.StringContainsText(input, word);
        //    bool contains = Utilities.StringContainsText(input, word);
        //    int lenght = Utilities.GetStringLength(input);

        //    Product product = new Product();
        //    product.Name = "Acqua";
        //    product.Cost = "1.5";
        //    product.PrintData();

        //    Product product1 = new Product();
        //    product1.Name = "Biscotti";
        //    product1.Cost = "2";
        //    product1.PrintData();

        //    Product product2 = new Product();
        //    product2.Name = "Panino";
        //    product2.Cost = "3";
        //    product2.PrintData();
        //    //Product.PrintData();
        //    //product.ObjectsCount = 10;
        //    //Product.ObjectsCount = 10;
        //}
    }
}
