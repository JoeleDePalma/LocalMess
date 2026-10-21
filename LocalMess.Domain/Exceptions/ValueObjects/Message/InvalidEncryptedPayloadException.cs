namespace LocalMess.Domain.Exceptions.ValueObjects.Message
{
    public class InvalidEncryptedPayloadException : BaseDomainException
    {
        /// <summary>
        /// Exception thrown when the encrypted payload has invalid parameters.
        /// </summary>
        /// <param name="message">Error message.</param>
        public InvalidEncryptedPayloadException(string message) : base(message) { }
    }
}
