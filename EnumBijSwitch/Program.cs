using System;

namespace EnumBijSwitch
{
    class Program
    {
        enum VerkeersLicht
        {
            Groen, //=0
            Oranje, //=1
            Rood //=2

        }
        static void Main()
        {
            do
            {
                Console.WriteLine("De lichten zijn:? ");
                VerkeersLicht verkeersLicht = (VerkeersLicht)Enum.Parse(typeof(VerkeersLicht), Console.ReadLine());

                switch (verkeersLicht)
                {
                    case VerkeersLicht.Groen:
                        Console.WriteLine("Doorrijden!");
                        break;
                    case VerkeersLicht.Rood:
                        Console.WriteLine("Stoppen!");
                        break;
                    case VerkeersLicht.Oranje:
                        Console.WriteLine("Gas bijgeven!");
                        break;
                    default:
                        Console.WriteLine("Wa is da?");
                        break;
                }
            } while (true);
        }
    }
}
