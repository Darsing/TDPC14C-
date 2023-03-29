using System;
using System.Collections.Generic;
using System.Text;

namespace EsercizioClasse280323.libreria
{
    public class Libreria
    {
        public List<Scaffale> scaffali { get; set; }= new List<Scaffale>();

        public void Stampa()
        {
            foreach(Scaffale s in this.scaffali)
            {
                foreach(var i in s.prodotti)
                {
                    i.StampaProdotti();
                    Console.WriteLine();
                }
                
            }
        }

    }
}
