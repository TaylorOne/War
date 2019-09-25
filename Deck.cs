using System;
using System.Collections.Generic;
using System.Text;

namespace War
{
    class Deck
    {
        public Deck()
        {
            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    cards.Add(new Card(i, j));
                }
            }

            cards.Shuffle();

        }

        private List<Card> cards = new List<Card>();

        public int GetCount()
        {
            return cards.Count;
        }

        public Card RemoveCard()
        {
            if (cards.Count == 0)
            {
                // if deck is empty, return a card with special values to signal that it's empty
                return new Card(50, 50);
            } else
            {
                // store the value of the card at the bottom of the deck, remove and return it
                var tempCard = cards[0];
                cards.RemoveAt(0);
                return tempCard;
            }
            
        }

    }

}
