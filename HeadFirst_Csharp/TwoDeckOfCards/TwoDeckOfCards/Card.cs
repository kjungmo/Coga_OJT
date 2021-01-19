using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDeckOfCards
{
    class Card
    {
        public Suit Suits { get; set; }
        public Value Values { get; set; }

        public Card(Suit suits, Value values)
        {
            this.Suits = suits;
            this.Values = values;
        }

        public string Name
        {
            get
            {
                return Values.ToString() + " of " + Suits.ToString();
            }
        }
        
        public override string ToString()
        {
            return Name;
        }

        public static bool DoesCardMatch(Card cardToCheck, Suit suit)
        {
            if (cardToCheck.Suits == suit)
                return true;
            else
                return false;
        }

        public static bool DoesCardMatch(Card cardToCheck, Value value)
        {
            if (cardToCheck.Values == value)
                return true;
            else
                return false;
        }
    }

}
