namespace CodingChallenge.CardGame
{
    public class PackOfCardsCreator : IPackOfCardsCreator
    {
        public IPackOfCards Create() => new PackOfCards();
    }
}
