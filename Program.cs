﻿using System;

namespace ConsoleApplicationsTDPC14
{
    internal class Program
    {
        //macchinetta delle merendine
        /*
         simulare una macchinetta delle merendine:
         punti fondamentali:
            - scegliere n prodotti
            - scegliere un costo per ciascun prodotto
            - attribuire un credito n all'utente
            - chiedere all'utente cosa vuole comprare
            - valutare se l'utente ha abbastanza soldi
            - sottrarre l'importo dai soldi dell'utente
            - stampare su schermo l'esito dell'acquisto
         */
        static void Main(string[] args)
        {
            double credito = 5;
            string[] prodotti = new string[3];
            prodotti[0] = "patatine";
            prodotti[1] = "biscotti";
            prodotti[2] = "brioche";

            double[] costi = new double[3];
            costi[0] = 1.5;
            costi[1] = 2;
            costi[2] = 1;
            while (true)
            {
                Console.WriteLine("hai " + credito + " euro");

                Console.WriteLine("Cosa vuoi comprare ?");
                Console.WriteLine("Prodotti disponibili:");
                Console.WriteLine("1 = " + prodotti[0] + " " + costi[0]);
                Console.WriteLine("2 = " + prodotti[1] + " " + costi[1]);
                Console.WriteLine("3 = " + prodotti[2] + " " + costi[2]);

                int input = int.Parse(Console.ReadLine()) - 1;

                if (credito >= costi[input])
                {
                    credito = credito - costi[input];
                    Console.WriteLine("hai comprato " + prodotti[input]);
                    Console.WriteLine("ti restano: " + credito + " euro");
                }
                else
                {
                    Console.WriteLine("non hai abbastanza soldi");
                }
                Console.WriteLine();
            }
        }
    }
}
