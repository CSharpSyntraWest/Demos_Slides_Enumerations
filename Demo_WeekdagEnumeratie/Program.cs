using System;

namespace Demo_WeekdagEnumeratie
{
    enum Weekdag { Maandag, Dinsdag, Woensdag,Donderdag,Vrijdag,Zaterdag,Zondag};
    class Program
    {
        static void Main(string[] args)
        {
            //Weekdag weekdag = Weekdag.Maandag;
            //int lesUrenMaandag = GeefAantalLesuren(weekdag);
            //Console.WriteLine($"Aantal lesuren op {weekdag}: {lesUrenMaandag}");
            int totaalAantalLesurenPerWeek = 0;
            foreach (string dag in Enum.GetNames(typeof(Weekdag)))
            {
                int lesUren = GeefAantalLesuren((Weekdag)Enum.Parse(typeof(Weekdag),dag));
                totaalAantalLesurenPerWeek += lesUren;
                Console.WriteLine($"Aantal lesuren op {dag}: {lesUren}");
            }
            Console.WriteLine("Totaal aantal lesuren in de week: " + totaalAantalLesurenPerWeek);
        }

        private static int GeefAantalLesuren(Weekdag weekdag)
        {
            int lesuren = 0;
            switch (weekdag)
            {
                case Weekdag.Maandag:
                case Weekdag.Woensdag:
                case Weekdag.Zaterdag:
                case Weekdag.Zondag:
                    lesuren = 0;
                    break;
                case Weekdag.Dinsdag:
                case Weekdag.Donderdag:
                case Weekdag.Vrijdag:
                    lesuren = 6;
                    break;           
            }

            return lesuren;
        }
    }

}
