using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17delen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaraties
            byte deeltal, getal;
            string antwoord;
            bool vraagdeeltal, vraaggetal;

            //input
            // Vraag het deeltal aan de gebruiker
            Console.WriteLine("wat is uw deeltal?: ");
            vraagdeeltal = byte.TryParse(Console.ReadLine(), out deeltal);
            // Vraag het getal dat je wil laten delen door het deeltal
            Console.WriteLine("wat is uw getal?: ");
            vraaggetal = byte.TryParse(Console.ReadLine(), out getal);

            //processing
            // Doe de deling tussen de 2 getallen
            antwoord = vraagdeeltal / vraaggetal;

            // output
            //Toon de het eindegetal na de deling
            Console.WriteLine(antwoord);

            //wachten.....
            Console.WriteLine();
            Console.WriteLine("Druk op enter om af te sluiten");
            Console.ReadKey();
        }
    }
}
