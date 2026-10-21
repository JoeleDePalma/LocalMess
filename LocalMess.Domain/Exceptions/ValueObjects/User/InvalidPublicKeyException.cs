namespace LocalMess.Domain.Exceptions.ValueObjects.User
{
    public class InvalidPublicKeyException : BaseDomainException
    {
        /// <summary>
        /// Exception thrown when the public key has invalid parameters.
        /// </summary>
        /// <param name="message">Error message.</param>
        public InvalidPublicKeyException(string message) : base(message) { }
    }
}
