using System;

namespace giorno161222
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*
           Console.WriteLine("Inserisci un numero");
           int numero = int.Parse(Console.ReadLine());
           if(numero == 5)
           {
               Console.WriteLine( "il numero è uguale a 5");
           }
           else if(numero == 10)
           {
               Console.WriteLine("il numero è uguale a 10");
           }
           else 
           {
               Console.WriteLine("non so ancora");
           }

           */

            //esercizio 1

            /**
             * creare una variabile di tipo string con valore = [nome arbitrario]
             * chiedere all utente come si chiama
              *verificare che il nome dell utente corrisponde al valore della variabile string
              *in caso positivo stampare su schermo:
              *-benvenuto [nome utente]
              *in caso negativo stampare su schermo
              *-non ti conosco
            */
            /*  

              string nomeArbitraria = "Vanessa";
              Console.WriteLine("come ti chiami ?");
              string nome = Console.ReadLine(); 


              if(nome.ToLowerInvariant() == nomeArbitraria.ToLowerInvariant())
              {
                  Console.WriteLine("benvenuta " + nome);
              }
              else 
              {
                  Console.WriteLine("non ti conosco");
              }

              */

            //Esercizio 2

            /*generare 2 numeri casuali tra 1 e 10
             * se il primo numero è maggiore del secondo stampare su schermo:
             * -il primo è maggiore del secondo
             * -altrimenti stampare su schermo:
             * -il secondo è maggiore del primo
             * -chiedere all utente un numero compreso tra 1 e 10
             * -se l utente indovina uno dei due numeri casuali stampare su schermo:
             * -hai indovinato il numero: ènumero indovinato]
             */

            /*

            Random random= new Random();
            int numero1 = random.Next(0,11);
            int numero2 = random.Next(0, 11);
            //Console.WriteLine($"generiamo 2 numeri causali il primo : {numero1} e il secondo : {numero2}");
            Console.WriteLine("inserisci un numero tra 1 e 10");
            int numero3 = int.Parse(Console.ReadLine());  
            
            Console.WriteLine($"generiamo 2 numeri causali il primo : {numero1} e il secondo : {numero2}" );

            if(numero1 > numero2) 
            {
                Console.WriteLine("Il primo numero è maggiore del secondo");
            }
            else if (numero3 ==numero1 || numero3 == numero2)
            {
                Console.WriteLine($"Hai indovinato il numero {numero3}");
            }
            else
            {
                Console.WriteLine("Il secondo è maggiore del primo");
            }

            */


            /* creare 2 stringhe con nomi 'username' e 'password' con valori arbitrari 
             -chiedere all utente 2 input tramite i quali si deve loggare
            -verificare  la validità degli input dell utente
            -stampare su schermo se il login è risultato o meno
            */

            /*
            string username = "Vanessa";
            string password = "vanessa31";
            Console.Write("Inserisci il nome utente");
            string inputNome = Console.ReadLine();
            Console.Write("Inserisci  la password ");
            string inputPass = Console.ReadLine();

            if (inputNome.ToLowerInvariant()== username.ToLowerInvariant()
                && inputPass == password )
            {
                Console.WriteLine($"Benvenuta : {username}");
            }
            else { Console.WriteLine("login fallito"); }

            */

            //Esercizio 4
            /*- generare un numero casuale compreso tra 1 e 5
             -chiedere all utente un numero tra 1 e 10
            -confrontare il numero dell utente con variabile int di valore arbitrario 
            e col numero casuale
            -nel caso il numero dell utente sia maggiore di 3 e uguale al numero casuale o alla variabile 
            stampare su schermo "hai vinto"*/
            /*
               int numArbitrario = 4;
               Random numeroR = new Random();  
               int numGenerato = numeroR.Next(1,6);
               Console.WriteLine($"il numero generato è : {numGenerato}");
               Console.WriteLine("inserisci un numero tra 1 e 10 ");
               int numInserito = int.Parse(Console.ReadLine());  

               if(numInserito> 3 &&( numInserito == numGenerato || numInserito == numArbitrario))
               {
                   Console.WriteLine("Hai vinto");

               }

              */

            // Esercizio 5
            /*-generare 5 numeri casuali compresi tra 0 e 20 
             * -stampare su schermo le coppie di numeri uguali con il formato
             * :-es:"il numero1 e il numero2 sono uguali !"
             * */

            /*
             Random r= new Random();
             int number = 10;
             int[] numeri = new int[number];
             for (int i=0; i<number; i++)
             {
                 numeri[i] = r.Next(0, 21);
                 Console.WriteLine($"nummero  {numeri[i]}");
             }

             for (int i=0; i<number-1; i++)
             {
                 for (int j=i+1; j<number; j++)
                 {
                     if (numeri[i] == numeri[j])
                     {
                         Console.WriteLine($"numeri uguali {numeri[i]} = {numeri[j]}");
                     }
                 }
             }

             */


            // Esercizio 6
            /* 
             estrarre 5 numeri casuali compresi fra 1 e 20
            -chiedere all utente 10 numeri
            -stampare su schermo se l utente è riuscito a indovinare qualche numero
            ,es: "hai fatto ambo !", "hai fatto terna !".. etc..
            */
            /*
            int maxNumeri = 21;
            int number = 5;
            int[] numbers = new int[number] ;
            Random numCasuali = new Random();
            for(int i=0; i<number; i++)
            {
                numbers[i] = numCasuali.Next(0,maxNumeri) ;
                Console.WriteLine($"il numero {i} casuale è : {numbers[i]}");
            }

            int numInseritiTotale = 4;
            int []numInseriti = new int[numInseritiTotale] ;
            for (int i=0; i<numInseritiTotale; i++) 
            {
                Console.WriteLine("inserisci 4 numeri" + (i + 1));
                numInseriti[i] = int.Parse(Console.ReadLine());
               // Console.WriteLine($"{i}il numero inserito è : {numInseriti[i]}");
            }

            int numeriIndovinati = 0;
            for(int i=0; i<numInseritiTotale; i++)
            {
                for(int j=0; j<maxNumeri;j++) 
                {
                    if (numbers[i] == numInseriti[i])
                    {
                        numeriIndovinati++;

                    }
                }
               
            }
            
            */

            //Esercizio 7

            /* 
             creare 2 stringhe con valore arbitrario
            -chiedere all' utente una terza stringa
           - stampare su schermo le seguenti valutazioni:
            - se la stringa dell'utente è uguale a una delle due variabili
            - se la stringa dell'utente è di lunghezza maggiore o minore di ciascuna 
            delle due variabili

              -*/
            /* 
             string valore1 = "mango";
             string valore2 = "pippo";
             Console.WriteLine("inserisci il valore3");
             string valore3 = Console.ReadLine();

             if (valore3.ToLowerInvariant() == valore1.ToLowerInvariant() 
                 || valore3.ToLowerInvariant() == valore2.ToLowerInvariant()) 
             {
                 Console.WriteLine($"il volore3 {valore3} è uguale al valore1 {valore1}" +
                     $" oppure il valore3 è uguale al valore2 {valore2}");
             }
             else { Console.WriteLine("non sono uguali"); }

             if(valore3.Length > valore1.Length || valore3.Length>valore2.Length)

             {
                 Console.WriteLine(valore3.Length);
                 Console.WriteLine("il valore3 ha una length maggiore ");
             }
             else { Console.WriteLine("lunghezza minore"); }

             */
        }
    }
}
