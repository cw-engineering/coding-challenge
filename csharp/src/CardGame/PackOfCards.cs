using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace CodingChallenge.CardGame
{
    public class PackOfCards : IPackOfCards
    {
        private const int MaxCards = 51;
        private List<ICard> _pack;

        public PackOfCards()
        {
            ResetPack();
        }

        private void ResetPack()
        {
            _pack = new();
            foreach (Suit suit in Enum.GetValues(typeof(Suit)))
            {
                foreach (Value value in Enum.GetValues(typeof(Value)))
                {
                    _pack.Add(new Card(suit, value));
                }
            }
        }

        public int Count => _pack.Count();

        public void Shuffle()
        {
            ResetPack();
            for (int i = 0; i <= MaxCards; i++)
            {
                var r = new Random();
                int randomCard = r.Next(0, MaxCards);
                SwapCards(i, randomCard);
            }
        }

        private void SwapCards(int i, int randNum)
        {
            var temp = _pack[i];
            _pack[i] = _pack[randNum];
            _pack[randNum] = temp;
        }

        public ICard TakeCardFromTopOfPack()
        {
            /// TODO: What to return when pack empty? Assume null for the time being
            if (_pack.Count() == 0)
                return null;

            var card = _pack.FirstOrDefault();
            _pack.RemoveAt(0);
            return card;
        }

        public IEnumerator<ICard> GetEnumerator()
        {
            foreach(ICard card in _pack)
            {
                yield return card;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

    }
}
