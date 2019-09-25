using System;
using System.Collections.Generic;
using System.Text;

namespace War
{
    class Card
    {
        public Card(int r, int s)
        {
            suit = s;
            rank = r;
            // initialize suits Dictionary
            suits.Add(0, "spades");
            suits.Add(1, "hearts");
            suits.Add(2, "diamonds");
            suits.Add(3, "clubs");
            // initialize ranks dictionary
            for (int i = 0; i < ranksStringValue.Length; i++)
            {
                ranks.Add(i, ranksStringValue[i]);
            }
        }

        public Card()
        {
            // initialize with nonsense empty values
            suit = 50;
            rank = 50;
        }

        public override string ToString()
        {
            // if this condition is met, the values are nonsense because they're greater than the
            // corresponding suites and numbers of a deck
            if (rank > 12 || suit > 4)
            {
                // these are the signal values for an empty or "null" card, pertaining esp to an empty deck
                if (suit == 50 && rank == 50)
                {
                    return "The deck must be finished, this is an empty card!";
                }

                return "Something went wrong because these card values don't make sense.";
            }
            else
            {
                return $"{ranks[rank]} of {suits[suit]}";
            }

        }

        private int suit;
        private int rank;
        private Dictionary<int, string> suits = new Dictionary<int, string>();
        private Dictionary<int, string> ranks = new Dictionary<int, string>();
        // ranksStringValue is just used to initialize ranks Dictionary in constructor
        private string[] ranksStringValue = new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

        public int Suit
        {
            get => suit;
            set => suit = value;
        }

        public int Rank
        {
            get => rank;
            set => rank = value;
        }

    }
}
