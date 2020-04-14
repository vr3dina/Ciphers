using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace Ciphers.AsymmetricCiphers
{
    public struct RSAKeys
    {
        public struct Key
        {
            public BigInteger n;
            public BigInteger exponent;

            public Key(BigInteger n, BigInteger exp)
            {
                this.n = n;
                exponent = exp;
            }
        }

        public Key PublicKey { get; private set; }
        public Key PrivateKey { get; private set; }

        public RSAKeys(Key publicKey, Key privateKey)
        {
            PublicKey = publicKey;
            PrivateKey = privateKey;
        }
    }

    public class RSA : ICipher
    {
        RSAKeys RSAKeys;

        public RSA(BigInteger p, BigInteger q)
        {
            RSAKeys = GenerateKeys(p, q);
        }
        private RSAKeys GenerateKeys(BigInteger p, BigInteger q)
        {
            //BigInteger p = 61, q = 53;
            if (!p.IsProbablePrime() || !q.IsProbablePrime())
                throw new ArgumentException("p or q are not prime");
            BigInteger n = p * q;
            BigInteger totient = (p - 1) * (q - 1);

            //BigInteger publicKeyExponent = getPublicKeyExp(totient);
            BigInteger publicKeyExponent = 17;
            //BigInteger publicKeyExponent = 65537;

            BigInteger privateKeyExponent = getPrivateKeyExp(totient, publicKeyExponent);
            while (privateKeyExponent < 0) privateKeyExponent += totient;

            return new RSAKeys(new RSAKeys.Key(n, publicKeyExponent),
                               new RSAKeys.Key(n, privateKeyExponent));
        }

        private BigInteger getPrivateKeyExp(BigInteger totient, BigInteger publicKeyExponent)
        {
            _ = gcd(totient, publicKeyExponent, out _, out BigInteger y);
            return y;
        }

        private BigInteger getPublicKeyExp(BigInteger phi)
        {
            for (BigInteger i = phi - 1; i > 1; i--)
            {
                if (gcd(phi, i) == 1)
                    return i;
            }
            throw new Exception("Error");
        }

        private BigInteger gcd(BigInteger a, BigInteger b)
        {
            return (a == 0) ? b : gcd(b % a, a);
        }

        private BigInteger gcd(BigInteger a, BigInteger b, out BigInteger x, out BigInteger y)
        {
            if (a == 0)
            {
                x = 0;
                y = 1;
                return b;
            }
            BigInteger d = gcd(b % a, a, out BigInteger x1, out BigInteger y1);
            x = y1 - (b / a) * x1;
            y = x1;
            return d;
        }

        public byte[] Encrypt(byte[] message)
        {
            RSAKeys.Key publicKey = RSAKeys.PublicKey;
            var size = publicKey.n.ToByteArray().Length;
            List<byte> encrypted = new List<byte>(size * message.Length);
            foreach (var ch in message)
            {
                byte[] encryptedCharBytes = BigInteger.ModPow(ch, publicKey.exponent, publicKey.n).ToByteArray();
                encrypted.AddRange(encryptedCharBytes);
                encrypted.AddRange(new byte[size - encryptedCharBytes.Length]);
            }
            return encrypted.ToArray();
        }

        public byte[] Decrypt(byte[] message)
        {
            RSAKeys.Key privateKey = RSAKeys.PrivateKey;
            var size = privateKey.n.ToByteArray().Length;
            List<byte> decrypted = new List<byte>(size * message.Length);
            for (var i = 0; i <= message.Length - size; i += size)
            {
                BigInteger encryptedChar = new BigInteger(message.Skip(i).Take(size).ToArray());
                decrypted.AddRange(BigInteger.ModPow(encryptedChar, privateKey.exponent, privateKey.n).ToByteArray());
            }
            return decrypted.ToArray();
        }
    }
}
