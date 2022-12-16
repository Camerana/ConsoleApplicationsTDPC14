using System;

namespace ConsoleApplicationsTDPC14
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("inserisci un numero");
        //    int numero = int.Parse(Console.ReadLine());
        //    if (numero == 5)
        //    {
        //        Console.WriteLine("il numero è uguale a 5");
        //    }
        //    else if (numero == 10)
        //    {
        //        Console.WriteLine("il numero è uguale a 10");
        //    }
        //    else if (numero == 15)
        //    {
        //        Console.WriteLine("il numero è uguale a 15");
        //    }
        //    else
        //    {
        //        Console.WriteLine("non so ancora");
        //    }
        //}
        /*        
          creare una variabile di tipo string con valore = [nome arbitrario]
         chiedere all'utente come si chiama 
         verificare se il nome dell'utente corrisponde al valore della variabile string
            in caso positivo stampare su schermo:
                - benvenuto [nome utente]
            in caso negativo stampare su schermo:
                - non ti conosco
         */
        //static void Main(string[] args)
        //{
        //    string nome = "giovanni";
        //    Console.WriteLine("Come ti chiami ?");
        //    string input = Console.ReadLine();
        //    if (input.ToLowerInvariant() == nome.ToLowerInvariant())
        //    {
        //        Console.WriteLine("benvenuto " + input);
        //    }
        //    else
        //    {
        //        Console.WriteLine("non ti conosco");
        //    }
        //}
        /*
         - generare 2 numeri casuali tra 1 e 10
         - se il primo numero è maggiore del secondo stampare su schermo:
            - il primo è maggiore del secondo
         - altrimenti stampare su schermo:
            - il secondo è maggiore del primo
         - chiedere all'utente un numero compreso tra 1 e 10
         - se l'utente indovina uno dei due numeri casuali stampare su schermo:
            - hai indovinato il numero: [numero indovinato]
         */
        //static void Main(string[] args)
        //{
        //    Random random = new Random();
        //    int numero1 = random.Next(0, 11);
        //    int numero2 = random.Next(0, 11);

        //    if (numero1 > numero2)
        //    {
        //        Console.WriteLine("il primo è maggiore del secondo");
        //    }
        //    else if (numero1 < numero2)
        //    {
        //        Console.WriteLine("il secondo è maggiore del primo");
        //    }
        //    else
        //    {
        //        Console.WriteLine("i numeri sono uguali");
        //    }
        //    Console.WriteLine("inserisci un numero tra 0 e 10");
        //    int numero3 = int.Parse(Console.ReadLine());
        //    //OR
        //    if (numero3 == numero1 || numero3 == numero2)
        //    {
        //        Console.WriteLine("hai indovinato il numero: " + numero3);
        //    }
        //}
        /*
         - creare due stringhe con nomi "username" e "password" con valori arbitrari
         - chiedere all'utente due input tramite i quali si deve loggare
         - verificare la validità degli input dell'utente
         - stampare su schermo se il login è riuscito o meno
         - consiglio: l'AND si scrive "&&"
         */
        //static void Main(string[] args)
        //{
        //    string username = "user";
        //    string password = "user123";
        //    Console.WriteLine("Inserisci il nome utente");
        //    string inputUsername = Console.ReadLine();
        //    Console.WriteLine("Inserisci la password");
        //    string inputPassword = Console.ReadLine();
        //    if (inputUsername.ToLowerInvariant() == username.ToLowerInvariant()
        //        && inputPassword == password)
        //    {
        //        Console.WriteLine("ti sei loggato");
        //    }
        //    else
        //    {
        //        Console.WriteLine("login fallito");
        //    }
        //}
        /*
         - generare un numero casuale compreso tra 1 e 5
         - chiedere all'utente un numero tra 1 e 10
         - confrontare il numero dell'utente con una variabile int di valore arbitrario
         e col numero casuale
         - nel caso il numero dell'utente sia maggiore di 3 e uguale al numero casuale o alla variabile
         stampare su schermo "hai vinto"
         */
        static void Main(string[] args)
        {
            Random random = new Random();
            int numeroCasuale = random.Next(1, 6);
            Console.WriteLine("inserisci un numero tra 1 e 10");
            int numeroUtente = int.Parse(Console.ReadLine());
            int numeroArbitrario = 4;
            if (numeroUtente > 3 && (numeroUtente == numeroCasuale || numeroUtente == numeroArbitrario))
            {
                Console.WriteLine("hai vinto");
            }
        }
    }
}
