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
            Console.WriteLine("Come ti chiami? ");
            string stringa = Console.ReadLine();
            Console.WriteLine("Inserisci un numero ");
            int numero =int.Parse(Console.ReadLine());
            Console.WriteLine("scrivere un booleano ");
            bool booleano =bool.Parse(Console.ReadLine());


            Console.WriteLine($"cioia sono {stringa} ho inserito il numero {numero} e bool: {booleano}");

            */

            //esempio 2
            // dichiarere 3 numeri decimale arbitrari
            //chiedere all utente un quarto numero intero o decimale
            //stampare su schermo la somma e la media dei4 numeri
            /*
                        decimal num1 = 12.33m;
                        decimal num2 = 14.34m;
                        decimal num3 = 23.4m;
                        Console.WriteLine("inserisci il quarto numero");
                        decimal num4 = decimal.Parse(Console.ReadLine());
                        decimal somma = num1 + num2 + num3 + num4;

                        Console.WriteLine("la somma : " + somma);
                        Console.WriteLine("la media : " + somma/4);
            */

            //chiedere all utente 4  numeri
            //stampare su schermo somma prodotto e media dei 4 numeri
            //stampare su schermo una stringa cosi formattata:
            //[dataCorrente[ -[somma] - [prodotto] - [media]

            /*   Console.WriteLine("inserisci il primo numero");
               double numeri1 = double.Parse(Console.ReadLine());
               Console.WriteLine("inserisci il secondo numero");
               double numeri2 = double.Parse(Console.ReadLine());
               Console.WriteLine("inserisci il terzo numero");
               double numeri3 = double.Parse(Console.ReadLine());
               Console.WriteLine("inserisci il quarto numero");
               double numeri4 = double.Parse(Console.ReadLine());
               DateTime date = DateTime.Now;   

               double somma = numeri1 + numeri2+ numeri3 + numeri4;
               double media = somma / 4;
               double prodotto = numeri1 * numeri2 * numeri3 * numeri4;
               Console.WriteLine("La somma è : "+ somma + "e la Media :" + media + " il prodotto: "+ prodotto);

               Console.WriteLine("[" + date + "]" + "- " + "[" + somma+ "]" + "-" + "["+ prodotto 
                   +"]" + "-" + "[" + media + "]");

   */

            //esempio 3

            //creare una variabile per salvare la data corrente
            //stampare su schermo la data corrente
            //stampare su schermo la data corrente + 1 giorno
            //stampare su schermo la data corrente - 2 mesi
            //stampare su schermo la data corrente + 15 anni
            //stampare su schermo la data corrente nel formato
            //"/anno/mese/giorno/ora/minuto/secondo/millisecondo"
            /*
                        DateTime data = DateTime.Now;
                        Console.WriteLine(data);
                        Console.WriteLine(data.AddDays(1));
                        Console.WriteLine(data.AddMonths(-2));
                        Console.WriteLine(data.AddYears(15));
                        Console.WriteLine("la data: " + data.Year + "/" +data.Month + "/" + data.Day 
                            + "/"+ data.Hour + "/"+ data.Minute + "/"+ data.Second + "/"+ data.Millisecond);

             */

            // esempio 4

            //chiedere all untente 3 numeri
            //generare 3 numeri casuali tra 0 e 10
            //stampare la somma dei 6 numeri
            //stampare la data corrente + tanti giorni quanto il risultato della somma

            Console.WriteLine("inserisci il primo numero");
            Random numero1 = new Random();
            int risult1 = numero1.Next(0, 10);
            Console.WriteLine("inserisci il secondo numero");
            Random numero2 = new Random();
            int risult2 = numero2.Next(0, 10);
            Console.WriteLine("inserisci il primo numero");
            Random numero3 = new Random();
            int risult3 = numero3.Next(0, 10);
            int somma = risult1 + risult2 + risult3;

            DateTime date = DateTime.Now;
            Console.WriteLine($" 3 numeri : {risult1} , {risult2},{risult3}");

            Console.WriteLine($"la somma {somma}");
            Console.WriteLine("la data corrente è : " + date + " " + date.Day + " ");
        }
    }
}
