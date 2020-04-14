using System;
using System.Security.Cryptography;

namespace Ciphers.AsymmetricCiphers
{
    class RSADotNet : ICipher
    {
        private RSAParameters privateKey;
        private RSAParameters publicKey;

        public RSADotNet(RSAParameters privKey, RSAParameters pubKey)
        {
            privateKey = privKey;
            publicKey = pubKey;
        }
        public byte[] Encrypt(byte[] data)
        {
            byte[] encryptedData;
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                encryptedData = Encrypt(data, false);
            }
            return encryptedData;
        }

        public byte[] Decrypt(byte[] data)
        {
            byte[] decryptedData;
            using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
            {
                decryptedData = Decrypt(data, false);
            }
            return decryptedData;
        }

        private byte[] Decrypt(byte[] data, bool DoOAEPPadding)
        {
            try
            {
                byte[] decryptedData;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(privateKey);
                    decryptedData = RSA.Decrypt(data, DoOAEPPadding);
                }
                return decryptedData;
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.ToString());
                return null;
            }
        }


        private byte[] Encrypt(byte[] data, bool DoOAEPPadding)
        {
            try
            {
                byte[] encryptedData;
                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(publicKey);
                    encryptedData = RSA.Encrypt(data, DoOAEPPadding);
                }
                return encryptedData;
            }
            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

    }
}
