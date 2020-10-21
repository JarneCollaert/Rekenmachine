using System;

namespace Rekenmachine
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal1;
            int getal2;
            Console.WriteLine("Wat is het eerste getal?");
            getal1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Wat is het tweede getal?");
            getal2 = Convert.ToInt32(Console.ReadLine());
            int som = getal1 + getal2;
            Console.WriteLine("Dit is de som van de 2 getallen " + som);
            Console.ReadKey();
            int verschil = getal1 - getal2;
            Console.WriteLine("Dit is het verschil van de 2 getallen " + verschil);
            Console.ReadKey();
            int vermenigvuldiging = getal1 * getal2;
            Console.WriteLine("Dit is de vermenigvuldiging van de 2 getallen " + vermenigvuldiging);
            Console.ReadKey();
            int deling = getal1 / getal2;
            Console.WriteLine("Dit is de deling van de 2 getallen " + deling);
            Console.ReadKey();
            
        }
        

    }
}
