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
        //static void Main(string[] args)
        //{
        //    //garbage collector
        //    Console.WriteLine("Come ti chiami ?");
        //    string nome = Console.ReadLine();
        //    Console.WriteLine("Quanti anni hai ?");
        //    string eta = Console.ReadLine();
        //    Console.WriteLine("Ti chiami: " + nome);
        //    Console.WriteLine("Hai " + eta + " anni");
        //}
        /*
         scrivere un programma che:
            - generi un numero casuale
            - lo stampi su console
                 - successivamente:
                    - generi un secondo numero casuale
                    - lo sommi al primo
                    - ne stampi su schermo il risultato
         */
        //static void Main(string[] args)
        //{
        //    Random random = new Random();
        //    int randomNumber1 = random.Next();
        //    Console.WriteLine(randomNumber1);

        //    int randomNumber2 = random.Next();
        //    int somma = randomNumber1 + randomNumber2;
        //    Console.WriteLine(somma);
        //}
        /*
         - chiedere all'utente come si chiama
         - chiedere all'utente quanti anni ha
         - stampare su schermo i dati dell'utente
         - chiedere all'utente due numeri
         - stampare su schermo la somma dei due numeri
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Come ti chiami ?");
            string nome = Console.ReadLine();
            Console.WriteLine("Quanti anni hai ?");
            string eta = Console.ReadLine();
            Console.WriteLine("Ti chiami: " + nome + " e hai " + eta + " anni");
            Console.WriteLine("Inserisci il primo numero");
            string numero1 = Console.ReadLine();
            Console.WriteLine("Inserisci il secondo numero");
            string numero2 = Console.ReadLine();
            int somma = int.Parse(numero1) + int.Parse(numero2);
            Console.WriteLine(somma);
            Console.ReadKey();
        }
    }
}
