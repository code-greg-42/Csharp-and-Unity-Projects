using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneApp
{
    class Program
    {
        static void Main()
        {
            //List<Game> games = new List<Game>();
            //TwentyOneGame game = new TwentyOneGame();
            //game.Players = new List<Player>() { "Greg", "Phyllis", "Sam", "Cooper", "Amy" };
            //game.ListPlayers();
            //_ = Console.ReadLine();
            //games.Add(game);

            Deck deck = new Deck();
            deck.Shuffle(3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            _ = Console.ReadLine();
        }
    }
}
