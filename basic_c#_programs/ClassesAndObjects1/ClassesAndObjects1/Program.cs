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
            Deck deck = new Deck();
            int timesShuffled = 0;
            deck = Shuffle(deck, out timesShuffled, 3);
            //deck.Cards = new List<Card>();

            //Card cardOne = new Card();
            //cardOne.face = "Queen";
            //cardOne.suit = "Spades";

            //deck.Cards.Add(cardOne);



            //Console.WriteLine(cardOne.face + " of " + cardOne.suit);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.face + " of " + card.suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.WriteLine("Times shuffled: {0}", timesShuffled);
            _ = Console.ReadLine();
        }

        // creates method usable by entire program, para Deck, returns Deck
        public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1)
        {
            timesShuffled = 0;
            for (int i = 0; i < times; i++)
            {
                timesShuffled++;
                List<Card> TempList = new List<Card>();
                // c# built in randomizer
                Random random = new Random();

                while (deck.Cards.Count > 0)
                {
                    // method for getting next random #, args are min/max
                    int randomIndex = random.Next(0, deck.Cards.Count);
                    // add random card to new list
                    TempList.Add(deck.Cards[randomIndex]);
                    // remove card from list
                    deck.Cards.RemoveAt(randomIndex);
                }
                deck.Cards = TempList;
            }
            return deck;
        }
        
        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}
    }
}
