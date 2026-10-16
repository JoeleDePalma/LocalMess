using System;
using System.Collections.Generic;
using System.Text;
using LocalMess.Domain.Exceptions.ValueObjects.Message;

namespace LocalMess.Domain.ValueObjects.Message
{
    /// <summary>
    /// Represents the encrypted payload value object used to store the text in safety.
    /// </summary>
    public class EncryptedPayload
    {
        private readonly string _value;
        public string Value { get => _value; }

        /// <summary>
        /// Validates and assigns the encrypted payload value.
        /// </summary>
        /// <param name="value">
        /// Encrypted payload value.
        /// </param>
        /// <exception cref="InvalidEncryptedPayloadException">
        /// Thrown if the encrypted payload in base64 string is null or whitespace,
        /// or its length is less than 16 characters when it's a byte array.
        /// </exception>
        public EncryptedPayload(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new InvalidEncryptedPayloadException("Value cannot be null or whitespace.");

            byte[] bytes;

            try
            {
                bytes = Convert.FromBase64String(value);
            }
            catch
            {
                throw new InvalidEncryptedPayloadException("Value is not valid base64.");
            }

            if (bytes.Length < 16)
                throw new InvalidEncryptedPayloadException("Encrypted payload too short.");

            _value = value;   
        }

        /// <summary>
        /// Equals method override to compare 2 different object of the same class 
        /// ignoring the memory pointers.
        /// </summary>
        /// <param name="obj">Object to compare.</param>
        /// <returns>A boolean value indicating the equality.</returns>
        public override bool Equals(object? obj)
        {
            if (obj is not EncryptedPayload encryptedPayload)
                return false;

            return encryptedPayload.Value == _value;
        }

        /// <summary>
        /// Returns the value hash.
        /// </summary>
        /// <returns>The value hash.</returns>
        public override int GetHashCode()
            => _value.GetHashCode();
        
    }
}