using System;
using System.Collections.Generic;
using System.Text;

namespace Classe_oggetti3
{
    internal class Distributore
    {
        public string Nome { get; set; }
        public float Costo { get; set; }

        //public Distributore(string nome, float costo)
        //{
        //    this.Nome = nome;
        //    this.Costo = costo;
        //}

        public virtual void Stampa()
        {
            Console.WriteLine("Nome del distributore: "+ this.Nome +", il costo: " +this.Costo+ " £");
        }
    }
}
