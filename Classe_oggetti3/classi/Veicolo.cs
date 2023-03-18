using System;
using System.Collections.Generic;
using System.Text;

namespace Classe_oggetti3.classi
{
    internal class Veicolo
    {
        
        public string Model { get; set; }
        public string Plate { get; set; }
        public int MaxSpeed { get; set; }

        public void Start()
        {
            Console.WriteLine("la macchina : "+Model 
                + "di targa : "+Plate+" potenza : "+ MaxSpeed);
        }
        public void Stop()
        {
            if(MaxSpeed > 0)
            {
                Console.WriteLine("macchina molto potenta");
            }

        }
    }
}
