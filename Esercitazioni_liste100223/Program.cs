using System;
using System.Collections.Generic;
using System.Linq;

namespace Esercitazioni_liste100223
{
    internal class Program
    {
        /*
         - creare un array di numeri casuali
         - creare un secondo array di numeri casuali
         - creare una lista di numeri il cui contenuto sia
         l'unione degli elementi dei due array
         */
        /*
        static void Main(string[] args)
        {
            int dimensione = 4;    
            int[] n1 = new int[dimensione];
            int[] n2 = new int[dimensione];
            Random random= new Random();
            for(int i=0;i<dimensione; i++)
            {
                n1[i] = random.Next(0, 50);
                n2[i] = random.Next(0, 50);
            }
            List<int> listN = new List<int>();
            for (int i = 0; i < dimensione; i++)
            {
                listN.Add(n1[i]);
            }
            for (int i = 0; i < dimensione; i++)
            {
                listN.Add(n2[i]);
            }

            for(int i=0; i<listN.Count; i++)
            {
                Console.WriteLine(listN[i]);
            }
            Console.WriteLine();
            //metodo concat
            List<int> listNumeri = new List<int>(n1.Concat(n2));

            //metodo concat e tolist
            List<int> listNum = n1.Concat(n2).ToList();
        }
        */
        /*
         - creare un array di stringhe arbitrarie
         - tramite un ciclo popolare una lista di stringhe
         con tutti gli elementi contenuti nell'array
         - tramite un secondo ciclo stampare il contenuto
         sia dell'array che della lista
         */
        /*
        static void Main(string[] args)
        {
            string[] s = new string[] {"stringa 1", "stringa 2", "stringa 3"};
            List<string> list = new List<string>(); 
            for(int i=0;i<s.Length;i++)
            {
                list.Add(s[i]); 
            }

            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine("list : " + list[i]);
                Console.WriteLine("array : " + s[i]);
            }
        }
        */
        /*
        - tramite una funzione restituire un array di stringhe qualsiasi
        - tramite una seconda funzione restituire una lista di numeri decimali
        qualsiasi
        - chiamare entrambe le funzioni nel Main e stampare gli elementi
        delle collection restituite
        */

        /*
        static string[] GetString()
        {
            return new string[]
            {
               "Mango",
               "Papaya",
               "Mela", 
               "Pera",
               "Banana"
            };
        }
        static List<double> GetDouble()
        {
             return new List<double>()
            {
               23.45, 34, 46.90, 27
            };
        }
        static void Main(string[] args)
        {
           string[] str = GetString();
           List<double> doubles = GetDouble();
            for(int i=0;i<str.Length;i++)
            {
                Console.WriteLine(str[i]);  
            }

            for (int i = 0; i < doubles.Count; i++)
            {
                Console.WriteLine(doubles[i]);
            }
        }
        */

        /*
         - chiedere all'utente un numero qualsiasi
         - ciclare sul numero dell'utente e ad ogni iterazione
         aggiungere una stringa in un array
         - chidere all'utente un secondo numero
         - aggiungere in una lista un numero di elementi
         presi dall'array pari al secondo numero indicato dall'utente
         */

        /*
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci un numero qualsiasi");
            int dimensione = int.Parse(Console.ReadLine());
            string[] s = new string[dimensione];
            for(int i =0;i<dimensione;i++) 
            {
                s[i] = "stringa " + i;
            }

            Console.WriteLine("inserisci un secondo numero ");
            int elementNumbers = int.Parse(Console.ReadLine());  
            
            if(elementNumbers <= s.Length)
            {
                List<string> listString = new List<string>();
                for (int i = 0; i < elementNumbers; i++)
                {
                    listString.Add(s[i]);
                }
                for(int i = 0; i < listString.Count; i++)
                {
                    Console.WriteLine(listString[i]);   
                }
            }
            else
            {
                Console.WriteLine("array non contiene "+ elementNumbers+ 
                    " elementi");
            }
            
        }
        */
        static void Main(string[] args)
        {
            Console.WriteLine("inserisci un numero");
            string inputString = Console.ReadLine();    
            int input =0;
            bool r = int.TryParse(inputString, out input);
        }
    }
}
