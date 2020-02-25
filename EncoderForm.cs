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
        private CipherMode cipherMode;

        public EncoderForm()
        {
            InitializeComponent();
            cbCipher.SelectedIndex = 0;
            cbCipherMode.SelectedIndex = 0;
        }

        private void InitCipher()
        {
            cipherMode = (CipherMode)Enum.Parse(typeof(CipherMode), cbCipherMode.SelectedItem.ToString());
            if (cbCipher.SelectedItem.ToString() == "DES")
                cipher = new DESCipher(cipherMode);
        }

        private void bEncrypt_Click(object sender, EventArgs e)
        {
            InitCipher();

            //var bytes = cipher.Encrypt(tbDecodedText.Text);
            //var decrypted = cipher.Decrypt(bytes);

            tbEnctyptedText.Text = cipher.Encrypt(tbDecryptedText.Text);
        }

        private void bDecrypt_Click(object sender, EventArgs e)
        {
            InitCipher();
            tbDecryptedText.Text = cipher.Decrypt(tbEnctyptedText.Text);
        }
    }
}
