using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerWithEnum
{
    class Card
    {
        public Suit suits { get; set; }
        public Value values { get; set; }

        public string Name 
        { 
            get
            {
                return values.ToString() + " of " + suits.ToString();
            }
        }

        public Card(Suit suits, Value values)
        {
            this.suits = suits;
            this.values = values;
        }
    }

}
