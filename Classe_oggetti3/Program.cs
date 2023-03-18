using Classe_oggetti3.classi;
using System;
using System.Collections.Generic;

namespace Classe_oggetti3
{
    internal class Program
    {
        /*
         * Aggiornamento alle 20.00
         - creare una classe Veicolo con:
            - properties:
                - Model
                - Plate
                - MaxSpeed
            - metodi con contenuto arbitrario:
                - Start
                - Stop
         - creare 2 oggetti di tipo Veicolo
         - valorizzare le properties dei due oggetti e
         invocarne i metodi         
         */

        /*
        static void Main(string[] args)
        {
            Veicolo v1= new Veicolo();
            v1.Model = "Panda";
            v1.Plate = "DJ56XA";
            v1.MaxSpeed = 150;

            Veicolo v2 = new Veicolo();
            v2.Model = "Ford";
            v2.Plate = "LE59MA";
            v2.MaxSpeed = 180;

            v1.Start();
            v2.Start();
            v1.Stop();
        }
        */

        /*creare una classe Animale con
            - properties:
                - Razza
                - Colore
            - metodi:
                - Mangia
                - Fai il verso
          - creare 3 oggetti di tipo Animale,
            popolarne le properties e invocarne
            i metodi
         */
        /*
        static void Main(string[] args)
        {
            Animale a1 = new Animale();
            a1.Razza = "Gatto";
            a1.Nutrizione = "carne";
            a1.Colore = "Bianco";

            Animale a2 = new Animale();
            a2.Razza = "Carne";
            a2.Nutrizione = "cane";
            a2.Colore = "Nero";

            Animale a3 = new Animale();
            a3.Razza = "Mucca";
            a3.Nutrizione = "erba";
            a3.Colore = "Belgio";

            a1.Mangia();
            a1.FaiIlVerso();
            a2.Mangia();
            a2.FaiIlVerso();
            a3.Mangia();
            a3.FaiIlVerso();
        }
        */

        /*
         aggiornamento: 21.30
         -creare:
            - una classe Prodotto con:
                - properties:
                    - nome
                    - costo
            - una classe Distributore con:
                - properties:
                    - lista di oggetti di tipo Prodotto
                - metodi:
                    - Stampa, che stampa su schermo l'elenco
                    dei prodotti nella lista
        - istanziare un oggetto di tipo Distributore 
        - istanziare 3 oggetti di tipo Prodotto e valorizzarne
        le properties
        - aggiungere i 3 oggetti alla lista di prodotti di Distrubutore
        - stampare su schermo gli oggetti tramite il metodo Stampa
        di Distrubutore
        */
        static void Main(string[] args)
        {
            //List<Distributore> distributores= new List<Distributore>()
            //{
            //     new Distributore("MDSN",20),
            //     new Prodotto("uva",2f),
            //     new Prodotto("mela", 1f),
            //     new Prodotto("pera", 2.5f)
            //};

            List<Distributore> distributores = new List<Distributore>()
            {
                new Distributore(){Nome="BNVC",Costo=30f},
                new Prodotto(){Nome="patatina",Costo=1.9f},
                new Prodotto(){Nome="panino",Costo=3.5f},
                new Prodotto(){Nome="succo",Costo=1.5f},
            };
            foreach (Distributore distributore in distributores)
            {
                distributore.Stampa();
            }
        }

        
    }
}
