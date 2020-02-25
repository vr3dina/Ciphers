using System;
using System.IO;
using System.Security.Cryptography;

namespace SymmetricBlockCiphers
{
    class DESCipher : ICipher
    {
        DESCryptoServiceProvider DESProvider;
        public DESCipher(CipherMode cipherMode)
        {
            DESProvider = new DESCryptoServiceProvider
            {
                Mode = cipherMode,
                Padding = PaddingMode.PKCS7
            };
        }

        private byte[] CryptoTransform(ICryptoTransform trasform, byte[] data)
        {
            using (var memoryStream = new MemoryStream())
            {
                using (var cryptoStream = new CryptoStream(memoryStream, trasform, CryptoStreamMode.Write))
                {
                    cryptoStream.Write(data, 0, data.Length);
                    cryptoStream.FlushFinalBlock();
                    return memoryStream.ToArray();
                }
            }
        }
        public byte[] Encrypt(byte[] data)
        {
            return CryptoTransform(DESProvider.CreateEncryptor(), data);
        }
        public byte[] Decrypt(byte[] data)
        {
            return CryptoTransform(DESProvider.CreateDecryptor(), data);
        }

        public string Encrypt(string data)
        {
            byte[] bytes = Convert.FromBase64String(data);
            byte[] encryptedBytes = Encrypt(bytes);
            return Convert.ToBase64String(encryptedBytes);

        }

        public string Decrypt(string data)
        {
            byte[] bytes = Convert.FromBase64String(data);
            byte[] decryptedBytes = Decrypt(bytes);
            return Convert.ToBase64String(decryptedBytes);
        }
    }
}
