namespace LocalMess.Domain.Exceptions.ValueObjects.GroupChat
{
    public class InvalidChatNameException : BaseDomainException
    {
        /// <summary>
        /// Exception thrown when the chat name has invalid parameters.
        /// </summary>
        /// <param name="message">Error message.</param>
        public InvalidChatNameException(string message) : base(message) { }
    }
}
