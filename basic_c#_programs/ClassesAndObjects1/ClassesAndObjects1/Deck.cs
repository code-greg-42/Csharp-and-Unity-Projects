using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneApp
{
    public class Deck
    {
        public Deck()
        {
            Cards = new List<Card>();
            List<string> Suits = new List<string>()
            {
                "Clubs",
                "Hearts",
                "Diamonds",
                "Spades"
            };
            List<string> Faces = new List<string>()
            {
                "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };

            foreach (string face in Faces)
            {
                foreach (string suit in Suits)
                {
                    Card card = new Card();
                    card.suit = suit;
                    card.face = face;
                    Cards.Add(card);
                }
            }

            //older code
            //Cards = new List<Card>();
            //Card cardOne = new Card();
            //cardOne.face = "Two";
            //cardOne.suit = "Hearts";
            //Cards.Add(cardOne);
        }
        public List<Card> Cards { get; set; }
    }
}
