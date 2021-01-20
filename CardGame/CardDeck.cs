using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class CardDeck
    {
        string[] valueSet = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
        string[] suitsSet = { "Clubs", "Hearts", "Spades", "Diamond" };
        List<string> cardDeckSet;

        public CardDeck()
        {
            cardDeckSet = new List<string>();
            CreateDeck();
        }

        //Creating a deck.
        private void CreateDeck()
        {
            foreach (string suite in suitsSet)
            {
                foreach(string value in valueSet)
                {
                    cardDeckSet.Add($"{value} of {suite}");
                }
            }
            ShuffleDeck();
        }

        /// <summary>
        /// Shuffling the current deck.
        /// </summary>
        public string ShuffleDeck()
        {
            if (cardDeckSet.Count > 0)
            {
                Random random = new Random();
                int deckSize = cardDeckSet.Count;
                string[] tempDeck = cardDeckSet.ToArray();
                cardDeckSet.Clear();
                while (true)
                {
                    int pos = random.Next(tempDeck.Length);
                    string card = tempDeck[pos];
                    if (!cardDeckSet.Contains(card))
                    {
                        cardDeckSet.Add(card);
                        if (cardDeckSet.Count == deckSize)
                            break;
                    }
                }
                return "Current Deck Shuffled.";
            }
            else
                return "Really!! shuffling a deck without cards.";
        }

        /// <summary>
        /// Getting the top carrd from the Deck.
        /// </summary>
        /// <returns></returns>
        public string GetTopCard()
        {
            if (cardDeckSet.Count > 0)
            {
                string value = cardDeckSet.First();
                cardDeckSet.Remove(value);
                return value;
            }
            else
                return "Reached end of deck, start another game.";
        }
    }
}
