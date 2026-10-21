namespace LocalMess.Domain.Exceptions.ValueObjects.GroupChat
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
