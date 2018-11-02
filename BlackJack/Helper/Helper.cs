using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BlackJack
{
    
    class Helper
    
    {
        Dictionaries dictionary = new Dictionaries();
        Random rand = new Random();
        public KeyValuePair<string, int> GetRandomCard()
        {
           var data = dictionary.cardDeck;
           return data.ElementAt(rand.Next(0, data.Count));
        }

        public void Dealing()
        {
            var deal = GetRandomCard();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(GetRandomCard());
            }

        }
    }
}
