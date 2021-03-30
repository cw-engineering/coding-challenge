using NUnit.Framework;

namespace CodingChallenge.ReversingString.Tests
{
    [TestFixture]
    public class ReverseStringShould
    {
        [Test]
        public void ReturnStringInReverseOrder()
        {
            // Arrange

            // Act
            var result = StringUtilities.Reverse("FooBazQux");

            // Assert
            Assert.AreEqual("xuQzaBooF", result);
        }

        [Test]
        public void ReturnStringWithSpaceInReverseOrder()
        {
            // Arrange

            // Act
            var result = StringUtilities.Reverse("Hello Bar");

            // Assert
            Assert.AreEqual("raB olleH", result);
        }

        [Test]
        public void ReturnStringWithNumbersInReverseOrder()
        {
            // Arrange

            // Act
            var result = StringUtilities.Reverse("Hello123Bar");

            // Assert
            Assert.AreEqual("raB321olleH", result);
        }

        [Test]
        public void ReturnStringWithNonAlphaInReverseOrder()
        {
            // Arrange

            // Act
            var result = StringUtilities.Reverse("HelloBar%*(£");

            // Assert
            Assert.AreEqual("£(*%raBolleH", result);
        }

        [Test]
        public void ReturnStringWithOnlyOneCharInReverseOrder()
        {
            // Arrange

            // Act
            var result = StringUtilities.Reverse("a");

            // Assert
            Assert.AreEqual("a", result);
        }

        [Test]
        public void ReturnEmptyStringInReverseOrder()
        {
            // Arrange

            // Act
            var result = StringUtilities.Reverse("");

            // Assert
            Assert.AreEqual("", result);
        }
    }
}
