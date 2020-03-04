using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace SymmetricBlockCiphers
{
    public partial class EncoderForm : Form
    {
        private ICipher cipher;
        private CipherMode cipherMode;
        private BitmapConverter bitmapConverter;

        public EncoderForm()
        {
            InitializeComponent();
            cbCipherMode.SelectedIndex = 0;
            cbCipher.SelectedIndex = 0;
            bitmapConverter = new BitmapConverter();
        }

        private void InitCipher()
        {
            cipherMode = (CipherMode)Enum.Parse(typeof(CipherMode), cbCipherMode.SelectedItem.ToString());
            if (cbCipher.SelectedItem?.ToString() == "DES")
                cipher = new DESCipher(cipherMode);
        }

        private void bEncrypt_Click(object sender, EventArgs e)
        {
            //var bytes = cipher.Encrypt(tbDecodedText.Text);
            //var decrypted = cipher.Decrypt(bytes);

            tbEnctyptedText.Text = cipher.Encrypt(tbPlainText.Text);
        }

        private void bDecrypt_Click(object sender, EventArgs e)
        {
            tbPlainText.Text = cipher.Decrypt(tbEnctyptedText.Text);
        }

        private void bOpenImg_Click(object sender, EventArgs e)
        {
            if (openFileDialogImg.ShowDialog() == DialogResult.OK)
            {
                pbPlainImg.Image = Image.FromFile(openFileDialogImg.FileName);
            }
        }

        private void bOpenEncryptedImg_Click(object sender, EventArgs e)
        {
            if (openFileDialogImg.ShowDialog() == DialogResult.OK)
            {
                pbEncryptedImg.Image = Image.FromFile(openFileDialogImg.FileName);
            }

        }

        private void bEncryptImg_Click(object sender, EventArgs e)
        {
            Size size = pbPlainImg.Image.Size;
            byte[] bytes = bitmapConverter.ImageToBytes(new Bitmap(pbPlainImg.Image));
            byte[] encrypted = cipher.Encrypt(bytes);
            pbEncryptedImg.Image = bitmapConverter.BytesToImage(encrypted, size);
        }
        private void bDecryptImg_Click(object sender, EventArgs e)
        {
            Size size = pbEncryptedImg.Image.Size;
            byte[] bytes = bitmapConverter.ImageToBytes(new Bitmap(pbEncryptedImg.Image));
            byte[] decrypted = cipher.Decrypt(bytes);
            pbPlainImg.Image = bitmapConverter.BytesToImage(decrypted, size);
        }

        private void cbCipher_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitCipher();
        }

        private void cbCipherMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitCipher();
        }
    }
}
