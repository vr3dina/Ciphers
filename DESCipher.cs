using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

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
                Padding = PaddingMode.None
            };
        }


        private byte[] CryptoTransform(ICryptoTransform trasform, byte[] data)
        {
            using (var memoryStream = new MemoryStream())
            {
                using (var cryptoStream = new CryptoStream(memoryStream, trasform,
                CryptoStreamMode.Write))
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
    }
}
