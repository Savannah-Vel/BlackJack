using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace _21
    {
        class Program
        {
        private static List<Card> Deck = new List<Card>();
        static int playerTotal;
        private static Random rnd = new Random();
        private static List<int> Player = new List<int>();
        private static List<int> Dealer = new List<int>();
        private static Card card = new Card();

        static void Main(string[] args)
            {
            Deal();
                foreach (var item in CreateDeck())
                {
                  //  Console.WriteLine(item.DisplayName);
                }
                Console.ReadLine();
            }
        private static readonly Dictionary<string, int> CardNames = new Dictionary<string, int>()
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
        private static readonly List<string> CardTypes = new List<string>()
        {
            "Spades", "Hearts", "Clubs", "Diamonds"
        };

        public static List<Card> CreateDeck()
        {
            var deck = new List<Card>();
            foreach (var type in CardTypes)
            {
                foreach (var name in CardNames)
                {
                    deck.Add(
                     new Card()
                     {
                         CardType = type,
                         CardName = name.Key,
                         DisplayName = $"{name.Key} of {type}",
                         CardValue = name.Value,
                     }
                    );
                }
            }
            return deck;
        }


        public static void DealSingleCard(string user)
        {
            Deck = CreateDeck();

            var index = rnd.Next(Deck.Count);
            var value = Deck[index].CardValue;
            if (user == "Player")
            {
                Player.Add(value);
            }
            if (user == "Dealer")
            {
                Dealer.Add(value);
            }
            //Player.Add(value);
        }
        public static List<int> Deal()
        {
            for (int i = 0; i < 2; i++)
            {
                DealSingleCard("Player");
                DealSingleCard("Dealer");
            }

            Console.WriteLine("Dealer's Hand");
            Console.WriteLine(Dealer[0]);
            Console.WriteLine("[hidden]");
            //Console.WriteLine(Dealer[1]);
            Console.WriteLine("Player's Hand");
            Console.WriteLine(Player[1]);
            Console.WriteLine(Player[0]);
            Console.WriteLine("Card Total");
            CardsTotal();
            PlayerDecision();
            CardsTotal();
            //var playerTotal = User.Sum();
            //Console.WriteLine("Card Total");
            //
            return Player;
            //return Dealer;
            //split card dealt into dealing per person
            //edit writeline to make readable for player
            //add method to total cards
        }
        public static int CardsTotal()
        {
            playerTotal = Player.Sum();
            Console.WriteLine(playerTotal);
            return playerTotal;
        }


        public static void PlayerDecision()
        {
            //var deal = new BlackJack().Deal();
            // var total = new BlackJack().playerTotal;

            //Deal();
            //CardsTotal();
            if (playerTotal == 21)
            {
                Console.WriteLine("Player has 21!");
                return;


            }
            if (playerTotal <= 10)
            {
                DealSingleCard("Player");


                //Console.WriteLine(playerTotal);
            }

            if (playerTotal > 10 && playerTotal < 15)
            {
                DealSingleCard("Dealer");
                //Console.WriteLine(playerTotal);
            }
            else
            {
                Console.WriteLine("No blackjack!");
            }

            //if (playerTotal <= 10)
            //{
            //    DealSingleHand;
            //}
        }
        public class Card
        {
            public string CardType { get; set; }
            public int CardValue { get; set; }
            public string CardName { get; set; }
            public string DisplayName { get; set; }

        }




    }
    }