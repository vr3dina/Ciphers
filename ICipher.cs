namespace Ciphers
{
    public interface ICipher
    {
        byte[] Encrypt(byte[] data);
        byte[] Decrypt(byte[] data);
    }
}
