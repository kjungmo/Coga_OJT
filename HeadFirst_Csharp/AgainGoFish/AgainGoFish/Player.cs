using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace AgainGoFish
{
    class Player
    {
        private string name;
        public string Name { get { return name; } }
        private Random random;
        private Deck cards;
        private Game game;

        public Player(string name, Random random, Game game)
        {
            this.name = name;
            this.random = random;
            this.game = game;
            this.cards = new Deck(new Card[] { });
            game.AddProgress(name + " has just joined the game");
        }

        public IEnumerable<Value> PullOutBooks()
        {
            List<Value> books = new List<Value>();
            for (int i = 1; i <= 13; i++)
            {
                Value value = (Value)i;
                int howMany = 0;
                for (int card = 0; card < cards.Count; card++)
                {
                    if (cards.Peek(card).Values == value)
                        howMany++;
                }
                if (howMany == 4)
                {
                    books.Add(value);
                    cards.PullOutValues(value);
                }
            }
            return books;
        }

        public Value GetRandomValue()
        {
            Card randomCard = cards.Peek(random.Next(cards.Count));
            return randomCard.Values;
        }

        public Deck DoYouHaveAny(Value value)
        {
            Deck cardsIHave = cards.PullOutValues(value);
            game.AddProgress(Name + " has " + cardsIHave.Count + " " + Card.Plural(value));
            return cardsIHave;
        }

        public void AskForACard(List<Player> players, int myIndex, Deck stock)
        {
            if (stock.Count > 0)
            {
                if (cards.Count == 0)
                {
                    cards.Add(stock.Deal());
                }
                Value randomValue = GetRandomValue();
                AskForACard(players, myIndex, stock, randomValue);
                if (stock.Count > 0 && players[0].CardCount == 0)
                    players[0].cards.Add(stock.Deal());
            }
        }

        public void AskForACard(List<Player> players, int myIndex, Deck stock, Value value)
        {
            game.AddProgress(Name + " asks if anyone has a " + value);
            int totalCardsGiven = 0;
            for (int i = 0; i < players.Count; i++)
            {
                if (i != myIndex)
                {
                    Player player = players[i];
                    Deck cardsGiven = player.DoYouHaveAny(value);
                    totalCardsGiven += cardsGiven.Count;
                    while (cardsGiven.Count > 0)
                    {
                        cards.Add(cardsGiven.Deal());
                    }
                }
            }
            if (totalCardsGiven == 0 && stock.Count > 0)
            {
                game.AddProgress(Name + " must draw from the stock.");
                cards.Add(stock.Deal());
            }
        }

        public int CardCount { get { return cards.Count; } }
        public void TakeCard(Card card) { cards.Add(card); }
        public IEnumerable<string> GetCardNames() { return cards.GetCardNames(); }
        public Card Peek(int cardNumber) { return cards.Peek(cardNumber); }
        public void SortHand() { cards.SortByValue(); }

    }
}
