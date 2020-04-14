using Ciphers.AsymmetricCiphers;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Xml;

namespace Ciphers.CipherProvider
{
    public class RSADotNetProvider : ICipherProvider
    {
        private Label label1;
        private Label label2;
        private TextBox tbPrivateKey;
        private TextBox tbPublicKey;
        private RSAParameters privateKey;
        private RSAParameters publicKey;
        private RSACryptoServiceProvider csp;
        public RSADotNetProvider()
        {
            csp = new RSACryptoServiceProvider();
            privateKey = csp.ExportParameters(true);
            publicKey = csp.ExportParameters(false);
        }
        public ICipher Create()
        {
            return new RSADotNet(privateKey, publicKey);
        }

        private string KeysToString(byte[] a, byte[] b)
        {
            return string.Join("", a) + " " + string.Join("", b);
        }
        public Control[] GenerateUI()
        {
            label1 = new Label
            {
                AutoSize = true,
                Location = new System.Drawing.Point(10, 25),
                Name = "label1",
                Size = new System.Drawing.Size(59, 13),
                TabIndex = 24,
                Text = "public key"
            };

            tbPublicKey = new TextBox
            {
                Location = new System.Drawing.Point(75, 22),
                Name = "tbPublicKey",
                Size = new System.Drawing.Size(350, 20),
                TabIndex = 25,
                ReadOnly = true,
                Text = KeysToString(publicKey.Exponent, publicKey.Modulus)
            };

            label2 = new Label
            {
                AutoSize = true,
                Location = new System.Drawing.Point(12, 54),
                Name = "label2",
                Size = new System.Drawing.Size(55, 13),
                TabIndex = 26,
                Text = "private key"
            };

            tbPrivateKey = new TextBox
            {
                Location = new System.Drawing.Point(75, 51),
                Name = "tbPrivateKey",
                Size = new System.Drawing.Size(400, 20),
                TabIndex = 27,
                ReadOnly = true,
                Text = KeysToString(privateKey.D, privateKey.Modulus)
            };

            return new Control[] { label1, label2, tbPrivateKey, tbPublicKey };
        }

        public void OpenCipherParameters(string path)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(path);
            csp.FromXmlString(xDoc.OuterXml);
            privateKey = csp.ExportParameters(true);
            publicKey = csp.ExportParameters(false);

            tbPrivateKey.Text = KeysToString(privateKey.D, privateKey.Modulus);
            tbPublicKey.Text = KeysToString(publicKey.Exponent, publicKey.Modulus);
        }

        public void SaveCipherParameters(string path)
        {
            var s = csp.ToXmlString(true);
            File.WriteAllText(path, s);
        }
    }
}
