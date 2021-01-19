using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Five random Cards : ");
            List<Card> cards = new List<Card>();

            for (int i = 0; i < 5; i++)
            {
                cards.Add(new Card((Suit)random.Next(4), (Value)random.Next(1, 14)));
                Console.WriteLine(cards[i].Name);
            }

            Console.WriteLine();
            Console.WriteLine("Those same Cards, sorted :");
            cards.Sort(new CardComparerByValue());
            foreach (Card card in cards)
            {
                Console.WriteLine(card.Name);
            }
            Console.ReadKey();
        }
    }
}
