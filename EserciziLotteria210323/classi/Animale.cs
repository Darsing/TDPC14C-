using System;
using System.Collections.Generic;
using System.Text;

namespace EserciziLotteria210323.classi
{
    internal class Animale
    {
        
        public string Nome{ get; set; }
        public virtual void FaiIlVerso()
        {
            Console.WriteLine(this.Nome );
        }
    }

    internal class Gatto : Animale
    {
        public override void FaiIlVerso()
        {
            Console.WriteLine(this.Nome +" fa miaooo");
        }
        public void FaiLeFusa()
        {
            Console.WriteLine("Fai il fusa " + this.Nome);
        }
    }

    internal class Cane : Animale
    {
        public override void FaiIlVerso()
        {
            Console.WriteLine(this.Nome + " fa baubau");
        }
        public void RiportaLaPalla()
        {
            Console.WriteLine(this.Nome + " riporta la palla");
        }
    }

    internal class Bassotto: Cane
    {
        public int Altezza { get; set; }
        public override void FaiIlVerso()
        {
            base.FaiIlVerso();
            Console.WriteLine("La sua altezza " + this.Altezza + "cm");
        }

    }

    internal class Dalmata : Cane
    {
        public int NumeroMacchie { get; set; }
        public override void FaiIlVerso()
        {
            base.FaiIlVerso();
            Console.WriteLine("Hai  " + this.NumeroMacchie +" macchie");
        }

    }

}
