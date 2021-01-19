using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomCards
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
    }

}
