using System;
using System.Collections.Generic;
using System.Text;


namespace CodingChallenge.CardGame
{
    public interface ICard : IEquatable<ICard>
    {
        Suit Suit { get; set; }

        Value Value { get; set; }
    }
}
