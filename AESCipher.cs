using System.Security.Cryptography;

namespace SymmetricBlockCiphers
{
    class AESCipher : ICipher
    {
        AesCryptoServiceProvider AESProvider;
        CryptoHelper cryptoHelper;

        public AESCipher(CipherMode cipherMode, byte[] key, byte[] IV)
        {
            cryptoHelper = new CryptoHelper();
            AESProvider = new AesCryptoServiceProvider
            {
                Mode = cipherMode,
                Padding = PaddingMode.PKCS7
            };
            AESProvider.Key = cryptoHelper.FitToSize(key, AESProvider.LegalKeySizes[0].MaxSize / 8);
            AESProvider.IV = cryptoHelper.FitToSize(IV, AESProvider.LegalBlockSizes[0].MaxSize / 8);
        }

        public byte[] Encrypt(byte[] data)
        {
            return cryptoHelper.CryptoTransform(AESProvider.CreateEncryptor(), data);
        }
        public byte[] Decrypt(byte[] data)
        {
            return cryptoHelper.CryptoTransform(AESProvider.CreateDecryptor(), data);
        }
    }
}
