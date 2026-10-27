namespace LocalMess.Domain.Interfaces.Security.Cryptography.Cryptography
{
    public interface IAesGcmService
    {
        (byte[] cipheredText, byte[] IV) Encrypt(byte[] plainText, byte[] simmetricKey);
        byte[] Decrypt(byte[] cipheredText, byte[] IV, byte[] simmetricKey);
    }
}
