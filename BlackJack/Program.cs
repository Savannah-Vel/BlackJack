using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {
        public Dictionary<string, int> cardDeck = new Dictionary<string, int>()
        {
            {"AH", 1},
            {"AS", 1},
            {"AD", 1},
            {"AC", 1},
            {"2H", 2},
            {"2S", 2},
            {"2D", 2},
            {"2C", 2},
            {"3H", 3},
            {"3S", 3},
            {"3D", 3},
            {"3C", 3},
            {"4H", 4},
            {"4S", 4},
            {"4D", 4},
            {"4C", 4},
            {"5H", 5},
            {"5S", 5},
            {"5D", 5},
            {"5C", 5},
            {"6H", 6},
            {"6S", 6},
            {"6D", 6},
            {"6C", 6},
            {"7H", 7},
            {"7S", 7},
            {"7D", 7},
            {"7C", 7},
            {"8H", 8},
            {"8S", 8},
            {"8D", 8},
            {"8C", 8},
            {"9H", 9},
            {"9S", 9},
            {"9D", 9},
            {"9C", 9},
            {"10H", 10},
            {"10S", 10},
            {"10D", 10},
            {"10C", 10},
            {"JH", 10},
            {"JS", 10},
            {"JD", 10},
            {"JC", 10},
            {"QH", 10},
            {"QS", 10},
            {"QD", 10},
            {"QC", 10},
            {"KH", 10},
            {"KS", 10},
            {"KD", 10},
            {"KC", 10}
        };
        public IEnumerable<TValue> RandomValues<TKey, TValue>(IDictionary<TKey, TValue> dict)
        {
            Random rand = new Random();
            List<TValue> values = Enumerable.ToList(Dict.Values);
        }



        //static void Main(string[] args)
        //{
        //    // The code provided will print ‘Hello World’ to the console.
        //    // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
        //    Console.WriteLine("Hello World!");
        //    Console.ReadKey();

        //    // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        //}
    }
}
