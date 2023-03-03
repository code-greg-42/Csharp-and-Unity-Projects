using System;

namespace whileLoopPractice
{
    class Program
    {
        static void Main()
        {

            string userGuess = "";

            while (userGuess.ToLower() != "tiger")
            {
                Console.WriteLine("Please guess an animal:");
                userGuess = Console.ReadLine();
            }
            Console.WriteLine("\"tiger\" is correct! grrrr");
            Console.WriteLine("Press any button followed by enter to continue.");
            _ = Console.ReadLine();

            do
            {
                Console.WriteLine("Please guess an animal:");
                userGuess = Console.ReadLine();
            }
            while (userGuess != "bear");
            Console.WriteLine("\"bear\" is correct! rawrrrrr");
            Console.WriteLine(" -- program end");
            _ = Console.ReadLine();
        }
    }
}
