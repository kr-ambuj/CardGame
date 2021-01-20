using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Program
    {
        public static CardDeck cardDeck;
        static void Main(string[] args)
        {
            cardDeck = new CardDeck();
            DisplayPart();
        }

        /// <summary>
        /// Displaying the messages for input and capturing the input.
        /// </summary>
        private static void DisplayPart()
        {
            Console.WriteLine("Press 1 to Play a Card:");
            Console.WriteLine("Press 2 to Shuffle the Deck:");
            Console.WriteLine("Press 3 to Restart the Game:");
            string input = Console.ReadLine();
            switch(input)
            {
                case "1":
                    Console.WriteLine(cardDeck.GetTopCard());
                    Console.WriteLine();
                    break;
                case "2":                    
                    Console.WriteLine(cardDeck.ShuffleDeck());
                    Console.WriteLine();
                    break;
                case "3":
                    cardDeck = new CardDeck();
                    Console.WriteLine("New Deck Created.");
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Please choose a correct option from given list!!");
                    break;
            }
            DisplayPart();
        }
    }
}
