using System;
using System.Collections.Generic;
using System.Text;

namespace LocalMess.Domain.Exceptions.ValueObjects.User
{
    public class InvalidRefreshTokenException : BaseDomainException
    {
        /// <summary>
        /// Exception thrown when the refresh token has invalid parameters.
        /// </summary>
        /// <param name="message">Error message.</param>
        public InvalidRefreshTokenException(string message) : base(message) { }
    }
}
