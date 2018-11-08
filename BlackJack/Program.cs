using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace _21
    {
        class Program
        {
        

        static void Main(string[] args)
            {
            var x = new BlackJack();
            x.Deal();
                foreach (var item in new CreateDeck().Deck)
                {
                  //  Console.WriteLine(item.DisplayName);
                }
                Console.ReadLine();
            }


        

        
        }
    }