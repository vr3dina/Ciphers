using System.Collections.Generic;
using System.Windows.Forms;

namespace Ciphers.CipherProvider
{
    interface ICipherProvider
    {
        Control[] GenerateUI();
        ICipher Create();
        public void SaveCipherParameters(string path);

        public void OpenCipherParameters(string path);

    }
}
