using System;
using System.Collections.Generic;
using System.Text;

namespace Eredita240323.classi
{
    internal class Pianta : EssereVivente
    {
        public int ProfonditaRadice { get; set; }

        public override void Nutriti()
        {
            base.Nutriti();
            Console.WriteLine("Profondità radice : "+ this.ProfonditaRadice);
            Console.WriteLine("La pianta ha bisogno dell'acqua e del sole ");
        }

    }
}
