using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main()
        {
            //string text = File.ReadAllText(@"C:\Users\gregs\logs\TwentyOne\TwentyOne_log.txt");
            //Console.WriteLine(text);
            //_ = Console.ReadLine();

            Console.WriteLine("Welcome to the Golden Nugget Hotel & Casino. Let's start by telling me your name.");
            string playerName = Console.ReadLine();
            Console.WriteLine("How much money are you looking to play with today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "sure" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;

                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.Read();
        }
    }
}
