using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDeckOfCards
{
    class Deck
    {
        private List<Card> cards;
        private Random random = new Random();

        public Deck()
        {
            cards = new List<Card>();
            for (int suits = 0; suits <= 3; suits++)
            {
                for (int values = 1; values <= 13; values++)
                {
                    cards.Add(new Card((Suit)suits, (Value)values));
                }
            }
        }
        
        public Deck(IEnumerable<Card> initialCards)
        {
            cards = new List<Card>(initialCards);
        }

        public int Count 
        { 
            get
            {
                return cards.Count;
            }
        }

        public void Add(Card cardToAdd)
        {
            cards.Add(cardToAdd);
        }

        public Card Deal(int index)
        {
            Card cardToDeal = cards[index];
            cards.RemoveAt(index);
            return cardToDeal;
        }

        public void Shuffle()
        {
            List<Card> newCards = new List<Card>();
            while (cards.Count > 0)
            {
                int cardToMove = random.Next(cards.Count);
                newCards.Add(cards[cardToMove]);
                cards.RemoveAt(cardToMove);
            }
            cards = newCards;
        }

        public IEnumerable<string> GetCardNames()
        {
            string[] CardNames = new string[cards.Count];
            for (int i = 0; i < cards.Count; i++)
            {
                CardNames[i] = cards[i].Name;
            }
            return CardNames;
        }

        public void Sort()
        {
            cards.Sort(new CardComparerBySuit());
        }

    }
}
