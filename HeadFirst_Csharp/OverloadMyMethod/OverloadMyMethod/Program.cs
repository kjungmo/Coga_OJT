using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadMyMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Card cardTocheck = new Card(Suit.Clubs, Value.Three);
            bool doesItMatch = Card.DoesCardMatch(cardTocheck, Suit.Hearts);
            Console.WriteLine(doesItMatch);

            Console.ReadKey();
        }
    }
}
