namespace LocalMess.Domain.Interfaces.Security.Cryptography.Common
{
    public interface IKeyFromPasswordService
    {
        /// <summary>
        /// Derives the simmetric key.
        /// </summary>
        /// <param name="password">Password used to derive the key.</param>
        /// <param name="salt">Salt used in the key.</param>
        /// <returns>
        /// The key and its salt.
        /// </returns>
        (byte[] Key, byte[] Salt) Derive(string password, byte[]? salt = null);
    }
}