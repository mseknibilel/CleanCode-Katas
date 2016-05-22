using System;

namespace SolidPrinciples.Utilities.Exceptions
{
    public class OrderException : Exception
    {
        public OrderException(string exceptionMessage):
            base(exceptionMessage)
        {
        }

        public OrderException(string exceptionMessage, Exception innerException) :
    base(exceptionMessage, innerException)
        {
        }
    }
}