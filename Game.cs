using System;
using System.Collections.Generic;
using System.Text;

namespace War
{
    class Game
    {
        private Player p1 = new Player();
        private Player p2 = new Player();
        private Card p1c, p2c = new Card();
        private Deck deck = new Deck();
        private string winner = "";

        public void Play()
        {
            Console.WriteLine("Starting War!");
            GetPlayersNames();
            while (deck.GetCount() >= 2)
            {
                p1c = deck.RemoveCard();
                p2c = deck.RemoveCard();
                AnnounceCardDraws(p1, p2, p1c, p2c);

                if (CompareCards(p1c,p2c))
                {
                    p1.Wins += 1;
                    AnnounceRoundWinner(p1);
                }
                else
                {
                    p2.Wins += 1;
                    AnnounceRoundWinner(p2);
                }
            }

            DeclareWinner(p1, p2);
        }

        public void GetPlayersNames()
        {
            Console.WriteLine("Please enter player one's name: ");
            var name = Console.ReadLine();
            p1.Name = name;
            Console.WriteLine("Please enter player two's name: ");
            name = Console.ReadLine();
            p2.Name = name;
        }

        public void AnnounceRoundWinner(Player winner)
        {
            Console.WriteLine($"{winner.Name} wins this round!");
        }

        public void AnnounceCardDraws(Player p1, Player p2, Card c1, Card c2)
        {
            Console.WriteLine($"{p1.Name} drew a {c1.ToString()}, {p2.Name} drew a {c2.ToString()}");
        }

        public void DeclareWinner(Player p1, Player p2)
        {
            if (p1.Wins == p2.Wins)
            {
                Console.WriteLine("It was a tie!");
            }
            else
            {
                if (p1.Wins > p2.Wins)
                {
                    Console.WriteLine($"{p1.Name} won!");
                }
                else
                {
                    Console.WriteLine($"{p2.Name} won!");
                }
            }
        }

        public Boolean CompareCards(Card p1card, Card p2card)
        {
            if (p1card.Rank == p2card.Rank)
            {
                if (p1card.Suit > p2card.Suit)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            } else
            {
                if (p1card.Rank > p2card.Rank)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

    }
}
