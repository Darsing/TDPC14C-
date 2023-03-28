using System;
using System.Collections.Generic;
using System.Text;

namespace EsercizioClasse280323.libreria
{
    public class Scaffale 
    {
        public string Prodotto { get; set; }
        public string Categori { get; set; }
        public List<Libro> libri { get; set; }= new List<Libro>();

        public void StampaLibri()
        {
            foreach(Libro libro in this.libri)
            {
                Console.WriteLine(libro.Authore+ " - anno " +libro.Anno);
               
            }

        }

        
    }
}
