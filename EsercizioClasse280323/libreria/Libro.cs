using System;
using System.Collections.Generic;
using System.Text;

namespace EsercizioClasse280323.libreria
{
    public class Libro :Prodotto
    {
        public int NumeroDiPagine { get; set; } 
        public override void StampaProdotti()
        {
            Console.WriteLine("Libro : " + this.Name + " - " + this.Author);
            Console.WriteLine("Numero pagine: " + this.NumeroDiPagine);
        }
    }
}
