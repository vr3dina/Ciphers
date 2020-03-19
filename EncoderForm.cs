using System;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace SymmetricBlockCiphers
{
    public partial class EncoderForm : Form
    {
        private ICipher cipher;
        private CipherMode cipherMode;
        private BitmapConverter bitmapConverter;

        private const string file = "data.txt";

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
            File.WriteAllBytes(file, encrypted);
        }
        private void bDecryptImg_Click(object sender, EventArgs e)
        {
            Size size = pbEncryptedImg.Image.Size;
            byte[] bytes = File.ReadAllBytes(file);
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

        private void bOpenPlainText_Click(object sender, EventArgs e)
        {
            if (openFileDialogText.ShowDialog() == DialogResult.OK)
            {
                tbPlainText.Text = File.ReadAllText(openFileDialogText.FileName);
            }
        }

        private void bOpenEncryptedText_Click(object sender, EventArgs e)
        {
            if (openFileDialogText.ShowDialog() == DialogResult.OK)
            {
                tbEnctyptedText.Text = File.ReadAllText(openFileDialogText.FileName);
            }
        }

        private void bSavePlainText_Click(object sender, EventArgs e)
        {
            if (saveFileDialogText.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialogText.FileName, tbPlainText.Text);
            }
        }

        private void bSaveEncryptedText_Click(object sender, EventArgs e)
        {
            if (saveFileDialogText.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialogText.FileName, tbEnctyptedText.Text);
            }
        }

        private void bSavePlainImg_Click(object sender, EventArgs e)
        {
            if (saveFileDialogImg.ShowDialog() == DialogResult.OK)
            {
                pbPlainImg.Image.Save(saveFileDialogImg.FileName);
            }
        }

        private void bSaveEncryptedImg_Click(object sender, EventArgs e)
        {
            if (saveFileDialogImg.ShowDialog() == DialogResult.OK)
            {
                pbEncryptedImg.Image.Save(saveFileDialogImg.FileName);
            }
        }

        private void bClearPlainText_Click(object sender, EventArgs e)
        {
            tbPlainText.Text = "";
        }

        private void bClearEnText_Click(object sender, EventArgs e)
        {
            tbEnctyptedText.Text = "";
        }

        private void bClearPlainImg_Click(object sender, EventArgs e)
        {
            pbPlainImg.Image = null;
        }

        private void bClearEnImg_Click(object sender, EventArgs e)
        {
            pbEncryptedImg.Image = null;
        }
    }
}
