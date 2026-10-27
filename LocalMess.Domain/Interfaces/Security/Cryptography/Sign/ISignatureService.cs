namespace LocalMess.Domain.Interfaces.Security.Cryptography.Sign
{
    public interface ISignatureService
    {
        (byte[] privateKey, byte[] publicKey) GenerateKeyPair();
        
        byte[] Sign(byte[] privateKey, byte[] message);

        bool Verify(byte[] publicKey, byte[] message, byte[] signature);
    }
}
