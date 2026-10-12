using System;
using System.Collections.Generic;
using System.Text;
using LocalMess.Domain.Exceptions.ValueObjects.User;

namespace LocalMess.Domain.ValueObjects.User
{
    /// <summary>
    /// Username value object used for users model.
    /// </summary>
    public class Username
    {
        private readonly string _value;
        public string Value { get => _value; }

        /// <summary>
        /// <param name="value"/> validation and <see cref="_value"/> assignment.
        /// </summary>
        /// <param name="value">
        /// Username value.
        /// </param>
        /// <exception cref="InvalidUsernameException">
        /// Thrown if <paramref name="value"/> is null or whitespace, 
        /// its length is less than 4 or more than 20.
        /// </exception>
        public Username(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new InvalidUsernameException("Username null or white space");

            if (value.Length < 4)
                throw new InvalidUsernameException("Username too short");

            if (value.Length > 20)
                throw new InvalidUsernameException("Username too long");

            _value = value;
        }

        /// <summary>
        /// Equals method override to compare 2 different object of the same class 
        /// ignoring the memory pointers.
        /// </summary>
        /// <param name="obj">Object to compare.</param>
        /// <returns>A boolean value indicating the equality.</returns>
        public override bool Equals(object obj)
        {
            if (obj is null) return false;
            if (obj.GetType() != typeof(Username)) return false;

            var other = (Username)obj;
            return _value == other._value;
        }

        /// <summary>
        /// Returns the value hash.
        /// </summary>
        /// <returns>The value hash.</returns>
        public override int GetHashCode()
        {
            return _value.GetHashCode();
        }
    }
}
