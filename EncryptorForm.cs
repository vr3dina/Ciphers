using System;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace SymmetricBlockCiphers
{
    public partial class EncryptorForm : Form
    {
        private ICipher cipher;
        private BitmapConverter bitmapConverter;

        private const string file = "data.txt";

        public EncryptorForm()
        {
            InitializeComponent();
            cbCipherMode.SelectedIndex = 0;
            cbCipher.SelectedIndex = 0;
            bitmapConverter = new BitmapConverter();
        }

        private void InitCipher()
        {
            byte[] key = Encoding.Unicode.GetBytes(tbKey.Text);
            byte[] IV = Encoding.Unicode.GetBytes(tbIV.Text);
            CipherMode cipherMode = (CipherMode)Enum.Parse(typeof(CipherMode), cbCipherMode.SelectedItem.ToString());
            if (cbCipher.SelectedItem?.ToString() == "DES")
                cipher = new DESCipher(cipherMode, key, IV);
            if (cbCipher.SelectedItem?.ToString() == "AES")
                cipher = new AESCipher(cipherMode, key, IV);
        }

        private void bEncrypt_Click(object sender, EventArgs e)
        {
            InitCipher();

            byte[] bytes = Encoding.Unicode.GetBytes(tbPlainText.Text);
            byte[] encryptedBytes = cipher.Encrypt(bytes);
            tbEnctyptedText.Text = Convert.ToBase64String(encryptedBytes);
        }

        private void bDecrypt_Click(object sender, EventArgs e)
        {
            InitCipher();

            byte[] bytes = Convert.FromBase64String(tbEnctyptedText.Text);
            byte[] decryptedBytes = cipher.Decrypt(bytes);
            tbPlainText.Text = Encoding.Unicode.GetString(decryptedBytes);
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
            InitCipher();
            Size size = pbPlainImg.Image.Size;
            byte[] bytes = bitmapConverter.ImageToBytes(new Bitmap(pbPlainImg.Image));
            byte[] encrypted = cipher.Encrypt(bytes);
            pbEncryptedImg.Image = bitmapConverter.BytesToImage(encrypted, size);
            File.WriteAllBytes(file, encrypted);
        }
        private void bDecryptImg_Click(object sender, EventArgs e)
        {
            InitCipher();
            Size size = pbEncryptedImg.Image.Size;
            byte[] bytes = File.ReadAllBytes(file);
            byte[] decrypted = cipher.Decrypt(bytes);
            pbPlainImg.Image = bitmapConverter.BytesToImage(decrypted, size);
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
            XElement cipherInfo =
                new XElement("Cipher_Info",
                    new XElement("cipher", cbCipher.SelectedItem.ToString()),
                    new XElement("cipher_mode", cbCipherMode.SelectedItem.ToString()),
                    new XElement("key", tbKey.Text),
                    new XElement("IV", tbIV.Text));

            if (saveFileDialogKey.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialogKey.FileName, cipherInfo.ToString());
            }
        }

        private void bOpenKey_Click(object sender, EventArgs e)
        {
            XmlDocument xDoc = new XmlDocument();
            if (openFileDialogKey.ShowDialog() == DialogResult.OK)
            {
                xDoc.Load(openFileDialogKey.FileName);
                XmlNodeList xnodeList = xDoc.DocumentElement.ChildNodes;
                foreach (XmlNode node in xnodeList)
                {
                    if (node.Name == "cipher")
                        cbCipher.SelectedItem = node.InnerText;

                    if (node.Name == "cipher_mode")
                        cbCipherMode.SelectedItem = node.InnerText;

                    if (node.Name == "key")
                        tbKey.Text = node.InnerText;

                    if (node.Name == "IV")
                        tbIV.Text= node.InnerText;
                }
            }
        }
    }
}
