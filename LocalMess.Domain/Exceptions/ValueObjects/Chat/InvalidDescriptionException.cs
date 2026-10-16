using System;
using System.Collections.Generic;
using System.Text;

namespace LocalMess.Domain.Exceptions.ValueObjects.Chat
{
    public class InvalidDescriptionException : BaseDomainException
    {
        /// <summary>
        /// Exception thrown when the chat description has invalid parameters.
        /// </summary>
        /// <param name="message">Error message.</param>
        public InvalidDescriptionException(string message) : base(message) { }
    }
}
