namespace LocalMess.Domain.Exceptions.ValueObjects.User
{
    public class InvalidUsernameException : BaseDomainException
    {
        public InvalidUsernameException(string message) : base(message) { }
    }
}
