using System;

namespace giorno131222
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //esempio 1
            /*
                      string parola1 = "Ciao";
                      string parola2 = "Gatto";
                      string parola3 = "10";
                      string parola4 = "5";

                      int num1 = 10;
                      int num2 = 10;
                      int somma =num1 + num2;

                      Console.WriteLine("la somma della mia striga :" + parola3 + parola4);
                      Console.WriteLine($"la somma della mia striga :{parola1} {parola2}");
                      Console.WriteLine($"la somma dei numeri :{somma}");

          */

            // esempio 2
            /*
                        Console.WriteLine("inserisci il tuo nome ");
                        string nome= Console.ReadLine();
                        Console.WriteLine("inserisci il tuo cognome ");
                        string cognome = Console.ReadLine();
                        Console.WriteLine("inserisci la tua età ");
                        int eta = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Quanti fratelli ne hai ?");
                        int numFratelli= Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Quante sorelle ne hai ?");
                        int numSorelle= Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine($"Cioa io sono {nome} {cognome} e ho {eta} anni");
                        Console.WriteLine($"Hai {numFratelli} fratelli e {numSorelle} sorelle");
            */

            //esempio 3

            /*          Console.WriteLine("Quanti fratelli ne hai ?");
                        int Fratelli = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Quante sorelle ne hai ?");
                        int Sorelle = int.Parse(Console.ReadLine());
                        int total = Fratelli + Sorelle;   

                        Console.WriteLine($"In totale hai : {total} fratelli");
                        Console.WriteLine("in totale hai " + (Fratelli + Sorelle )+ " fratelli") ;

             */

            //esempio 4
            /*
                        Console.WriteLine("inserisci il primo numero: ");
                        double numOne = double.Parse(Console.ReadLine());
                        Console.WriteLine("inserisci il secondo numero: ");
                        double numTwo = double.Parse(Console.ReadLine());
                        double addizione= numOne+ numTwo;
                        double sottrazione = numOne - numTwo;   
                        double multiplicazione = numTwo * numOne;  
                        double  divisione = numOne / numTwo;   


                        Console.WriteLine($"il risultati sono : Addizione : {addizione} , sottrazione : {sottrazione}");
                        Console.WriteLine($"il risultati sono : multiplicazione : {multiplicazione} , divisione: {divisione}");
                        Console.WriteLine("operazione di base : " + (numOne + numTwo)/2 );

            */


            //esempio 5


            Console.WriteLine("inserisci il primo numero: ");
            double numero1 = double.Parse(Console.ReadLine());
            Console.WriteLine("inserisci il secondo numero: ");
            double numero2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Il risultato di numero1 + numero2 è " + (numero1 + numero2));
            Console.WriteLine("Il risultato di numero1 - numero2 è " + (numero1 - numero2));
            Console.WriteLine("Il risultato di numero1 * numero2 è " + (numero1 * numero2));
            Console.WriteLine("Il risultato di numero1 / numero2 è " + (numero1 / numero2));
            Console.WriteLine("Il risultato di (numero1 + numero2)/2 è " + (numero1 + numero2) / 2);
            Console.WriteLine($"{numero1} + {numero2} = {numero1 + numero2}");

        }
    }
}
