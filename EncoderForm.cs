using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SymmetricBlockCiphers
{
    public partial class EncoderForm : Form
    {
        private ICipher cipher;

        public EncoderForm()
        {
            InitializeComponent();
            cbCipher.SelectedIndex = 0;
            cbCipherMode.SelectedIndex = 0;
        }

        private void bEncode_Click(object sender, EventArgs e)
        {
            CipherMode cipherMode = (CipherMode)Enum.Parse(typeof(CipherMode), cbCipherMode.SelectedItem.ToString());
            
        }
    }
}
