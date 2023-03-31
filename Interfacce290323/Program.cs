using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Interfacce290323
{
    internal class Program
    {
        class Tabella :IAfficher
        {
            public int numero { get; set; } 
           public Tabella(int numero)
           {
              this.numero = numero; 
           }
            public void Afficher()
            {
                Console.WriteLine("Tabella di moltiplicazione : ");
                for(int i=0; i<10; i++)
                {
                    Console.WriteLine(" "+ i +" x "+this.numero+" = "+ (this.numero*i));
                }
            }
        }
        class Persone :IAfficher
        {
            public string Nome { get; set; }

            public void Afficher()
            {
                Console.WriteLine("Nome : "+ this.Nome);
            }
        }
        
        interface IAfficher
        {
            void Afficher();
        }

        static void Main(string[] args)
        {
          // Persone p = new Persone();
          //  p.Nome = "Paul";
          //  //AfficherElements(p);
          //  p.Afficher();

          //Tabella t = new Tabella(2);
          //  t.Afficher();   
          //  //AfficherElements(t);

            var elements = new List<IAfficher>()
            {
                new Persone(){Nome="Paule"},
                new Tabella(2)
            };

            foreach(var element in elements)
            {
                element.Afficher();
            }
        }
        //static void AfficherElements(IAfficher element)
        //{
        //    element.Afficher();
        //}
    }
}
