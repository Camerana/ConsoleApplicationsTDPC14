using System;

namespace ConsoleApplicationsTDPC14
{
    internal class Program
    {
        /*
         dichiarare 2 variabili di tipo stringa con valore arbitrario
         dichiarare 2 variabili di tipo numero intero con valore arbitrario
         stampare su schermo la "somma" delle due stringhe
         stampare su schermo la somma dei due numeri
         */
        //static void Main(string[] args)
        //{
        //    string stringa1 = "sono la stringa 1";
        //    string stringa2 = "sono la stringa 2";
        //    int numero1 = 10;
        //    int numero2 = 20;
        //    Console.WriteLine(stringa1 + stringa2);
        //    Console.WriteLine(numero1 + numero2);
        //    Console.ReadKey();
        //}
        /*
         chiedere all'utente:
            - nome
            - cognome
            - eta
            - numero di fratelli
            - numero di sorelle
            - stampare su schermo i dati anagrafici dell'utente
            - stampare su schermo la seguente frase:
                "hai [numeroFratelli] fratelli e [numeroSorelle] sorelle"
         */
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Inserisci il tuo nome");
        //    string nome = Console.ReadLine();
        //    Console.WriteLine("Inserisci il tuo cognome");
        //    string cognome = Console.ReadLine();
        //    Console.WriteLine("Inserisci la tua età");
        //    string eta = Console.ReadLine();

        //    Console.WriteLine("Inserisci quanti fratelli hai");
        //    string numeroFratelli = Console.ReadLine();
        //    Console.WriteLine("Inserisci quante sorelle hai");
        //    string numeroSorelle = Console.ReadLine();

        //    Console.WriteLine("Ti chiami: " + nome + " " + cognome + " e hai " + eta + " anni");
        //    Console.WriteLine("hai " + numeroFratelli + " fratelli e " + numeroSorelle + " sorelle");
        //}
        /*
         chiedere all'utente:
            - numero di fratelli
            - numero di sorelle
            - stampare su schermo la stringa:
                "in totale hai: [numero totale di fratelli + sorelle] fratelli"
         */
        //static void Main(string[] args)
        //{
        //    //Console.WriteLine("Quanti fratelli hai ?");
        //    //string numeroFratelli = Console.ReadLine();
        //    //Console.WriteLine("Quante sorelle hai ?");
        //    //string numeroSorelle = Console.ReadLine();
        //    //int somma = int.Parse(numeroFratelli) + int.Parse(numeroSorelle);
        //    //Console.WriteLine("in totale hai: " + somma + " fratelli");

        //    Console.WriteLine("Quanti fratelli hai ?");
        //    int numeroFratelli = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Quante sorelle hai ?");
        //    int numeroSorelle = int.Parse(Console.ReadLine());
        //    Console.WriteLine("in totale hai: " + (numeroFratelli + numeroSorelle) + " fratelli");
        //}
        /*chiedere all'utente 2 numeri:
            - stampare su schermo:
                - "numero1 + numero2" = numero1 + numero2
                - "numero1 - numero2" = numero1 - numero2
                - "numero1 * numero2" = numero1 * numero2
                - "numero1 / numero2" = numero1 / numero2
                - "(numero1 + numero2)/2" = (numero1 + numero2)/2
        */
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci il primo numero");
            double numero1 = double.Parse(Console.ReadLine());
            Console.WriteLine("inserisci il secondo numero");
            double numero2 = double.Parse(Console.ReadLine());
            Console.WriteLine(numero1 + " + " + numero2 + " = " + (numero1 + numero2));
            Console.WriteLine(numero1 + " - " + numero2 + " = " + (numero1 - numero2));
            Console.WriteLine(numero1 + " * " + numero2 + " = " + numero1 * numero2);
            Console.WriteLine(numero1 + " / " + numero2 + " = " + numero1 / numero2);
            Console.WriteLine("(" + numero1 + " + " + numero2 + ")/2" + " = " + (numero1 + numero2) / 2);
        }
    }
}