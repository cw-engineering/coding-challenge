using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.CardGame
{
    public interface IPackOfCardsCreator
    {
        public IPackOfCards Create()
        {
            var cards = new List<ICard>();
            foreach (Suit suit in (Suit[])Enum.GetValues(typeof(Suit)))
            {
                foreach (Value value in (Value[])Enum.GetValues(typeof(Value)))
                {
                    ICard card = new Card(suit, value);
                    cards.Add(card);
                }
            }
            var packOfCards = new PackOfCards(cards);
            return packOfCards;
        }
    }
}
