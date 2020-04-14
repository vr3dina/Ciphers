using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Ciphers.CipherProvider
{
    abstract class SymmetricCipherProvider : CipherProvider
    {
        protected Label label1;
        protected Label label2;
        protected TextBox tbKey;
        protected TextBox tbIV;
        protected Label l_cipherMode;
        protected ComboBox cbCipherMode;

        public override Control[] GenerateUI()
        {
            label1 = new Label();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(164, 47);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(24, 13);
            label1.TabIndex = 24;
            label1.Text = "key";
            // 
            // tbKey
            // 
            tbKey = new TextBox();
            tbKey.Location = new System.Drawing.Point(208, 14);
            tbKey.Name = "tbKey";
            tbKey.Size = new System.Drawing.Size(180, 20);
            tbKey.TabIndex = 25;
            // 
            // label2
            // 
            label2 = new Label();
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(171, 17);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(17, 13);
            label2.TabIndex = 26;
            label2.Text = "IV";
            // 
            // tbIV
            // 
            tbIV = new TextBox();
            tbIV.Location = new System.Drawing.Point(208, 43);
            tbIV.Name = "tbIV";
            tbIV.Size = new System.Drawing.Size(180, 20);
            tbIV.TabIndex = 27;
            // 
            // l_cipherMode
            // 
            l_cipherMode = new Label();
            l_cipherMode.AutoSize = true;
            l_cipherMode.Location = new System.Drawing.Point(18, 21);
            l_cipherMode.Name = "l_cipherMode";
            l_cipherMode.Size = new System.Drawing.Size(65, 13);
            l_cipherMode.TabIndex = 2;
            l_cipherMode.Text = "cipher mode";
            // 
            // cbCipherMode
            // 
            cbCipherMode = new ComboBox();
            cbCipherMode.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCipherMode.FormattingEnabled = true;
            cbCipherMode.Items.AddRange(new object[] {
            "CBC",
            "ECB",
            "CFB",
            "CTS"});
            cbCipherMode.Location = new System.Drawing.Point(21, 44);
            cbCipherMode.Name = "cbCipherMode";
            cbCipherMode.Size = new System.Drawing.Size(121, 21);
            cbCipherMode.TabIndex = 3;

            cbCipherMode.SelectedIndex = 0;

            return new Control[] { label1, label2, tbIV, tbKey, l_cipherMode, cbCipherMode };
        }

        public override void OpenCipherParameters(string path)
        {
            XmlDocument xDoc = new XmlDocument();
            {
                xDoc.Load(path);
                XmlNodeList xnodeList = xDoc.DocumentElement.ChildNodes;
                foreach (XmlNode node in xnodeList)
                {
                    if (node.Name == "cipher")
                        cbCipherMode.SelectedItem = node.InnerText;

                    if (node.Name == "cipher_mode")
                        cbCipherMode.SelectedItem = node.InnerText;

                    if (node.Name == "key")
                        tbKey.Text = node.InnerText;

                    if (node.Name == "IV")
                        tbIV.Text = node.InnerText;
                }
            }

        }

        public override void SaveCipherParameters(string path)
        {
            XElement cipherInfo =
                new XElement("Cipher_Info",
                    new XElement("cipher", cbCipherMode.SelectedItem.ToString()),
                    new XElement("cipher_mode", cbCipherMode.SelectedItem.ToString()),
                    new XElement("key", tbKey.Text),
                    new XElement("IV", tbIV.Text));

            File.WriteAllText(path, cipherInfo.ToString());
        }
    }
}
