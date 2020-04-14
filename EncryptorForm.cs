using Ciphers.CipherProvider;
using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Ciphers
{
    public partial class EncryptorForm : Form
    {
        private ICipherProvider cipherProvider;
        private ICipher cipher;
        private BitmapConverter bitmapConverter;

        private const string file = "data.txt";

        public EncryptorForm()
        {
            InitializeComponent();
            cbCipher.SelectedIndex = 0;
            bitmapConverter = new BitmapConverter();
        }

        private void InitCipher()
        {
            cipher = cipherProvider.Create();
            lError.Text = "";
        }

        private void bEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                InitCipher();
                byte[] bytes = Encoding.Unicode.GetBytes(tbPlainText.Text);
                byte[] encryptedBytes = cipher.Encrypt(bytes);
                tbEnctyptedText.Text = Convert.ToBase64String(encryptedBytes);
            }
            catch (Exception ex)
            {
                lError.Text = ex.Message;
            }
        }

        private void bDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                InitCipher();
                byte[] bytes = Convert.FromBase64String(tbEnctyptedText.Text);
                byte[] decryptedBytes = cipher.Decrypt(bytes);
                tbPlainText.Text = Encoding.Unicode.GetString(decryptedBytes);
            }
            catch (Exception ex)
            {
                lError.Text = ex.Message;
            }
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
            try
            {
                InitCipher();
                Size size = pbPlainImg.Image.Size;
                byte[] bytes = bitmapConverter.ImageToBytes(new Bitmap(pbPlainImg.Image));
                byte[] encrypted = cipher.Encrypt(bytes);
                pbEncryptedImg.Image = bitmapConverter.BytesToImage(encrypted, size);
                File.WriteAllBytes(file, encrypted);
            }
            catch (Exception ex)
            {
                lError.Text = ex.Message;
            }

        }
        private void bDecryptImg_Click(object sender, EventArgs e)
        {
            try
            {
                InitCipher();
                Size size = pbEncryptedImg.Image.Size;
                byte[] bytes = File.ReadAllBytes(file);
                byte[] decrypted = cipher.Decrypt(bytes);
                pbPlainImg.Image = bitmapConverter.BytesToImage(decrypted, size);
            }
            catch (Exception ex)
            {
                lError.Text = ex.Message;
            }

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

        private void bSaveKey_Click(object sender, EventArgs e)
        {
            if (saveFileDialogKey.ShowDialog() == DialogResult.OK)
            {
                cipherProvider.SaveCipherParameters(saveFileDialogKey.FileName);
            }
        }

        private void bOpenKey_Click(object sender, EventArgs e)
        {
            if (openFileDialogKey.ShowDialog() == DialogResult.OK)
            {
                cipherProvider.OpenCipherParameters(openFileDialogKey.FileName);
            }
        }

        private void cbCipher_SelectedIndexChanged(object sender, EventArgs e)
        {
            lError.Text = "";
            switch (cbCipher.SelectedItem.ToString())
            {
                case "DES":
                    cipherProvider = new DESProvider();
                    ((Control)tabPageImgEncryption).Enabled = true;
                    break;
                case "AES":
                    cipherProvider = new AESProvider();
                    ((Control)tabPageImgEncryption).Enabled = true;
                    break;
                case "Knapsack":
                    cipherProvider = new KnapsackCipherProvider();
                    ((Control)tabPageImgEncryption).Enabled = false;
                    break;
                case "RSA":
                    cipherProvider = new RSAProvider();
                    ((Control)tabPageImgEncryption).Enabled = false;
                    break;
                case "RSADotNet":
                    cipherProvider = new RSADotNetProvider();
                    ((Control)tabPageImgEncryption).Enabled = false;
                    break;
                default:
                    break;
            }
            gbCipherParameters.Controls.Clear();
            gbCipherParameters.Controls.AddRange(cipherProvider.GenerateUI());
        }
    }
}
