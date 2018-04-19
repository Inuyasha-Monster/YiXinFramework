using System;

namespace YiXin.Core
{
    public class KnownException : Exception
    {
        public KnownException(string message) : base(message)
        {

        }

        public KnownException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}