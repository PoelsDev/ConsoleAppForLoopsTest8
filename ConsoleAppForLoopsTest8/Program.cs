using System;

namespace ConsoleAppForLoopsTest8
{
    class Program
    {
        static Random rndGen = new Random();

        static void Main(string[] args)
        {
            int aantalLines = 8;

            for (var i = 0; i < aantalLines; i++)
            {
                int aantalTekens = rndGen.Next(20, 31);
                TekenLijn(aantalTekens);            
            }
        }

        static void TekenLijn(int lengte)
        {
            for (var j = 0; j < lengte; j++)
            {
                Console.Write("#");
            }
            Console.WriteLine();
        }
    }
}
