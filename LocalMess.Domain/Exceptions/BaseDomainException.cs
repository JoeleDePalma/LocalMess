namespace LocalMess.Domain.Exceptions
{
    public abstract class BaseDomainException : Exception
    {
        /// <summary>
        /// Base class for all domain-specific exceptions.
        /// </summary>
        /// <param name="message">Error message.</param>
        public BaseDomainException(string message) : base(message) { }
    }
}