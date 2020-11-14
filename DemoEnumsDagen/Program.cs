using System;

namespace DemoEnumsDagen
{
    class Program
    {
        enum Dag
        {
            Maandag = 1,
            Dinsdag ,
            Woensdag ,
            Donderdag ,
            Vrijdag ,
            Zaterdag,
            Zondag

        }
        static void Main(string[] args)
        {
            Dag eersteDag = (Dag)Enum.Parse(typeof(Dag), "Maandag");
            Console.WriteLine("Eerste dag is " + eersteDag.ToString());

            int numiekeWaardeDag = (int)Enum.Parse(typeof(Dag), "Maandag");
            Console.WriteLine("Numerieke waarde van Maandag" + numiekeWaardeDag);
            Console.WriteLine("De dagen van de week en hun numerieke waarden");
            foreach (string s in Enum.GetNames(typeof(Dag)))
                Console.WriteLine("{0,11} = {1}", s, (int)Enum.Parse(typeof(Dag), s));
            //Dag vandaag = (Dag)5;
            //Console.WriteLine("Vandaag is " + vandaag.ToString());
            //Dag maandag = Dag.Maandag;
            //Console.WriteLine("Maandag = " + (int)maandag);
            //Console.WriteLine("Zondag = " + (int)Dag.Zondag);
        }
    }
}
