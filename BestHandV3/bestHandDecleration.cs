using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestHandV3
{
    public class bestHandDecleration : gameDeck
    {
            private List<Card> _Hand = new List<Card>();

            public bestHandDecleration(int card)
            {
                List<Card> playerOne = new List<Card>();
            }

            // conclusion to the game
            public int HandTotal(List<Card> hand)
            {
                int total = hand.Sum(face => face.cardValue);

                return total;
            }

        }
    }
