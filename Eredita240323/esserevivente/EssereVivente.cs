using System;
using System.Collections.Generic;
using System.Text;

namespace Eredita240323.classi
{
    internal class EssereVivente
    {
        public string Specie { get; set; }
        public string Nome { get; set; }

       
        public virtual void Nutriti()
        {
            Console.WriteLine(" La specie vivente "+ this.Specie+ " e di nome "+this.Nome);
        }
    }
}
