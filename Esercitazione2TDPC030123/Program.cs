using System;

namespace Esercitazione2TDPC030123
{
    internal class Program
    {
        /*
         - chiedere all'utente due stringhe
         - stampare su schermo la concatenazione delle due stringhe
         - stampare su schermo le due stringhe al contrario
         */
        /*
        static void Main(string[] args)
        {
            Console.Write("Inserisci la prima stringa : ");
            string input1=Console.ReadLine();
            Console.Write("Inserisci la seconda stringa : ");
            string input2 = Console.ReadLine();
            Console.WriteLine($"{input1} {input2}");
            //Console.WriteLine(input2 + "" + input2);
            string[] s = {input1,input2};   
            for(int i =s.Length -1;i>=0;i--) 
            {
                Console.WriteLine(s[i]);    
            }
        }
        */
        /*
         - creare un array di dimensione a scelta dell'utente
         - popolare completamente l'array di numeri casuali
         - tramite una funzione stampare su schermo tutti i numeri
        dell'array
         - stampare su schermo il numero maggiore tra quelli generati
         */

        /*
        static void PrintNumber(int[] n)
        {
            int somma = 0;
            int massimo = n[0];
            for(int i=0;i<n.Length;i++)
            {
                somma += n[i];
                if (n[i] > massimo)
                {
                    massimo = n[i]; 
                }
            }
            Console.WriteLine("La somma : " + somma);
            Console.WriteLine("Il massimo : " + massimo);
            
        }
        static void Main(string[] args)
        {
            int numeriLenght = 10;
            int[] numbers = new int[numeriLenght];
            Random r = new Random();
            for(int i=0;i<numeriLenght;i++) 
            {
                numbers[i] = r.Next(100);
                Console.WriteLine((i+1)+ ") " +numbers[i]);

            }
            PrintNumber(numbers);
        }
        */
        /*
        creare 3 funzioni:
           1)- chiede all'utente i suoi dati anagrafici e il suo
           animale preferito
           2)- stampa su schermo i dati anagrafici dell'utente
           3)- stampa su schermo l'animale preferito dell'utente
        */
        /*
        static void PrintAnimalePreferito(string a)
        {
            Console.WriteLine($"Il tuo animale preferito : {a}");
        }
        static void FunzioneNom(string n, string c, int e)
        {
            Console.WriteLine($"Nome : {n} Cognome : {c} Eta : {e}");
            
        }
        static void Main(string[] args)
        {
            Console.Write("Inserisci tuo nome : ");
            string nome= Console.ReadLine(); 
            Console.Write("Inserisci tuo cognome : ");
            string cognome = Console.ReadLine();
            Console.Write("Inserisci età : ");
            int eta = int.Parse(Console.ReadLine());
            Console.Write("Qual è il tuo animale preferito : ");
            string animale= Console.ReadLine(); 

            FunzioneNom(nome, cognome, eta);
            PrintAnimalePreferito(animale);
        }
        */
        /*
         creare un gioco in cui il giocatore deve indovinare
         un numero per 3 volte di seguito prendendolo da un pool
         di dimensione variabile a scelta dell'utente stesso:
            - chiedere all'utente il range dei numeri da generare
            - per 3 volte chiedere all'utente un numero
            - stampare su schermo quanti e quali numeri si sono indovinati
         */
        static void Main(string[] args)
        {
            Console.Write("Come vuoi farti chiamare utente ? ");
            string utente= Console.ReadLine();
            Console.Write("Premi Enter per iniziare a gioccare ");
            string scelta = Console.ReadLine();  
            if(scelta == "")
            {
                Console.WriteLine($"Ciao {utente}");
                Console.WriteLine("Su quale range vuoi gioccare ? ");
                Console.WriteLine();
                Console.WriteLine("1-100 premi il numero '1'");
                Console.WriteLine("100-200 premi il numero '2'");
                int input =int.Parse(Console.ReadLine());

                Console.WriteLine("Inserisci il primo numero");
                int n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Inserisci il secondo numero");
                int n2 = int.Parse(Console.ReadLine());
                Console.WriteLine("Inserisci il terzo numero");
                int n3 = int.Parse(Console.ReadLine());

                if (input == 1) 
                {
                    Random r = new Random();
                    
                    for(int i=0;i<3;i++)
                    {
                        int numeroPool = r.Next(10);
                        Console.WriteLine(numeroPool);
                        if(numeroPool == n1)
                        {
                            Console.WriteLine("bravo " + n1 +" = "+ numeroPool);
                        }
                        if (numeroPool == n2)
                        {
                         Console.WriteLine("bravo " + n2 + " = " + numeroPool);
                        }
                        if (numeroPool == n3)
                        {
                            Console.WriteLine("bravo " + n3 + " = " + numeroPool);
                        }
                        
                    }
                }
                else
                {
                    Console.WriteLine("Riprova dopo");
                }
               

                

            }
            
            


        }
    }
}
