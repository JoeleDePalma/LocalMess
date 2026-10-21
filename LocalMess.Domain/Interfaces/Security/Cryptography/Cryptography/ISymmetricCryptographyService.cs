namespace LocalMess.Domain.Interfaces.Security.Cryptography.Cryptography
{
    public interface ISymmetricCryptographyService
    {
        (byte[] cipheredText, byte[] IV) Encrypt(byte[] plainText, byte[] simmetricKey);
        byte[] Decrypt(byte[] cipheredText, byte[] IV, byte[] simmetricKey);
    }
}
