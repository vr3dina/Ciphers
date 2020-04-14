using System.Collections.Generic;
using System.Windows.Forms;

namespace Ciphers.CipherProvider
{
    abstract class CipherProvider : ICipherProvider
    {
        public abstract ICipher Create();
        public abstract Control[] GenerateUI();

        public abstract void SaveCipherParameters(string path);

        public abstract void OpenCipherParameters(string path);
    }
}
