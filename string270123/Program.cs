using System;
using System.IO;
using System.Runtime.Intrinsics.X86;

namespace string270123
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            /* 
             string stringa = "questa è una stringa";

             string stringa2 = stringa.Substring(5);
             // string stringa3 = stringa.Substring(5,10);

             string stringa4 = stringa.Replace("questa", "quella");
             string stinga5= stringa.ToUpperInvariant();
             string stinga6 = stringa.ToLowerInvariant();
             string stinga7 = stringa.Remove(5);
             string[] parole = stringa.Split(' ');
             bool contains = stringa.Contains("stringa");
             bool startsWith = stringa.StartsWith("questa");
             bool endsWith = stringa.EndsWith("stringa");


             Console.WriteLine(stringa);
             Console.WriteLine(stringa4);
             Console.WriteLine(contains);
             //il for per fare il split
             for(int i=0;i<parole.Length;i++)
             {
                 Console.WriteLine(parole[i]);
             }

             */
            //esempio1
            /*
             -chiedere all' utente 3 stringhe
            -stampare le 3 stringhe tutte in minuscolo e in maiuscolo
            -stampare i primi 3 caratteri di ciascuna stringa
            -attenzione alle stringhe di lunghezza minore di 3 caratteri
            */

            /*  
              Console.Write("scrivete 1 striga ");
              string stringa1= Console.ReadLine();
              Console.Write("scrivete 2 striga ");
              string stringa2 = Console.ReadLine();
              Console.Write("scrivete 3 striga ");
              string stringa3 = Console.ReadLine();

              Console.WriteLine($"stringa1 : {stringa1.ToUpperInvariant()}");
              Console.WriteLine($"stringa1 : {stringa1.ToLowerInvariant()}");
              if (stringa1.Length >= 3)
                  Console.WriteLine($"{stringa1.Substring(0, 3)}");
              Console.WriteLine();

              Console.WriteLine($"stringa2 : {stringa2.ToUpperInvariant()}");
              Console.WriteLine($"stringa2 : {stringa2.ToLowerInvariant()}");
              if (stringa1.Length >= 3) 
              Console.WriteLine(stringa2.Substring(0, 3));
              Console.WriteLine();

              Console.WriteLine("stringa 3:");
              Console.WriteLine(stringa3.ToLowerInvariant());
              Console.WriteLine(stringa3.ToUpperInvariant());
              if (stringa3.Length >= 3)
              Console.WriteLine(stringa3.Substring(0, 3));

              */




            //esempi0 2
            /*
            -generare un numero casuale compreso fra 1 e 10
            - data una stringa di lunghezza di 15 caratteri:
            -stampare la stringa a partire dall'indice corrispondente al numero
            generato
            - sostituire ogni occorrenza di un carattere a scelta nella stringa
            con "Y" e stampare il risultato su schermo
         */

            /*
            Random random= new Random();
            int numeriRandom = random.Next(1, 10);
            string stringa = "Sono una ragazza";
            Console.WriteLine("numeroRandom : "+numeriRandom + " " +" lunghezzaString "
                + stringa.Length);
            Console.WriteLine($"{stringa.Substring(numeriRandom)}");
            Console.WriteLine($"{stringa}\n{stringa.Replace('a', 'Y')}");
            */

            //esempio 3
            /*
            - data una stringa arbitraria:
            - chiedere all'utente una stringa qualsiasi
            - stampare su schermo se la stringa iniziale comincia o finisce con 
            la stringa dell'utente
         */
            /*
            string arbitraria = "Sono una ragazza gentile";
            Console.WriteLine("inserisci una stringa");
            string stringa = Console.ReadLine();
            if (arbitraria.ToLowerInvariant().StartsWith(stringa.ToLowerInvariant()))
            {
                Console.WriteLine($"la stringa comincia con quella parola");
            }
            if(arbitraria.ToLowerInvariant().EndsWith(stringa.ToLowerInvariant())) 
            {
                Console.WriteLine($"la stringa finisce con quella parola");
            }
            */

            //esercizio1
            /*
             - chiedere all'utente 2 numeri
             - chiedere all'utente 2 stringhe
             - stampare su schermo la somma dei due numeri
             - stampare su schermo la "somma" delle due stringhe
            - stampare su schermo il numero maggiore e il numero minore nel formato:
            - "numero maggiore: {numeroMaggiore}"
            - "numero minore: {numeroMinore}"
            - stampare su schermo la stringa di lunghezza maggiore e minore nel formato:
            - "stringa di lunghezza maggiore: {stringaDiLunghezzaMaggiore}"
            - "stringa di lunghezza minore: {stringaDiLunghezzaMinore}"
             */

            /*
            Console.WriteLine("inserisci il primo numero : ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("inserisci il secondo numero : ");
            int numero2 = int.Parse(Console.ReadLine());
            int somma = numero1 + numero2;
            Console.WriteLine("inserisci la prima stringa : ");
            string stringa1= Console.ReadLine();
            Console.WriteLine("inserisci la seconda stringa : ");
            string stringa2 = Console.ReadLine();

            Console.WriteLine($"la somma é : {somma}");
            Console.WriteLine($"La somma delle 2 stringhe : {stringa1} {stringa2}");
            Console.WriteLine();
            if(numero1 > numero2)
            {
                Console.WriteLine($"Il numero1 è maggiore del numero2");
                Console.WriteLine($"{numero1} è maggiore di {numero2}");
            }
            else
            {
                Console.WriteLine("Il numero1 è minore del numero2");
                Console.WriteLine($"{numero1} è minore di {numero2}");
            }

            if(stringa1.Length > stringa2.Length) 
            {
                Console.WriteLine($"stringa di lunghezza {stringa1.Length} è maggiore " +
                    $" di {stringa2.Length}");
            }
            else
            {
                Console.WriteLine($"Stringa di lunghezza {stringa1.Length} è minore " +
                    $"di {stringa2.Length} ");
            }
            */

            //esercizio 2
            /*
             - generare due numeri casuali compresi tra 1 e 5
             - chiedere all'utente una stringa di lunghezza maggiore di 20 caratteri
             - stampare su schermo la stringa a partire dall'indice dato dalla somma dei due caratteri
        */
            /*
            Random r=new Random(); 
            int numero1 =r.Next(1, 5);
            int numero2 = r.Next(1, 5);

            Console.WriteLine("Inserisci una stringa di lunghezza maggiore di 20 carattere");
            string stringa= Console.ReadLine();
            int somma = numero1+ numero2;
            int stringLunghezza = stringa.Length;
            Console.WriteLine(somma + " " + stringLunghezza);
            Console.WriteLine(stringa.Substring(somma));
            */

            //esercizio 3
            /*
             - leggere il contenuto di un file e salvarlo in una stringa
             - chidere all'utente una stringa da ricercare nel testo del file
             - stampare su schermo se la stringa è contenuta nel testo del file
           */

            //esercizio 4
            /*
            - chiedere all'utente una stringa qualsiasi
            - chiedere all'utente una stringa da ricercare nella prima stringa
            - stampare su schermo la prima stringa evidenziando con un colore apposito le occorrenze
            della seconda stringa
         */






        }
    }
}
