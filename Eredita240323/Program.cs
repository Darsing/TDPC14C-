using Eredita240323.classeMadre;
using Eredita240323.classi;
using System;
using System.Collections.Generic;

namespace Eredita240323
{
    internal class Program
    {
        /* aggiornamento alle 7.40
         creare una classe EssereVivente con
            properties:
                - specie
                - nome
            metodi:
                - nutriti
         creare una classe Vertebrato : EssereVivente con:
            - metodi:
                - nutriti
                - muoviti
         creare una classe Pianta : EssereVivente con:
            - properties:
                - profondità radici
            - metodi:
                - nutriti
         - istanziare due oggetti di tipo Vertebrato e due di tipo Pianta,
         valorizzarne le properties e invocarne i metodi
         */

        /*
        static void Main(string[] args)
        {
            List<Vertebrato> vertebrati = new List<Vertebrato>()
            {
                new Vertebrato() {Specie= "Mamifero", Nome="Mucca"},
                new Vertebrato() {Specie= "Cane", Nome="Bob"}
            };

            foreach(Vertebrato v in vertebrati)
            {
                v.Nutriti();
                v.Muoviti();
            }
            Console.WriteLine();

            List<Pianta> pianti = new List<Pianta>()
            {
                new Pianta() {Specie="Calama", Nome="Basilico",ProfonditaRadice=40},
                new Pianta() {Specie="Hedera helix", Nome="Edera",ProfonditaRadice=70}
            };

            foreach (Pianta p in pianti)
            {
                p.Nutriti();
            }
        }
        */

        /*aggiornamento alle 21.15
         Creare una classe madre arbitraria con:
            - una property public
            - una property protected
            - una property private
            - un metodo public
            - un metodo protected
            - un metodo private
         Creare una classe figlia arbitraria che eredita dalla classe madre con:
            - una property private
            - un metodo private
         Creare una classe nipote arbitraria che eredita dalla classe figlia con:
            - una property public
         Istanziare:
            - un oggetto di tipo classe madre
            - un oggetto di tipo classe figlia
            - un oggetto di tipo classe nipote
         Valorizzare le properties degli oggetti
         Eseguirne i metodi
         */
        static void Main(string[] args)
        {
            Madre m = new Madre();
            m.Nome = "Carelle";
            m.StampaPublic();

            Figlia f = new Figlia();
            f.Nome = "Lewis";
            f.StampaPublic();

            Nipote n =new Nipote();
            n.Nome = "James";
            n.ColorePreferito = "rosso";
            n.NipoteMethod();
        }
    }
}
