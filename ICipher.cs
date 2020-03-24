namespace SymmetricBlockCiphers
{
    public interface ICipher
    {
        byte[] Encrypt(byte[] data);
        byte[] Decrypt(byte[] data);
    }
}
