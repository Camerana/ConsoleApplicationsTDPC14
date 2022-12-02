using System;

namespace ConsoleApplicationsTDPC14
{
    internal class Program
    {
        /*
         scrivere un programma che:
            - chieda all'utente come si chiama
            - chieda all'utente quanti anni ha
            - stampi su schermo il nome dell'utente
            - stampu su schermo l'età dell'utente
         */
        static void Main(string[] args)
        {
            //garbage collector
            Console.WriteLine("Come ti chiami ?");
            string nome = Console.ReadLine();
            Console.WriteLine("Quanti anni hai ?");
            string eta = Console.ReadLine();
            Console.WriteLine("Ti chiami: " + nome);
            Console.WriteLine("Hai " + eta + " anni");
        }
    }
}
