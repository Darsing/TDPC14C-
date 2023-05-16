using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ripasso12052023
{
    class Prodotto
    {
        string nome;
        public double Costo { get; set;}
        
        public string Nome
        {
            get
            {
                return this.nome;
            }
            set
            {
                if (value.Length > 5)
                {
                    this.nome = value;
                }
                
            }
        }
    }
   
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Prodotto p = new Prodotto();    
            Console.WriteLine("nome di un prodotto");
            p.Nome=Console.ReadLine();
            Console.WriteLine("costo del prodotto");
            p.Costo=int.Parse(Console.ReadLine());
            
            Console.WriteLine(p.Nome+ " "+p.Costo);
           
        }

        
    }
}
