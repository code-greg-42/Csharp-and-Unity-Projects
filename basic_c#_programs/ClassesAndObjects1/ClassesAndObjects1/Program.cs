using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TwentyOneGame game = new TwentyOneGame() { Dealer = "Greg", Name = "Blackjack" }
            game.Players = new List<string>() { "Joe", "Bill", "Phyllis" };
            game.ListPlayers();
            game.Play();
            Deck deck = new Deck();
            deck.Shuffle(3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.face + " of " + card.suit);
            }
            Console.WriteLine(deck.Cards.Count);
            _ = Console.ReadLine();
        }
    }
}
