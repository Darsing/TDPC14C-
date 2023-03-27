using System;
using System.Collections.Generic;
using System.Text;

namespace Eredita240323.classeMadre
{
    internal class Nipote : Figlia
    {
        public string ColorePreferito { get; set; }

        public void NipoteMethod()
        {
            Console.WriteLine("Nome " + this.Nome + " eta " + this.Age);
            Console.WriteLine("Il suo colore preferito è "+ this.ColorePreferito);
        }
    }
}
