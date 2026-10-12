namespace LocalMess.Domain.Exceptions.ValueObjects.User
{
    public class InvalidUsernameException : BaseDomainException
    {
        /// <summary>
        /// Exception thrown when the username has invalid parameters.
        /// </summary>
        /// <param name="message">Error message.</param>
        public InvalidUsernameException(string message) : base(message) { }
    }
}
