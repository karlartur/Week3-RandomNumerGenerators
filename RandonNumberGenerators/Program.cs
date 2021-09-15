using System;

namespace RandonNumberGenerators
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int myRandomNumber = rnd.Next(1, 11);//number 1 kuni 10

            Console.WriteLine($"Sinu juhuslik number on {myRandomNumber}");

            //programm kontrollib, kas genereeritud number on suurem kui 5
            //kui genereeritud number on suurem, kui 5, progamm kuvab
            //"juhuslik number on {myRandomNumber}, see on suurem kui 5"
            //kui genereeritud on väiksem, kui 5, siis programm kuvab 
            //"juhuslik number on {myRandomNumber}, see on väiksem kui 5
            // kui genereeritud number on 5, programm kuvab
            //"juhusliknumber on 5"
            //< - viksem kui, > suurem kui, == - võrdne

            

            if (myRandomNumber > 5)
            {
                Console.WriteLine("See on suurem kui 5");
            }
            else if (myRandomNumber < 5)
            {
                Console.WriteLine("See on väiksem kui 5");
            }
            else 
            {
                Console.WriteLine("See on võrdne number");
            }
        }
    }
}
