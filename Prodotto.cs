using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplicationsTDPC14
{
    internal class Prodotto
    {
        private string nome;
        public string Nome
        {
            get
            {
                return this.nome;
            }
            set
            {
                if (value != null && value.Length > 5)
                    this.nome = value;
            }
        }
        public string Costo { get; set; }
    }
}
