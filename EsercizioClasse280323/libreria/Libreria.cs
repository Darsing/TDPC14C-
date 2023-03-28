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
            foreach(var scaffalo in this.scaffali)
            {
                Console.WriteLine("Categoria "+ scaffalo.Categori+ "Il tipo è un "+scaffalo.Prodotto);
            }
        }
    }
}
