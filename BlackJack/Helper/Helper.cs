using System;
using System.Collections.Generic;

namespace _21
{
   
    public class CreateDeck
    {
        private Dictionary<string, int> CardNames = new Dictionary<string, int>()
        {
            {"Jack", 10},
            {"Queen", 10},
            {"King", 10},
            {"Ace", 1},
            {"Two", 2},
            {"Three", 3},
            {"Four", 4},
            {"Five", 5},
            {"Six", 6},
            {"Seven", 7},
            {"Eight", 8},
            {"Nine", 9},
            {"Ten", 10},
        };
        private List<string> CardTypes = new List<string>()
        {
            "Spades", "Hearts", "Clubs", "Diamonds"
        };

        public List<Card> Deck = new List<Card>();

        public CreateDeck()
        {
            foreach (var type in CardTypes)
            {
                foreach (var name in CardNames)
                {
                    Deck.Add(new Card()
                    {
                        CardType = type,
                        CardName = name.Key,
                        DisplayName = $"{name.Key} of {type}",
                        CardValue = name.Value,
                    });
                }
            }
        }
    }

    public class Card
    {
        public string CardType { get; set; }
        public int CardValue { get; set; }
        public string CardName { get; set; }
        public string DisplayName { get; set; }
    }

    public class BlackJack

    {
        public List<string> User = new List<string>();
        public List<string> Dealer = new List<string>();
        public void Deal()
        {
            Random rand = new Random();
            var cardDealt = new Card().DisplayName;
            var deck = new CreateDeck().;
            deck.

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(GetRandomCard());
            }

            for (int i = 0; i < 2; i++)
            {
                User.Add(cardDealt);
                Dealer.Add(cardDealt);
            }
            Console.WriteLine(User[0]);
            Console.WriteLine(User[1]);
            Console.WriteLine(Dealer[0]);
            Console.WriteLine(Dealer[1]);



        }
    }
}