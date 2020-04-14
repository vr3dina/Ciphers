using System.Security.Cryptography;

namespace Ciphers.SymmetricCiphers
{
    class DESCipher : ICipher
    {
        DESCryptoServiceProvider DESProvider;
        CryptoHelper cryptoHelper;

        public DESCipher(CipherMode cipherMode, byte[] key, byte[] IV)
        {
            cryptoHelper = new CryptoHelper();
            DESProvider = new DESCryptoServiceProvider
            {
                Mode = cipherMode,
                Padding = PaddingMode.PKCS7
            };
            DESProvider.Key = cryptoHelper.FitToSize(key, DESProvider.LegalKeySizes[0].MaxSize / 8);
            DESProvider.IV = cryptoHelper.FitToSize(IV, DESProvider.LegalBlockSizes[0].MaxSize / 8);
        }

        public byte[] Encrypt(byte[] data)
        {
            return cryptoHelper.CryptoTransform(DESProvider.CreateEncryptor(), data);
        }
        public byte[] Decrypt(byte[] data)
        {
            return cryptoHelper.CryptoTransform(DESProvider.CreateDecryptor(), data);
        }
    }
}
