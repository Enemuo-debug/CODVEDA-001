using System;

namespace BankAppIllustration
{
    public class InvalidPinException : Exception
    {
        public InvalidPinException()
        {
        }

        public InvalidPinException(string message)
            : base(message)
        {
        }

        public InvalidPinException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }

    public class AccountNotFoundException : Exception
    {
        public AccountNotFoundException()
        {
        }

        public AccountNotFoundException(string message)
            : base(message)
        {
        }

        public AccountNotFoundException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
