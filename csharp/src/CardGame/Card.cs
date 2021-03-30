using System;

namespace CodingChallenge.CardGame
{
    public class Card : ICard
    {
        private readonly Suit _suit;
        private readonly Value _value;

        public Card(Suit suit, Value value)
        {
            _suit = suit;
            _value = value;
        }


        public Suit Suit => _suit;

        public Value Value => _value;

        public bool Equals(ICard other) => (other.Suit == _suit) && (other.Value == _value) ? true : false;


        // If implementing Equals for IEquatable then should override Equals and Hashcode
        // Note: Not overriding the == and != operators in this case since Equals is sufficient for this example.

        public override bool Equals(Object obj)
        {
            if (obj == null)
                return false;

            Card cardObj = obj as Card;
            if (cardObj == null)
                return false;
            else
                return Equals(cardObj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_suit, _value);
        }
    }
}
