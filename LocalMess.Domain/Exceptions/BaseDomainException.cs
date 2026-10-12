namespace LocalMess.Domain.Exceptions
{
    public class BaseDomainException : Exception
    {
        public BaseDomainException(string message) : base(message) { }
    }
}
