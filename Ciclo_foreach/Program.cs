using System;
using System.Collections.Generic;
using System.Linq;

namespace Ciclo_foreach
{
    internal class Program
    {
        /*
         - chiedere all'utente 3 stringhe
         - inserire le stringhe in una lista
         - passare la lista a una funzione
         - tramite la funzione, con un foreach, stampare
            il contenuto della lista
         */
        /*
        static void GetLista(List<string> lista)
        {
            foreach (string str in lista)
            {
                Console.WriteLine(str);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Inserisce la prima stringa : ");
            string s1 = Console.ReadLine();
            Console.Write("Inserisce la seconda stringa : ");
            string s2 = Console.ReadLine();
            Console.Write("Inserisce la terza stringa : ");
            string s3 = Console.ReadLine();

            List<string> listStringhe = new List<string>();
            listStringhe.Add(s1);
            listStringhe.Add(s2);
            listStringhe.Add(s3);

            GetLista(listStringhe);
            
        }
        */

        /*
         - chiedere all'utente un booleano
         - se il booleano è true, generare 4 numeri casuali,
            inserirli in un array e stampare il contenuto
            dell'array tramite un foreach
         - se il booleano è false, chiedere all'utente 2 stringhe,
            inserirle in una lista e stampare il contenuto
            della lista tramite un for
         */

        /*
        static void Main(string[] args)
        {
            bool t = true;
            bool f = false;
            int dimensione = 4;
            Random random= new Random();
            int[] arr= new int[dimensione];
            List<string> list = new List<string>();
            Console.Write($"inserisci tra {t} e {f} :");
            string input = Console.ReadLine();
            bool reponse= Convert.ToBoolean( input );   

            if (reponse ==t)
            {

                for(int i=0;i<dimensione;i++)
                {
                    arr[i] = random.Next(50);
                    Console.WriteLine(arr[i]);
                }   
            }
            else
            {
                Console.Write("inserisci la prima stringa :");
                string s1= Console.ReadLine();
                Console.Write("inserisci la seconda stringa :");
                string s2 = Console.ReadLine();
                list.Add(s1);
                list.Add(s2);
                foreach(string s in list)
                {
                    Console.WriteLine(s);
                }
            }

        }
        */

        /*
         - creare un array di contenuto arbitrario
         - creare una lista di contenuto arbitrario
         - creare una lista il cui contenuto sia l'unione di quelli
            dell'array e della prima lista
         - tramite un foreach stampare il contenuto della seconda
            lista
         */

        /*
        static void Main(string[] args)
        {
            string[] nomi = new string[]
            {
                "james",
                "lucas",
                "thomaso",
                "alice",
                "isabel",
                "chiara"
            };

            List<string> liste = new List<string>()
            {
                "Milano",
                "Torino",
                "Roma",
                "Firenze",
                "Napoli",
                "Genova"
            };

            List<string> stringheUnion = nomi.Concat(liste).ToList();   
            foreach (string stringhe in stringheUnion)
            {
                Console.WriteLine(stringhe);
            }

        }
        */

        /*
         - chiedere all'utente un numero
         - tramite un ciclo stampare tutti i numeri da 0 fino al numero
            scelto dall'utente
        */

        /*
        static void Main(string[] args)
        {
            Console.Write("Inserisci un numero");
            int n = int.Parse(Console.ReadLine());

            if(n>=0)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                for (int i = 0; n<i; i--)
                {
                    Console.WriteLine(i);
                }
            }
            
        }
        */

        /*
         - chiedere all'utente un numero
         - generare un numero di stringhe pari al numero
            scelto dall'utente
         - tramite un foreach stampare le stringhe al contrario
         */

        static void Main(string[] args)
        {
            Console.WriteLine("numero");
            int input =int.Parse(Console.ReadLine());

            string[] s = new string[input];
            List<string>list= new List<string>();
            for(int i=0;i<s.Length;i++)
            {
                s[i] = "stringa " + i;
                Console.WriteLine(s[i]);
                list.Add(s[i]);
            }
            foreach(string l in list)
            {
                string r = string.Join(" ", l.Reverse());
                Console.WriteLine(r);    
            }
        }
        /*
        static void Main(string[] args)
        {
            Console.Write("Inserisci un numero ");
            int numero = int.Parse(Console.ReadLine());

            string[] strings= new string[numero];
            for(int i=0;i<strings.Length;i++)
            {
                strings[i] = "stringa  " + i;
                Console.WriteLine(strings[i]);
            }

            var charsInput1 = strings.Reverse();
               for (int i = 0; i < charsInput1.Count(); i++)
                Console.Write(charsInput1.ElementAt(i));
            
        }
        
        */
        /*
        - chiedere all'utente una stringa
        - stampare ciascun carattere della stringa
           separandoli con uno spazio vuoto
           - es:
               "stringa"
               "s t r i n g a"
        */
        /*
        static void Main(string[] args)
        {
            Console.Write("inserisci una stringa ");
            string input = Console.ReadLine();

            var risult = string.Join(" ",input.ToCharArray());
            Console.WriteLine(risult);
        }
        */
    }
}
