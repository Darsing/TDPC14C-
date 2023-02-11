using System;

namespace EsercitazioneTDPC030223
{
    internal class Program
    {
        /*
       creare due funzioni con queste caratteristiche:
          1)- accetti in ingresso una stringa e un numero intero
            - stampi la concatenazione della stringa e del numero
            - stampi il numero al quadrato
          2)- accetti in ingresso due booleani
            - stampi su schermo se entrambi i booleani sono true
       */
        static void StampaStringNumber(string s, int n)
        {
            Console.WriteLine($"Ciao ti chiami {s} e hai inserito questo numero {n}");
            Console.WriteLine($"IL quadrato di {n} è : {n*2}");
        }

        static void StringNumber()
        {
            Console.Write("Inserisci tuo nome : ");
            string s = Console.ReadLine();
            Console.Write("Inserisci un numero : ");
            int n = int.Parse(Console.ReadLine());
            StampaStringNumber(s, n);
            
        }
        static void BoolFunzione(bool b, bool c) 
        {
            
           
        }

        /*
         - tramite una funzione generare 3 numeri casuali compresi
            tra 0 e 10
         - tramite una seconda funzione stampare su schermo la somma
         e il prodotto dei tre numeri
         */
         static void GenerareNumeri()
        {
            int numLenght = 3;
            Random r = new Random();
            for(int i = 0; i < numLenght; i++)
            {
                int number = r.Next(0, 10);    
                Console.WriteLine(number);    
            }
            
        }

        static void StampaNumeriGenerato()
        {
           


        }




        static void Main(string[] args)
        {
            bool b = false;
            bool c = true;
            //StringNumber();
            //BoolFunzione(b,c);
           // GenerareNumeri();



        }
    }
}
