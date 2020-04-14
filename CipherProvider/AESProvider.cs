using Ciphers.SymmetricCiphers;
using System;
using System.Security.Cryptography;
using System.Text;

namespace Ciphers.CipherProvider
{
    class AESProvider : SymmetricCipherProvider
    {
        public override ICipher Create()
        {
            byte[] key = Encoding.Unicode.GetBytes(tbKey.Text);
            byte[] IV = Encoding.Unicode.GetBytes(tbIV.Text);

            CipherMode cipherMode = (CipherMode)Enum.Parse(typeof(CipherMode), cbCipherMode.SelectedItem.ToString());

            return new AESCipher(cipherMode, key, IV);
        }
    }
}
