using LocalMess.Domain.Exceptions.ValueObjects.User;

namespace LocalMess.Domain.ValueObjects.User
{
    /// <summary>
    /// Represents a JWT token value object used for authentication and authorization.
    /// </summary>
    public class AccessToken
    {
        private readonly string _value;
        public string Value { get => _value; }

        /// <summary>
        /// Validates and assigns the JWT token value.
        /// </summary>
        /// <param name="value">The raw JWT token string.</param>
        /// <exception cref="InvalidAccessTokenException">
        /// Thrown if the token is null or whitespace, 
        /// or does not follow the standard JWT format.
        /// </exception>
        public AccessToken(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new InvalidAccessTokenException("Acces token cannot be null or whitespace.");

            if (!value.Contains('.'))
                throw new InvalidAccessTokenException("Invalid JWT access token format.");

            _value = value;
        }
    }
}
