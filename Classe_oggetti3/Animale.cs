using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Classe_oggetti3
{
    internal class Animale
    {
        public string Razza { get; set; }
        public string Colore { get; set; }
        public string Nutrizione { get; set; }
        

        public void Mangia()
        {
            Console.WriteLine(this.Razza + " mangia " + this.Nutrizione);
            Console.WriteLine("Sono di colore : "+ this.Colore);
        }

        public void FaiIlVerso()
        {
            if(Razza == "Gatto")
            {
                Console.WriteLine("il suo verso è : miaoo");
            }
            if (Razza == "Cane")
            {
                Console.WriteLine("il suo verso é : baubo");
            }
            if (Razza == "Mucca")
            {
                Console.WriteLine("il suo verso é : muoo");
            }
        }
    }
}
