using System;

namespace giorno191222
{
    internal class Program
    {
        //macchinetta delle merendine
        /*
         simulare una macchinetta delle merendine:
         punti fondamentali:
            - scegliere n prodotti
            - scegliere un costo per ciascun prodotto
            - attribuire un credito n all'utente
            - chiedere all'utente cosa vuole comprare
            - valutare se l'utente ha abbastanza soldi
            - sottrarre l'importo dai soldi dell'utente
            - stampare su schermo l'esito dell'acquisto
         */
        static void Main(string[] args)
        {
            string[] prodotti = new string[] {"patatine", "caramelle", "biscotti", "succo"};
            double[] costi = new double[] {1.5, 1, 2.5, 2 };
            double credito = 6;
            while (true)
            {
                Console.WriteLine($"benvenuto il tuo credito è di {credito} euro\n");
                Console.WriteLine("cosa vuoi comprare ?");

                Console.WriteLine($"1- {prodotti[0]} {costi[0]}£");
                Console.WriteLine($"2- {prodotti[1]} {costi[1]}£");
                Console.WriteLine($"3- {prodotti[2]} {costi[2]}£");
                Console.WriteLine($"4- {prodotti[3]} {costi[3]}£");

                int input = int.Parse(Console.ReadLine()) - 1;

                if (credito >= costi[input])
                {
                    credito = credito - costi[input];
                    Console.WriteLine($"hai comprato {prodotti[input]}");
                    Console.WriteLine($" ti restano : {credito}euro");
                }
                else { Console.WriteLine("non hai abbastanza soldi"); }
            }
        }
    }
}
