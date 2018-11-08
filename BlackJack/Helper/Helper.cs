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
        public Random rnd = new Random();
        public List<int> User = new List<int>();
        public List<int> Dealer = new List<int>();
        public void Deal()
        {
            //var cardDealt = new Card().DisplayName;
            var deck = new CreateDeck().Deck;
            int index;
            
            //for (int i = 0; i < 4; i++)
            //{
                
            //    Console.WriteLine(cardDealt);
            //}

            for (int i = 0; i < 2; i++)
            {
                index = rnd.Next(deck.Count);
                var value = deck[index].CardValue;
                User.Add(value);
                index = rnd.Next(deck.Count);
                value = deck[index].CardValue;
                Dealer.Add(value);
            }
            Console.WriteLine(User[0]);
            Console.WriteLine(Dealer[0]);
            Console.WriteLine(User[1]);
            Console.WriteLine(Dealer[1]);

            //split card dealt into dealing per person
            //edit writeline to make readable for player
            //add method to total cards

        }
    }
}