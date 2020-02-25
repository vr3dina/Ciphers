using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymmetricBlockCiphers
{
    public interface ICipher
    {
        //byte[] Encrypt_(string d);
        //string Decrypt(byte[] data);

        string Encrypt(string data);
        string Decrypt(string data);


    }
}
