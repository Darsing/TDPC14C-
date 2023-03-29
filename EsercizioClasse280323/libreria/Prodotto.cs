using System;
using System.Collections.Generic;
using System.Text;

namespace EsercizioClasse280323.libreria
{
    public abstract  class Prodotto 
    {
        public string Author { get; set; }
        public string Name { get; set; }
        public int Anno { get; set; }

        public abstract void StampaProdotti();
    }
}
