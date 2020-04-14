using Ciphers.AsymmetricCiphers;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Ciphers.CipherProvider
{
    class KnapsackCipherProvider : ICipherProvider
    {
        private Label label1;
        private Label label2;
        private TextBox tbPrivateKey;
        private TextBox tbPublicKey;
        public ICipher Create()
        {
            int[] key = tbPrivateKey.Text.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            var kc = new KnapsackCryptosystem(key);
            tbPublicKey.Text = string.Join(" ", kc.GetPublicKey());
            return kc;
        }

        public Control[] GenerateUI()
        {
            label1 = new Label();
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(10, 25);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(59, 13);
            label1.TabIndex = 24;
            label1.Text = "public key";
            
            tbPublicKey = new TextBox();
            tbPublicKey.Location = new System.Drawing.Point(75, 22);
            tbPublicKey.Name = "tbPublicKey";
            tbPublicKey.Size = new System.Drawing.Size(180, 20);
            tbPublicKey.TabIndex = 25;
            tbPublicKey.ReadOnly = true;

            label2 = new Label();
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(12, 54);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(55, 13);
            label2.TabIndex = 26;
            label2.Text = "private key";

            tbPrivateKey = new TextBox();
            tbPrivateKey.Location = new System.Drawing.Point(75, 51);
            tbPrivateKey.Name = "tbPrivateKey";
            tbPrivateKey.Size = new System.Drawing.Size(180, 20);
            tbPrivateKey.TabIndex = 27;

            return new Control[] { label1, label2, tbPrivateKey, tbPublicKey };
        }

        public void OpenCipherParameters(string path)
        {
            XmlDocument xDoc = new XmlDocument();
            {
                xDoc.Load(path);
                XmlNodeList xnodeList = xDoc.DocumentElement.ChildNodes;
                foreach (XmlNode node in xnodeList)
                {
                    if (node.Name == "private_key")
                        tbPrivateKey.Text = node.InnerText;

                    if (node.Name == "public_key")
                        tbPublicKey.Text = node.InnerText;
                }
            }
        }

        public void SaveCipherParameters(string path)
        {
            XElement cipherInfo =
                new XElement("Cipher_Info",
                    new XElement("private_key", tbPrivateKey.Text),
                    new XElement("public_key", tbPublicKey.Text));

            File.WriteAllText(path, cipherInfo.ToString());
        }
    }
}
