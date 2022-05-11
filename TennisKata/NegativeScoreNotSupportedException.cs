using System;

namespace TennisKata
{
    internal class NegativeScoreNotSupportedException : Exception
    {
        public NegativeScoreNotSupportedException()
        {
        }

        public NegativeScoreNotSupportedException(string? message) : base(message)
        {
        }
    }
}