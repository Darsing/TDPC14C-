using EserciziLotteria210323.classi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace EserciziLotteria210323
{
    internal  class Program
    {
        
        static void Main(string[] args)
        {
            Gatto g = new Gatto() { Nome= "gattina"};
            g.FaiIlVerso();
            g.FaiLeFusa();

            Cane c = new Cane() { Nome = "bob" };
            c.FaiIlVerso();
            c.RiportaLaPalla();

            Bassotto b = new Bassotto() { Nome="Bassotto", Altezza= 1};
            b.FaiIlVerso();
            b.RiportaLaPalla();

            Dalmata d = new Dalmata() { Nome="Dalmata", NumeroMacchie=5};
            d.FaiIlVerso();
            d.RiportaLaPalla();
            
        }

        

    }
}
