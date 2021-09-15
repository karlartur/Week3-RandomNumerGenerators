using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus on kaks mängijat
            //mõlemad mängijad viskavad täringut
            //programm kontrollib, kumb mängija viskas rohkem
            //mängija, kes viskas rohkem ongi võitja
            //programm kuulutab võitjat

            Random rnd = new Random();
            int Player1 = rnd.Next(1, 7);//number 1 kuni 6
            int Player2 = rnd.Next(1, 7);//number 1 kuni 6

            Console.WriteLine($"Sinu juhuslik number on {Player1}");
            Console.WriteLine($"Sinu juhuslik number on {Player2}");

            if (Player1 > Player2)
            {
                Console.WriteLine("Player1 võitab");
            }
            else if (Player1 < Player2)
            {
                Console.WriteLine("Player2 võitab");
            }
            else
            {
                Console.WriteLine("Mitte keegi ei võitnud");
            }


        }
    }
}
