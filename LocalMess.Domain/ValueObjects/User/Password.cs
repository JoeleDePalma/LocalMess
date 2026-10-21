using LocalMess.Domain.Exceptions.ValueObjects.User;

namespace LocalMess.Domain.ValueObjects.User
{
    /// <summary>
    /// Represents a plain-text password value object used to validate user input.
    /// </summary>
    public class Password
    {
        private readonly string _value;
        public string Value { get => _value; }

        /// <summary>
        /// Validates and assigns the plain-text password value.
        /// </summary>
        /// <param name="value">
        /// Password value.
        /// </param>
        /// <exception cref="InvalidPasswordException">
        /// Thrown if the password is null or whitespace, shorter than 8 characters,
        /// or missing at least one digit, one uppercase letter, one lowercase letter,
        /// or one special character.
        /// </exception>
        public Password(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new InvalidPasswordException("Password null or whitespace.");

            if (value.Length < 8)
                throw new InvalidPasswordException("Password too short.");

            if (!value.Any(char.IsDigit))
                throw new InvalidPasswordException("Password must contain at least one digit.");

            if (!value.Any(char.IsUpper))
                throw new InvalidPasswordException("Password must contain at least one uppercase letter.");

            if (!value.Any(char.IsLower))
                throw new InvalidPasswordException("Password must contain at least one lowercase letter.");

            if (!value.Any(x => char.IsPunctuation(x) || char.IsSymbol(x)))
                throw new InvalidPasswordException("Password must contain at least one special character.");

            _value = value;
        }
    }
}