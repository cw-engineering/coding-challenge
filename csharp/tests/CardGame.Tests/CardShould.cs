using NUnit.Framework;

namespace CodingChallenge.CardGame.Tests
{
    [TestFixture]
    public class CardShould
    {
        [Test]
        public void ReturnEqualWhenSuitAndValueOfBothCardsAreSame()
        {
            // Arrange
            var card = new Card(Suit.Clubs, Value.Ace);
            var otherCard = new Card(Suit.Clubs, Value.Ace);

            // Act
            var result = card.Equals(otherCard);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void ReturnNotEqualWhenCardsAreDifferentByValue()
        {
            // Arrange
            var card = new Card(Suit.Clubs, Value.Eight);
            var otherCard = new Card(Suit.Clubs, Value.Ace);

            // Act
            var result = card.Equals(otherCard);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void ReturnNotEqualWhenCardsAreDifferentBySuit()
        {
            // Arrange
            var card = new Card(Suit.Diamonds, Value.Ace);
            var otherCard = new Card(Suit.Clubs, Value.Ace);

            // Act
            var result = card.Equals(otherCard);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void ReturnNotEqualWhenCardsAreDifferentBySuitAndValue()
        {
            // Arrange
            var card = new Card(Suit.Diamonds, Value.Four);
            var otherCard = new Card(Suit.Clubs, Value.Ace);

            // Act
            var result = card.Equals(otherCard);

            // Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void ReturnDifferentHashcodesForDifferentCards()
        {
            // Arrange
            var card = new Card(Suit.Diamonds, Value.Four);
            var otherCard = new Card(Suit.Clubs, Value.Ace);

            // Act
            var cardHash = card.GetHashCode();
            var otherCardHash = otherCard.GetHashCode();

            // Assert
            Assert.AreNotEqual(cardHash, otherCardHash);
        }

        [Test]
        public void ReturnSameHashcodeForSameCard()
        {
            // Arrange
            var card = new Card(Suit.Diamonds, Value.Four);
            var otherCard = new Card(Suit.Clubs, Value.Ace);

            // Act
            var cardHash1 = card.GetHashCode();
            var cardHash2 = card.GetHashCode();

            // Assert
            Assert.AreEqual(cardHash1, cardHash2);
        }
    }
}
