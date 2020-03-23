namespace SymmetricBlockCiphers
{
    public interface ICipher
    {
        byte[] Encrypt(byte[] data);
        byte[] Decrypt(byte[] data);

        string Encrypt(string data);
        string Decrypt(string data);
    }
}
