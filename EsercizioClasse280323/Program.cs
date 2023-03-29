using EsercizioClasse280323.libreria;
using System;
using System.Collections.Generic;

namespace EsercizioClasse280323
{
    internal class Program
    {
        /*
         simulare una libreria.
            es: classe Libreria con all'interno una collection di Scaffali..
                classe Scaffale con all'interno una collection di Libri..
                classe Libro con properties Autore, Anno..
         una volta definite le classi instanziare un oggetto di tipo Libreria
         con n oggetti al suo interno
         */
        static void Main(string[] args)
        {
            
            
            Libreria libreria =new Libreria();
            Scaffale scaffale = new Scaffale();
            for (int i=0;i<30;i++)
            {
               Libro libro= new Libro();
                libro.Author="Harry " + i;
                libro.Anno = 1990 + i;
                libro.NumeroDiPagine = 150;
                libro.Name = "Adventur";
                scaffale.prodotti.Add(libro);

                CD cd = new CD();
                cd.Author = "Jachson";
                cd.Anno = 1980 + i;
                cd.Durata = 105;
                cd.Name = "Tony";
                scaffale.prodotti.Add(cd);

            }
            
            libreria.scaffali.Add(scaffale);
            libreria.Stampa();
           
            
           
            

        }
    }
}
