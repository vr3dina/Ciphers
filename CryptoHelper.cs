using System.IO;
using System.Linq;
using System.Security.Cryptography;

namespace SymmetricBlockCiphers
{
    class CryptoHelper 
    {
        public byte[] FitToSize(byte[] b, int size)
        {
            byte[] zeros = Enumerable.Repeat((byte)0x00, size - b.Length).ToArray();
            var bList = b.ToList();
            bList.AddRange(zeros);
            return bList.ToArray();
        }

        public byte[] CryptoTransform(ICryptoTransform trasform, byte[] data)
        {
            using var memoryStream = new MemoryStream();
            using var cryptoStream = new CryptoStream(memoryStream, trasform, CryptoStreamMode.Write);
            cryptoStream.Write(data, 0, data.Length);
            cryptoStream.FlushFinalBlock();
            return memoryStream.ToArray();
        }
    }
}
