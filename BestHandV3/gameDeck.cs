using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestHandV3
{
    public class gameDeck
    {
        private List<Card> deckOfCards = new List<Card>();
        private List<List<Card>> eachHand = new List<List<Card>>();
        private List<Card> cardShuffle = new List<Card>();

        public gameDeck()
        {
           
        }
        public gameDeck(int minCard, int maxCard)
        {
            
        }

        public List<Card> Shuffle()
        {
            Random random  = new Random();
            IOrderedEnumerable<Card> shuffle = deckOfCards.OrderBy(Card => random.Next());
            shuffle.GetEnumerator();
            return shuffle.ToList<Card>();
        }
    }
}

