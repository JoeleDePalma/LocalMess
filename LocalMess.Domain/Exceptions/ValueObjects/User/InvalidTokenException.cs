using System;
using System.Collections.Generic;
using System.Text;

namespace LocalMess.Domain.Exceptions.ValueObjects.User
{
    public class InvalidTokenException : BaseDomainException
    {
        public InvalidTokenException(string message) : base(message) { }
    }
}
