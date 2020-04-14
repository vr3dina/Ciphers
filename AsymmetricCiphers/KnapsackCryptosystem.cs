using System;
using System.Collections;
using System.Linq;

namespace Ciphers.AsymmetricCiphers
{
    class KnapsackCryptosystem : ICipher
    {
        int n, m;
        int[] privateKey;
        int[] publicKey;
        public KnapsackCryptosystem(int[] key)
        {
            if (!IsKeyCorrect(key))
                throw new ArgumentException("Invalid private key");
            privateKey = key;
            GeneratePublicKey();
        }

        public int[] GetPublicKey()
        {
            return publicKey;
        }
        public byte[] Decrypt(byte[] data)
        {
            byte[] decrypted = new byte[(privateKey.Length * data.Length)/ 64];
            var bits = new BitArray(decrypted.Length * 8);
            _ = GCD(m, n, out int _, out int x);
            Int64 nInverse = (x % m + m) % m;
            for (int i = 0; i < data.Length / 8; i++)
            {
                Int64 dataItem = BitConverter.ToInt64(data.Take(i * 8 + 8).ToArray(), i * 8);
                Int64 tmp = (dataItem * nInverse) % m;
                for (int j = privateKey.Length - 1; j >= 0 && i * privateKey.Length + j < bits.Length; j--)
                {
                    if (privateKey[j] <= tmp)
                    {
                        bits[i * privateKey.Length + j] = true;
                        tmp -= privateKey[j];
                    }
                    else
                    {
                        bits[i * privateKey.Length + j] = false;
                    }
                }
            }
            bits.CopyTo(decrypted, 0);
            return decrypted;
        }

        public byte[] Encrypt(byte[] data)
        {
            var bits = new BitArray(data);
            int n = privateKey.Length;
            byte[] encrypted = new byte[((bits.Length + n - 1)/ n) * 8];

            int indBits = 0, indRes = 0;
            while (indBits < bits.Length)
            {
                UInt64 t = 0;
                for (int j = 0; j < n && indBits < bits.Length; j++, indBits++)
                {
                    if (bits[indBits])
                        t += (ulong)publicKey[j];
                }
                BitConverter.GetBytes(t).CopyTo(encrypted, indRes * 8);
                indRes++;
            }
            return encrypted;
        }

        private void GeneratePublicKey()
        {
            m = privateKey.ToArray().Sum() + 31;
            //n = GetCoprime(m);
            n = 31;

            publicKey = new int[privateKey.Length];
            for (int i = 0; i < privateKey.Length; i++)
            {
                publicKey[i] = (privateKey[i] * n) % m;
            }
        }

        private int GetCoprime(int n)
        {
            int j = n - 1;
            while (j > 1)
            {
                if (GCD(n, j) == 1)
                    return j;
                j--;
            }
            return j;
        }

        private int GCD(int a, int b)
        {
            return b != 0 ? GCD(b, a % b) : a;
        }

        private int GCD(int a, int b, out int x, out int y)
        {
            if (a == 0)
            {
                x = 0;
                y = 1;
                return b;
            }
            int d = GCD(b % a, a, out int x1, out int y1);
            x = y1 - b / a * x1;
            y = x1;
            return d;
        }

        static public bool IsKeyCorrect(int[] key)
        {
            int sum = 0;
            foreach (var item in key)
            {
                if (item < sum)
                    return false;
                sum += item;
            }
            return true;
        }
    }
}
