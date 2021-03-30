using NUnit.Framework;

namespace CodingChallenge.CardGame.Tests
{
    [TestFixture]
    public class PackOfCardsShould
    {
        [Test]
        public void Have52CardsWhenCreated()
        {
            // Arrange
            var sut = new PackOfCardsCreator().Create();

            // Act
            var result = sut.Count;

            // Assert
            Assert.AreEqual(52, result);
        }

        [Test]
        public void ReturnFirstCardAsAceClubsOnCreation()
        {
            // Arrange
            var sut = new PackOfCardsCreator().Create();

            // Act
            var result = sut.TakeCardFromTopOfPack();

            // Assert
            Assert.IsTrue(result.Equals(new Card(Suit.Clubs, Value.Ace)));
        }

        [Test]
        public void ReturnCardFromTopOfPackAndHave51Cards()
        {
            // Arrange
            var sut = new PackOfCardsCreator().Create();

            // Act
            var result = sut.TakeCardFromTopOfPack();

            // Assert
            Assert.IsTrue(result.Equals(new Card(Suit.Clubs, Value.Ace)));
            Assert.AreEqual(51, sut.Count);
        }

        [Test]
        public void Have1CardWhen51CardsTakenFromTop()
        {
            // Arrange
            var sut = new PackOfCardsCreator().Create();

            // Act
            for (int i = 0; i <= 50; i++)
                sut.TakeCardFromTopOfPack();
            var result = sut.Count;

            // Assert
            Assert.AreEqual(1, result);
        }

        [Test]
        public void Have0CardsWhen52CardsTakenFromTop()
        {
            // Arrange
            var sut = new PackOfCardsCreator().Create();

            // Act
            for (int i = 0; i <= 51; i++)
                sut.TakeCardFromTopOfPack();
            var result = sut.Count;

            // Assert
            Assert.AreEqual(0, result);
        }

        [Test]
        public void ReturnNullWhenPackEmptyAndCardTakenFromTop()
        {
            // Arrange
            var sut = new PackOfCardsCreator().Create();

            // Act
            for (int i = 0; i <= 51; i++)
                sut.TakeCardFromTopOfPack();
            var result = sut.TakeCardFromTopOfPack();

            // Assert
            Assert.IsNull(result);
        }

        [Test]
        public void ShouldHave52CardsWhenTakeOneCardThenShuffle()
        {
            // Arrange
            var sut = new PackOfCardsCreator().Create();

            // Act
            sut.TakeCardFromTopOfPack();
            var resultAfterTake = sut.Count;
            sut.Shuffle();
            var resultAfterShuffle = sut.Count;

            // Assert
            Assert.AreEqual(51, resultAfterTake);
            Assert.AreEqual(52, resultAfterShuffle);
        }

        [Test]
        public void NotHaveFirstCardAsAceClubsWhenShuffle()
        {
            // Arrange
            var sut = new PackOfCardsCreator().Create();

            // Act
            sut.Shuffle();

            // Assert
           Assert.IsFalse(sut.TakeCardFromTopOfPack().Equals(new Card(Suit.Clubs, Value.Ace)));
        }

        [Test]
        public void NotHaveSecondCardAsTwoClubsWhenShuffle()
        {
            // Arrange
            var sut = new PackOfCardsCreator().Create();

            // Act
            sut.Shuffle();

            // Assert
            Assert.IsFalse(sut.TakeCardFromTopOfPack().Equals(new Card(Suit.Clubs, Value.Two)));
        }

        [Test]
        public void BeAbleToIterateOver()
        {
            // Arrange
            var sut = new PackOfCardsCreator().Create();
            var counter = 0;

            // Act
            foreach(var item in sut)
            {
                counter++;
            }

            // Assert
            Assert.AreEqual(52, counter);
        }
    }
}
