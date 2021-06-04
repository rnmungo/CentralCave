using System;

namespace BLL.CentralCave.BusinessExceptions
{
    public class InvalidCredentialsException : Exception
    {
        public InvalidCredentialsException() { }

        public InvalidCredentialsException(string message) : base(message) { }

        public InvalidCredentialsException(string message, Exception inner) : base(message, inner) { }
    }
}
