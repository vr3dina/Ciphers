using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace SymmetricBlockCiphers
{
    class DESCipher : ICipher
    {
        DESCryptoServiceProvider DESProvider;

        private byte[] FitToSize(byte[] b, int size)
        {
            byte[] zeros = Enumerable.Repeat((byte)0x00, size - b.Length).ToArray();
            var bList = b.ToList();
            bList.AddRange(zeros);
            return bList.ToArray();
        }
        public DESCipher(CipherMode cipherMode, byte[] key, byte[] IV)
        {
            DESProvider = new DESCryptoServiceProvider
            {
                Mode = cipherMode,
                Padding = PaddingMode.PKCS7
            };
            DESProvider.Key = FitToSize(key, DESProvider.LegalKeySizes[0].MaxSize / 8);
            DESProvider.IV = FitToSize(IV, DESProvider.LegalBlockSizes[0].MaxSize / 8);
        }

        private byte[] CryptoTransform(ICryptoTransform trasform, byte[] data)
        {
            using var memoryStream = new MemoryStream();
            using var cryptoStream = new CryptoStream(memoryStream, trasform, CryptoStreamMode.Write);
            cryptoStream.Write(data, 0, data.Length);
            cryptoStream.FlushFinalBlock();
            return memoryStream.ToArray();
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
            byte[] bytes = Encoding.Unicode.GetBytes(data);
            byte[] encryptedBytes = Encrypt(bytes);
            return Convert.ToBase64String(encryptedBytes);
        }

        public string Decrypt(string data)
        {
            byte[] bytes = Convert.FromBase64String(data);
            byte[] decryptedBytes = Decrypt(bytes);
            return Encoding.Unicode.GetString(decryptedBytes);
        }
    }
}
