using System;

namespace ConsoleApplicationsTDPC14
{
    internal class Program
    {
        /*aggiornamento alle 19.30*/
        /*
         - chiedere all'utente 3 stringhe
         - stampare le 3 stringhe tutte in minuscolo e in maiuscolo
         - stampare i primi 3 caratteri di ciascuna stringa
            - attenzione alle stringhe di lunghezza minore di 3 caratteri
         */
        /*
         - generare un numero casuale compreso fra 1 e 10
         - data una lunghezza di 15 caratteri:
            - stampare la stringa a partire dall'indice corrispondente al numero
            generato
         - sostituire ogni occorrenza di un carattere a scelta nella stringa
         con "Y" e stampare il risultato su schermo
         */
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
