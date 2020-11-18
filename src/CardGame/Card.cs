namespace CodingChallenge.CardGame
{
    public class Card : ICard
    {
        public Suit Suit { get; set; }
        public Value Value { get; set; }

        public Card(Suit suit, Value value)
        {
            Suit = suit;
            Value = value;
        }

        public bool Equals(ICard other) => Suit == other.Suit && Value == other.Value;
    }
}