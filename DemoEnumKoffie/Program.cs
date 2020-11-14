using System;

namespace DemoEnumKoffie
{
    enum KoffieBeker
    { 
        Klein = 100, //100 ml
        Middel = 150,
        Groot = 250
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Maak uw keuze uit de volgende koffiebekers:");
            foreach (string k in Enum.GetNames(typeof(KoffieBeker)))
                Console.WriteLine("{0,-10} = {1} ml", k, (int)Enum.Parse(typeof(KoffieBeker), k));
            Console.Write("Groot/Middel of kleine koffie nodig?");
            KoffieBeker koffie = (KoffieBeker)Enum.Parse(typeof(KoffieBeker),Console.ReadLine());
            if (koffie == KoffieBeker.Klein)
            {
                Console.WriteLine("De prijs is 2 euro");

            }
            else if (koffie == KoffieBeker.Middel)
            {
                Console.WriteLine("De prijs is 2.5 euro");
            }
            else
            {
                Console.WriteLine("De prijs is 2.85 euro");
            }
             Console.WriteLine("Dat is  " +  (int)koffie + " ml");

        }
    }
}
