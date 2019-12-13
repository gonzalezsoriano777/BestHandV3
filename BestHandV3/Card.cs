using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestHandV3
{
    public class Card
    {
        public int cardValue;
        public int cardSuit;

        public string[] values = { "Ace", "King", "Queen", "Jack" };

        public Card()
        {
            Random newCard = new Random();
            Random newSuit = new Random();

            this.cardValue = newCard.Next(1, 13);
            this.cardSuit = newSuit.Next(0, 3);           
        }

        public Card(int CardValue, int CardSuit)
        {
            this.cardValue = CardValue;
            this.cardSuit = CardSuit;
        }

        public string suitNames()
        {
            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };

            return values[this.cardSuit];
        }

    }
}
