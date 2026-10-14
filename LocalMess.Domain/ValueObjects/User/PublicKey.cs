using System;
using System.Collections.Generic;
using System.Text;
using LocalMess.Domain.Exceptions.ValueObjects.User;

namespace LocalMess.Domain.ValueObjects.User
{
    /// <summary>
    /// Represents the public key value object used to encrypt messages.
    /// </summary>
    public class PublicKey
    {
        private readonly byte[] _value;
        public byte[] Value { get => _value; }

        /// <summary>
        /// Validates and assigns the public key value.
        /// </summary>
        /// <param name="value">
        /// Public key value.
        /// </param>
        /// <exception cref="InvalidPublicKeyException">
        /// Thrown if the public key is null, empty, or has invalid length.
        /// </exception>
        public PublicKey(byte[] value)
        {
            if (value is null || value.Length == 0)
                throw new InvalidPublicKeyException("Public key cannot be null or empty.");

            if (value.Length != 32) 
                throw new InvalidPublicKeyException("Public key must be 32 bytes.");

            _value = value;
        }

        /// <summary>
        /// Creates a PublicKey from a Base64 string.
        /// </summary>
        public static PublicKey FromBase64(string base64)
        {
            if (string.IsNullOrWhiteSpace(base64))
                throw new InvalidPublicKeyException("Public key cannot be null or empty.");

            byte[] bytes;

            try
            {
                bytes = Convert.FromBase64String(base64);
            }
            catch
            {
                throw new InvalidPublicKeyException("Public key is not valid base64.");
            }

            return new PublicKey(bytes);
        }

        /// <summary>
        /// Returns the public key as a Base64 string.
        /// </summary>
        public string ToBase64()
            => Convert.ToBase64String(_value);
    }
}
