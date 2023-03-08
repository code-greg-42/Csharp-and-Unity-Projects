using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Deck
    {
        public Deck()
        {
            Cards = new List<Card>();

            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Card card = new Card
                    {
                        Face = (Face)i,
                        Suit = (Suit)j
                    };
                    Cards.Add(card);
                }
            }
        }
        public List<Card> Cards { get; set; }

        // creates method usable by entire program, para Deck, returns Deck
        public void Shuffle(int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();
                // c# built in randomizer
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    // method for getting next random #, args are min/max
                    int randomIndex = random.Next(0, Cards.Count);
                    // add random card to new list
                    TempList.Add(Cards[randomIndex]);
                    // remove card from list
                    Cards.RemoveAt(randomIndex);
                }
                Cards = TempList;
            }
        }
    }
}
