using System;

namespace EnumAlsTerugkeerWaardeMethode
{
    enum Weekdag { Maandag, Dinsdag, Woensdag, Donderdag, Vrijdag, Zaterdag, Zondag };
    enum TypeBedrijf { Restaurant, Café, Winkel};
    class Program
    {
        static void Main(string[] args)
        {
            TypeBedrijf typeBedrijf;
            string invoer;
            do
            {
                Console.Write("Geef het type bedrijf (Winkel/Café/Restaurant): ");
                invoer = Console.ReadLine();
            } while (!Enum.TryParse<TypeBedrijf>(invoer, out typeBedrijf));
       // }while !Enum.TryParse(typeof(TypeBedrijf),invoer,out typeBedrijf)
            Console.WriteLine("Het type bedrijf is: " + typeBedrijf);
            Weekdag sluitDag = GeefSluitingsDag(typeBedrijf);
            Console.WriteLine($"Sluitingsdag van {typeBedrijf}: {sluitDag}");
            //Weekdag sluitDagResto = GeefSluitingsDag(TypeBedrijf.Restaurant);
            //Console.WriteLine($"Sluitingsdag van {TypeBedrijf.Restaurant}: " + sluitDagResto);

            //Weekdag sluitDagWinkel = GeefSluitingsDag(TypeBedrijf.Winkel);
            //Console.WriteLine($"Sluitingsdag van {TypeBedrijf.Winkel}: " + sluitDagWinkel);

        }
        static Weekdag GeefSluitingsDag(TypeBedrijf typeBedrijf)
        {
            if (typeBedrijf == TypeBedrijf.Restaurant || typeBedrijf == TypeBedrijf.Café)
            {
                return Weekdag.Maandag;
            }
            else
            {
                return Weekdag.Zondag;
            }
        }
    }
}
