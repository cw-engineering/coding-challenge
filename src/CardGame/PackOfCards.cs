using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CodingChallenge.CardGame
{
    public class PackOfCards : IPackOfCards
    {
        private List<ICard> _cards;
        private List<ICard> _removedCards;

        public PackOfCards(List<ICard> cards)
        {
            _cards = cards;
            _removedCards = new List<ICard>();
        }

        public void Shuffle()
        {
            var randomGen = new Random();
            _cards.AddRange(_removedCards);
            int cardsCount = _cards.Count;
            for (int currentCardNr = 0; currentCardNr < _cards.Count; currentCardNr++)
            {
                int randomCardNr = randomGen.Next(0, cardsCount);
                var firstCard = _cards[currentCardNr];
                _cards[currentCardNr] = _cards[randomCardNr];
                _cards[randomCardNr] = firstCard;
            }
        }

        public ICard TakeCardFromTopOfPack()
        {
            var removedCard = _cards.First();
            _removedCards.Add(removedCard);
            _cards.Remove(removedCard);
            return removedCard;
        }

        IEnumerator<ICard> IEnumerable<ICard>.GetEnumerator() => _cards.GetEnumerator();

        public IEnumerator GetEnumerator() => _cards.GetEnumerator();

        int IReadOnlyCollection<ICard>.Count => _cards.Count();
    }
}