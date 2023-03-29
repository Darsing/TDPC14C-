using System;
using System.Collections.Generic;
using System.Text;

namespace EsercizioClasse280323.libreria
{
    public class CD :Prodotto
    {
        public double Durata { get; set; }

        public override void StampaProdotti()
        {
            Console.WriteLine("CD : "+this.Name +" - "+ this.Author);
            Console.WriteLine("Durata : "+ this.Durata+" min");
        }
    }
}
