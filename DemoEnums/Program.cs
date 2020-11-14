using System;

namespace DemoEnums
{
    class Program
    {
        enum Kleur 
            {
                Wit,// = 0,
                Zwart,// = 1,
                Rood,// = 2,
                Groen,// = 3,
                Blauw,// = 4,
                Geel// = 5
            };
        static void Main(string[] args)
        {
            // ConsoleColor consoleKleur = ConsoleColor.Yellow; // ConsoleColor is built-in enum
      
             Kleur mijnKleur = Kleur.Groen;

            PrintMyColor(mijnKleur);

        }

        private static void PrintMyColor(Kleur mijnKleur)
        {
            Console.WriteLine("Mijn lievelingskleur is: " + mijnKleur.ToString());
            Console.WriteLine("De numerieke waarde (alias) voor mijn lievingskleur: " + (int)mijnKleur);
        }
    }
}
