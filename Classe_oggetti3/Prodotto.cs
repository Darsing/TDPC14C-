using System;
using System.Collections.Generic;
using System.Text;

namespace Classe_oggetti3
{
    internal class Prodotto : Distributore
    {
        //public Prodotto(string Nome, float Costo): base(Nome, Costo)
        //{

        //}

        public override void Stampa()
        {
            Console.WriteLine("Nome del prodotto: " + this.Nome + ", il costo: " + this.Costo + " £");
        }
    }


}
