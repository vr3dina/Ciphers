using Ciphers.AsymmetricCiphers;
using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Ciphers.CipherProvider
{
    class RSAProvider : ICipherProvider
    {
        private Label label1;
        private Label label2;
        private TextBox tbPrimeN1;
        private TextBox tbPrimeN2;
        public ICipher Create()
        {
            ulong n1 = Convert.ToUInt64(tbPrimeN1.Text);
            ulong n2 = Convert.ToUInt64(tbPrimeN2.Text);
            return new RSA(n1, n2);
        }

        public Control[] GenerateUI()
        {
            label1 = new Label();
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(10, 25);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(59, 13);
            label1.TabIndex = 24;
            label1.Text = "Prime numner";
            
            tbPrimeN2 = new TextBox();
            tbPrimeN2.Location = new System.Drawing.Point(85, 22);
            tbPrimeN2.Name = "tbPrimeN1";
            tbPrimeN2.Size = new System.Drawing.Size(50, 20);
            tbPrimeN2.TabIndex = 25;

            label2 = new Label();
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(10, 54);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(55, 13);
            label2.TabIndex = 26;
            label2.Text = "Prime number";

            tbPrimeN1 = new TextBox();
            tbPrimeN1.Location = new System.Drawing.Point(85, 51);
            tbPrimeN1.Name = "tbPrimeN2";
            tbPrimeN1.Size = new System.Drawing.Size(50, 20);
            tbPrimeN1.TabIndex = 27;

            return new Control[] { label1, label2, tbPrimeN1, tbPrimeN2 };

        }

        public void OpenCipherParameters(string path)
        {
            XmlDocument xDoc = new XmlDocument();
            {
                xDoc.Load(path);
                XmlNodeList xnodeList = xDoc.DocumentElement.ChildNodes;
                foreach (XmlNode node in xnodeList)
                {
                    if (node.Name == "prime1")
                        tbPrimeN1.Text = node.InnerText;

                    if (node.Name == "prime2")
                        tbPrimeN2.Text = node.InnerText;
                }
            }

        }

        public void SaveCipherParameters(string path)
        {
            XElement cipherInfo =
                new XElement("Cipher_Info",
                    new XElement("prime1", tbPrimeN1.Text),
                    new XElement("prime2", tbPrimeN2.Text));

            File.WriteAllText(path, cipherInfo.ToString());
        }
    }
}
