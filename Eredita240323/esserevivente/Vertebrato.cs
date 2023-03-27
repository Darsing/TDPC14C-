using System;
using System.Collections.Generic;
using System.Text;

namespace Eredita240323.classi
{
    internal class Vertebrato : EssereVivente
    {

        public override void Nutriti()
        {
            base.Nutriti();
            Console.WriteLine(" Gli essere vivente  sono nutriti ");
        }

        public void Muoviti()
        {
            Console.WriteLine(" Gli essere vivente si muovono ");
        }
    }
}
