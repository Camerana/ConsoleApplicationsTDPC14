using ConsoleApplicationsTDPC14.Prodotti;
using System;

namespace ConsoleApplicationsTDPC14
{
    public class Program
    {
        static void Main(string[] args)
        {
            Prodotto prodotto = new Prodotto();
            prodotto.Nome = "Prodotto";
            prodotto.Costo = "12";
            prodotto.Stampa();

            Biscotto biscotto = new Biscotto();
            biscotto.Nome = "Biscotto";
            biscotto.Costo = "3";
            biscotto.Stampa();

            Patatine patatine = new Patatine();
            patatine.Nome = "Patatine";
            patatine.Costo = "4";
            patatine.Salinita = 2;
            patatine.Stampa();

            SanCarlo sanCarlo = new SanCarlo();
            sanCarlo.Nome = "SanCarlo";
            sanCarlo.Costo = "2";
            sanCarlo.Salinita = 1;
            sanCarlo.Stampa();

            Pringles pringles = new Pringles();
            pringles.Nome = "Pringles";
            pringles.Costo = "2";
            pringles.Salinita = 2;
            pringles.AltezzaCilindro = 4;
            pringles.Stampa();
        }
    }
}