// Enrick De Munter 5ITN nr4

/*we willen dat alle getallen deelbaar zijn
 * 
 * input
 * Vraag het deeltal aan de gebruiker
 * Vraag het getal dat je wil laten delen door het deeltal
 * 
 * processing
 * Doe de deling
*/


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
            byte deeltal, deler;
            string antwoord;
            bool vraagdeeltal, vraaggetal;

            //input
            // Vraag het deeltal aan de gebruiker
            Console.WriteLine("wat is uw deeltal?: ");
            vraagdeeltal = byte.TryParse(Console.ReadLine(), out deeltal);
            // Vraag het getal dat je wil laten delen door het deeltal
            Console.WriteLine("wat is uw getal?: ");
            vraaggetal = byte.TryParse(Console.ReadLine(), out deler);

            //processing
            // Doe de deling tussen de 2 getallen
            antwoord = 

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
