namespace LocalMess.Domain.Exceptions.ValueObjects.User
{
    public class InvalidPasswordException : BaseDomainException
    {
        /// <summary>
        /// Exception thrown when the password has invalid parameters.
        /// </summary>
        /// <param name="message">Error message.</param>
        public InvalidPasswordException(string message) : base(message) { }
    }
}
