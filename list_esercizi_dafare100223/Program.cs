using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;

namespace list_esercizi_dafare100223
{
    internal class Program
    {
        /*
         - creare una funzione che accetti in ingresso una lista di stringhe
         e restituisca un array di stringhe contenente le stringhe della lista
         parsificabili in numero
         */

        /*
        static string[]  GetListaStringhe( List<string> stringhe)
        {
            string[] s = new string[stringhe.Count];
            for(int i = 0; i < s.Length; i++)
            {
                s[i] = stringhe[i];
                int r= int.Parse(s[i]);
                Console.WriteLine(r);
            }
            return s;
        }
        static void Main(string[] args)
        {
            List<string> stringhe = new List<string>()
            {
                "100",
                "20",
                "50",
                "70",
                "35"

            };
            string[] stringa = GetListaStringhe(stringhe);
           
        }
        */

        /*
         - creare una funzione che accetti due array di tipo a scelta
         e restituisca una lista che contenga gli elementi di entrambi
         gli array
         - chiamare da Main la funzione e stampare su schermo il contenuto
         della lista ottenuta
         */

        /*
        static List<string> GetString(string[]s1, string[]s2)
        {
            List<string> listArray = new List<string>(s1.Concat(s2));
           
            return listArray;
        }
        static void Main(string[] args)
        {
            string[] s1 = new string[]
            {
                "mango",
                "mela",
                "kiwi",
                "banana",
                "arancia"
            };
            string[] s2 = new string[]
            {
                "pomodoro",
                "sedano",
                "cipolla",
                "aglio"
            };


            List<string> risult =GetString(s1, s2);
            for(int i=0;i<risult.Count;i++)
            {
                Console.WriteLine(risult[i]);
            }

        }
        */

        /*
        - creare una funzione che in ingresso accetti un numero intero
       e restituisca una lista di stringhe con un numero di elementi 
       pari al numero in ingresso
        - chiedere all'utente 3 numeri
        - per ciascun numero chiamare la funzione descritta sopra
        - creare una lista di stringhe che contenga gli elementi
        delle altre liste create
        */
        static List<string> GetListString(int numeroIntero)
        {
            List<string> listStringhe = new List<string>()
            {
                "paolo",
                "luca",
                "marco",
                "alice",
                "dante",
                "rebecca",
                "james",
                "isabel",
                "justin",
                "manuel",
                "edoardo"
            }; 
            return listStringhe;    
        }

        static void Main(string[] args)
        {
            
            Console.Write("inserisci un numero intero: ");
            int numeroIntero= int.Parse(Console.ReadLine());
            List<string> r = GetListString(numeroIntero);
            if(numeroIntero <= r.Count)
            {
                for(int i=0;i<numeroIntero;i++)
                {
                    Console.WriteLine(r[i]);
                }
            }
            else
            {
                Console.WriteLine("il numero intero è maggiore ");
            }

            //chiedere 3 numeri
            Console.Write("inserisci il primo numero: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("inserisci il secondo numero: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.Write("inserisci il terzo numero: ");
            int n3 = int.Parse(Console.ReadLine());
            //chiama la funzione per 3 volte
            
            List<string> r1 = GetListString(n1);
            if (n1 <= r1.Count)
            {
                for (int i = 0; i < n1; i++)
                {
                    Console.WriteLine(r1[i]);
                }
            }

            List<string> r2 = GetListString(n2);
            if (n2 <= r2.Count)
            {
                for (int i = 0; i < n2; i++)
                {
                    Console.WriteLine(r2[i]);
                }
            }

            List<string> r3 = GetListString(n3);
            if (n3 <= r3.Count)
            {
                for (int i = 0; i < n3; i++)
                {
                    Console.WriteLine(r3[i]);
                }
            }

            //creare una lista che contiene gli elti degli altre liste
            List<string>elementListes = new List<string>();
            Console.WriteLine(elementListes);

            for(int i=0;i<elementListes.Count;i++)
            {
                
                elementListes.Add(r[i]);
                elementListes.Add(r1[i]);
                elementListes.Add(r2[i]);
                elementListes.Add(r3[i]);

                Console.WriteLine(elementListes[i]);
            }
        }





    }
}
