﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SymmetricBlockCiphers
{
    public interface ICipher
    {
        byte[] Encrypt(byte[] data);
        byte[] Decrypt(byte[] data);
    }
}