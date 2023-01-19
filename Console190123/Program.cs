using System;

namespace Console190123
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Benvenuto/a come vuoi chiamarti?");
            string nome = Console.ReadLine();
            Console.WriteLine($"Ciao {nome} sei pronto per gioccare! " +
                $"allora premi un tasto ");
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Quante fa (2+2) ?");
            int domanda1 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Come si scrive a lettere il " +
                "numero della risposta precedente?");
            string domanda2 = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Quante lettere ci sono nella " +
                "parola della risposta precedente ?");
            int domanda3 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int esatte = 0;
            int sbagliate = 0;
            if(domanda1== 4)
            {
                esatte += 1;
            }
            else
            {
                Console.WriteLine($"Tu hai scritto {domanda1} invece di '4' ");
                sbagliate += 1;
            }
            if (domanda2.ToLowerInvariant() == "quattro" )
            {
                esatte += 1;
            }
            else
            {
                Console.WriteLine($"Tu hai scritto {domanda2} invece di 'quattro' " +
                    $" 'Quattro' 'QUATTRO'");
                sbagliate += 1;
            }
            if (domanda3 == 7)
            {
                esatte += 1;
            }
            else
            {
                Console.WriteLine($"Tu hai scritto {domanda3} invece di '7' ");
                sbagliate += 1;
            }

            Console.WriteLine($"{nome} hai trovato {esatte} risposta/e esatta/e " +
                $"e {sbagliate} risposta/e sbagliata/e");
            Console.WriteLine($"Ciao {nome} alla prossima!!!");

        }
    }
}
