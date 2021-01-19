using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadMyMethod
{
    class Card
    {
        public Suit Suits { get; set; }
        public Value Values { get; set; }

        public string Name 
        { 
            get
            {
                return Values.ToString() + " of " + Suits.ToString();
            }
        }

        public Card(Suit suits, Value values)
        {
            this.Suits = suits;
            this.Values = values;
        }

        public override string ToString()
        {
            return Name;
        }

        public static bool DoesCardMatch ( Card cardToCheck, Suit suit)
        {
            if (cardToCheck.Suits == suit)
                return true;
            else
                return false;
        }

        public static bool DoesCardMatch ( Card cardToCheck, Value value)
        {
            if (cardToCheck.Values == value)
                return true;
            else
                return false;
        }
    }

}
