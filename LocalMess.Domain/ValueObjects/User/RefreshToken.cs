using System;
using System.Collections.Generic;
using System.Text;
using LocalMess.Domain.Exceptions.ValueObjects.User;

namespace LocalMess.Domain.ValueObjects.User
{
    /// <summary>
    /// Represents the refresh token value object used to maintain long-lived authentication session.
    /// </summary>
    public class RefreshToken
    {
        private readonly string _value;
        public string Value { get => _value;  }

        /// <summary>
        /// Validates and assigns the refresh token value.
        /// </summary>
        /// <param name="value">
        /// Refresh token value.
        /// </param>
        /// <exception cref="InvalidRefreshTokenException">
        /// Thrown if the refresh token is null or whitespace, 
        /// or shorter than 32 characters
        /// </exception>
        public RefreshToken(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new InvalidRefreshTokenException("Refresh token cannot be null or whitespace.");

            if (value.Length < 32)
                throw new InvalidRefreshTokenException("Refresh token too short.");

            _value = value;
        }
    }
}
