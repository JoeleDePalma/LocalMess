namespace LocalMess.Domain.Exceptions.ValueObjects.User
{
    public class InvalidAccessTokenException : BaseDomainException
    {
        /// <summary>
        /// Exception thrown when the access token has invalid parameters.
        /// </summary>
        /// <param name="message">Error message.</param>
        public InvalidAccessTokenException(string message) : base(message) { }
    }
}
