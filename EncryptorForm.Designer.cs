namespace Ciphers
{
    partial class EncryptorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.l_cipherType = new System.Windows.Forms.Label();
            this.cbCipher = new System.Windows.Forms.ComboBox();
            this.tbPlainText = new System.Windows.Forms.TextBox();
            this.tbEnctyptedText = new System.Windows.Forms.TextBox();
            this.bEncrypt = new System.Windows.Forms.Button();
            this.bDecrypt = new System.Windows.Forms.Button();
            this.pbEncryptedImg = new System.Windows.Forms.PictureBox();
            this.bDecryptImg = new System.Windows.Forms.Button();
            this.bEncryptImg = new System.Windows.Forms.Button();
            this.bOpenImg = new System.Windows.Forms.Button();
            this.bOpenEncryptedImg = new System.Windows.Forms.Button();
            this.openFileDialogImg = new System.Windows.Forms.OpenFileDialog();
            this.bOpenPlainText = new System.Windows.Forms.Button();
            this.bOpenEncryptedText = new System.Windows.Forms.Button();
            this.openFileDialogText = new System.Windows.Forms.OpenFileDialog();
            this.bSavePlainText = new System.Windows.Forms.Button();
            this.bSaveEncryptedText = new System.Windows.Forms.Button();
            this.bSavePlainImg = new System.Windows.Forms.Button();
            this.bSaveEncryptedImg = new System.Windows.Forms.Button();
            this.bClearPlainText = new System.Windows.Forms.Button();
            this.bClearEnText = new System.Windows.Forms.Button();
            this.bClearPlainImg = new System.Windows.Forms.Button();
            this.bClearEnImg = new System.Windows.Forms.Button();
            this.saveFileDialogText = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialogImg = new System.Windows.Forms.SaveFileDialog();
            this.bOpenKey = new System.Windows.Forms.Button();
            this.bSaveKey = new System.Windows.Forms.Button();
            this.saveFileDialogKey = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogKey = new System.Windows.Forms.OpenFileDialog();
            this.gbCipherParameters = new System.Windows.Forms.GroupBox();
            this.pbPlainImg = new System.Windows.Forms.PictureBox();
            this.lError = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageTextEncryption = new System.Windows.Forms.TabPage();
            this.tabPageImgEncryption = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.pbEncryptedImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlainImg)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageTextEncryption.SuspendLayout();
            this.tabPageImgEncryption.SuspendLayout();
            this.SuspendLayout();
            // 
            // l_cipherType
            // 
            this.l_cipherType.AutoSize = true;
            this.l_cipherType.Location = new System.Drawing.Point(16, 22);
            this.l_cipherType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_cipherType.Name = "l_cipherType";
            this.l_cipherType.Size = new System.Drawing.Size(47, 17);
            this.l_cipherType.TabIndex = 0;
            this.l_cipherType.Text = "cipher";
            // 
            // cbCipher
            // 
            this.cbCipher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCipher.FormattingEnabled = true;
            this.cbCipher.Items.AddRange(new object[] {
            "DES",
            "AES",
            "Knapsack",
            "RSA",
            "RSADotNet"});
            this.cbCipher.Location = new System.Drawing.Point(72, 18);
            this.cbCipher.Margin = new System.Windows.Forms.Padding(4);
            this.cbCipher.Name = "cbCipher";
            this.cbCipher.Size = new System.Drawing.Size(160, 24);
            this.cbCipher.TabIndex = 1;
            this.cbCipher.SelectedIndexChanged += new System.EventHandler(this.cbCipher_SelectedIndexChanged);
            // 
            // tbPlainText
            // 
            this.tbPlainText.Location = new System.Drawing.Point(7, 7);
            this.tbPlainText.Margin = new System.Windows.Forms.Padding(4);
            this.tbPlainText.Multiline = true;
            this.tbPlainText.Name = "tbPlainText";
            this.tbPlainText.Size = new System.Drawing.Size(463, 342);
            this.tbPlainText.TabIndex = 4;
            // 
            // tbEnctyptedText
            // 
            this.tbEnctyptedText.Location = new System.Drawing.Point(617, 7);
            this.tbEnctyptedText.Margin = new System.Windows.Forms.Padding(4);
            this.tbEnctyptedText.Multiline = true;
            this.tbEnctyptedText.Name = "tbEnctyptedText";
            this.tbEnctyptedText.Size = new System.Drawing.Size(463, 342);
            this.tbEnctyptedText.TabIndex = 5;
            // 
            // bEncrypt
            // 
            this.bEncrypt.Location = new System.Drawing.Point(481, 107);
            this.bEncrypt.Margin = new System.Windows.Forms.Padding(4);
            this.bEncrypt.Name = "bEncrypt";
            this.bEncrypt.Size = new System.Drawing.Size(128, 42);
            this.bEncrypt.TabIndex = 6;
            this.bEncrypt.Text = ">>";
            this.bEncrypt.UseVisualStyleBackColor = true;
            this.bEncrypt.Click += new System.EventHandler(this.bEncrypt_Click);
            // 
            // bDecrypt
            // 
            this.bDecrypt.Location = new System.Drawing.Point(481, 157);
            this.bDecrypt.Margin = new System.Windows.Forms.Padding(4);
            this.bDecrypt.Name = "bDecrypt";
            this.bDecrypt.Size = new System.Drawing.Size(128, 42);
            this.bDecrypt.TabIndex = 7;
            this.bDecrypt.Text = "<<";
            this.bDecrypt.UseVisualStyleBackColor = true;
            this.bDecrypt.Click += new System.EventHandler(this.bDecrypt_Click);
            // 
            // pbEncryptedImg
            // 
            this.pbEncryptedImg.Location = new System.Drawing.Point(616, 7);
            this.pbEncryptedImg.Margin = new System.Windows.Forms.Padding(4);
            this.pbEncryptedImg.Name = "pbEncryptedImg";
            this.pbEncryptedImg.Size = new System.Drawing.Size(464, 343);
            this.pbEncryptedImg.TabIndex = 9;
            this.pbEncryptedImg.TabStop = false;
            // 
            // bDecryptImg
            // 
            this.bDecryptImg.Location = new System.Drawing.Point(480, 159);
            this.bDecryptImg.Margin = new System.Windows.Forms.Padding(4);
            this.bDecryptImg.Name = "bDecryptImg";
            this.bDecryptImg.Size = new System.Drawing.Size(128, 42);
            this.bDecryptImg.TabIndex = 11;
            this.bDecryptImg.Text = "<<";
            this.bDecryptImg.UseVisualStyleBackColor = true;
            this.bDecryptImg.Click += new System.EventHandler(this.bDecryptImg_Click);
            // 
            // bEncryptImg
            // 
            this.bEncryptImg.Location = new System.Drawing.Point(480, 109);
            this.bEncryptImg.Margin = new System.Windows.Forms.Padding(4);
            this.bEncryptImg.Name = "bEncryptImg";
            this.bEncryptImg.Size = new System.Drawing.Size(128, 42);
            this.bEncryptImg.TabIndex = 10;
            this.bEncryptImg.Text = ">>";
            this.bEncryptImg.UseVisualStyleBackColor = true;
            this.bEncryptImg.Click += new System.EventHandler(this.bEncryptImg_Click);
            // 
            // bOpenImg
            // 
            this.bOpenImg.Location = new System.Drawing.Point(7, 358);
            this.bOpenImg.Margin = new System.Windows.Forms.Padding(4);
            this.bOpenImg.Name = "bOpenImg";
            this.bOpenImg.Size = new System.Drawing.Size(100, 28);
            this.bOpenImg.TabIndex = 12;
            this.bOpenImg.Text = "Open";
            this.bOpenImg.UseVisualStyleBackColor = true;
            this.bOpenImg.Click += new System.EventHandler(this.bOpenImg_Click);
            // 
            // bOpenEncryptedImg
            // 
            this.bOpenEncryptedImg.Location = new System.Drawing.Point(616, 358);
            this.bOpenEncryptedImg.Margin = new System.Windows.Forms.Padding(4);
            this.bOpenEncryptedImg.Name = "bOpenEncryptedImg";
            this.bOpenEncryptedImg.Size = new System.Drawing.Size(100, 28);
            this.bOpenEncryptedImg.TabIndex = 13;
            this.bOpenEncryptedImg.Text = "Open";
            this.bOpenEncryptedImg.UseVisualStyleBackColor = true;
            this.bOpenEncryptedImg.Click += new System.EventHandler(this.bOpenEncryptedImg_Click);
            // 
            // openFileDialogImg
            // 
            this.openFileDialogImg.FileName = "openFileDialog1";
            this.openFileDialogImg.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif;" +
    " *.png";
            // 
            // bOpenPlainText
            // 
            this.bOpenPlainText.Location = new System.Drawing.Point(7, 357);
            this.bOpenPlainText.Margin = new System.Windows.Forms.Padding(4);
            this.bOpenPlainText.Name = "bOpenPlainText";
            this.bOpenPlainText.Size = new System.Drawing.Size(100, 28);
            this.bOpenPlainText.TabIndex = 14;
            this.bOpenPlainText.Text = "Open";
            this.bOpenPlainText.UseVisualStyleBackColor = true;
            this.bOpenPlainText.Click += new System.EventHandler(this.bOpenPlainText_Click);
            // 
            // bOpenEncryptedText
            // 
            this.bOpenEncryptedText.Location = new System.Drawing.Point(617, 357);
            this.bOpenEncryptedText.Margin = new System.Windows.Forms.Padding(4);
            this.bOpenEncryptedText.Name = "bOpenEncryptedText";
            this.bOpenEncryptedText.Size = new System.Drawing.Size(100, 28);
            this.bOpenEncryptedText.TabIndex = 15;
            this.bOpenEncryptedText.Text = "Open";
            this.bOpenEncryptedText.UseVisualStyleBackColor = true;
            this.bOpenEncryptedText.Click += new System.EventHandler(this.bOpenEncryptedText_Click);
            // 
            // openFileDialogText
            // 
            this.openFileDialogText.FileName = "openFileDialog1";
            this.openFileDialogText.Filter = "Text files | *.txt";
            // 
            // bSavePlainText
            // 
            this.bSavePlainText.Location = new System.Drawing.Point(115, 357);
            this.bSavePlainText.Margin = new System.Windows.Forms.Padding(4);
            this.bSavePlainText.Name = "bSavePlainText";
            this.bSavePlainText.Size = new System.Drawing.Size(100, 28);
            this.bSavePlainText.TabIndex = 16;
            this.bSavePlainText.Text = "Save";
            this.bSavePlainText.UseVisualStyleBackColor = true;
            this.bSavePlainText.Click += new System.EventHandler(this.bSavePlainText_Click);
            // 
            // bSaveEncryptedText
            // 
            this.bSaveEncryptedText.Location = new System.Drawing.Point(725, 357);
            this.bSaveEncryptedText.Margin = new System.Windows.Forms.Padding(4);
            this.bSaveEncryptedText.Name = "bSaveEncryptedText";
            this.bSaveEncryptedText.Size = new System.Drawing.Size(100, 28);
            this.bSaveEncryptedText.TabIndex = 17;
            this.bSaveEncryptedText.Text = "Save";
            this.bSaveEncryptedText.UseVisualStyleBackColor = true;
            this.bSaveEncryptedText.Click += new System.EventHandler(this.bSaveEncryptedText_Click);
            // 
            // bSavePlainImg
            // 
            this.bSavePlainImg.Location = new System.Drawing.Point(115, 358);
            this.bSavePlainImg.Margin = new System.Windows.Forms.Padding(4);
            this.bSavePlainImg.Name = "bSavePlainImg";
            this.bSavePlainImg.Size = new System.Drawing.Size(100, 28);
            this.bSavePlainImg.TabIndex = 18;
            this.bSavePlainImg.Text = "Save";
            this.bSavePlainImg.UseVisualStyleBackColor = true;
            this.bSavePlainImg.Click += new System.EventHandler(this.bSavePlainImg_Click);
            // 
            // bSaveEncryptedImg
            // 
            this.bSaveEncryptedImg.Location = new System.Drawing.Point(724, 358);
            this.bSaveEncryptedImg.Margin = new System.Windows.Forms.Padding(4);
            this.bSaveEncryptedImg.Name = "bSaveEncryptedImg";
            this.bSaveEncryptedImg.Size = new System.Drawing.Size(100, 28);
            this.bSaveEncryptedImg.TabIndex = 19;
            this.bSaveEncryptedImg.Text = "Save";
            this.bSaveEncryptedImg.UseVisualStyleBackColor = true;
            this.bSaveEncryptedImg.Click += new System.EventHandler(this.bSaveEncryptedImg_Click);
            // 
            // bClearPlainText
            // 
            this.bClearPlainText.Location = new System.Drawing.Point(223, 357);
            this.bClearPlainText.Margin = new System.Windows.Forms.Padding(4);
            this.bClearPlainText.Name = "bClearPlainText";
            this.bClearPlainText.Size = new System.Drawing.Size(100, 28);
            this.bClearPlainText.TabIndex = 20;
            this.bClearPlainText.Text = "Clear";
            this.bClearPlainText.UseVisualStyleBackColor = true;
            this.bClearPlainText.Click += new System.EventHandler(this.bClearPlainText_Click);
            // 
            // bClearEnText
            // 
            this.bClearEnText.Location = new System.Drawing.Point(833, 357);
            this.bClearEnText.Margin = new System.Windows.Forms.Padding(4);
            this.bClearEnText.Name = "bClearEnText";
            this.bClearEnText.Size = new System.Drawing.Size(100, 28);
            this.bClearEnText.TabIndex = 21;
            this.bClearEnText.Text = "Clear";
            this.bClearEnText.UseVisualStyleBackColor = true;
            this.bClearEnText.Click += new System.EventHandler(this.bClearEnText_Click);
            // 
            // bClearPlainImg
            // 
            this.bClearPlainImg.Location = new System.Drawing.Point(223, 358);
            this.bClearPlainImg.Margin = new System.Windows.Forms.Padding(4);
            this.bClearPlainImg.Name = "bClearPlainImg";
            this.bClearPlainImg.Size = new System.Drawing.Size(100, 28);
            this.bClearPlainImg.TabIndex = 22;
            this.bClearPlainImg.Text = "Clear";
            this.bClearPlainImg.UseVisualStyleBackColor = true;
            this.bClearPlainImg.Click += new System.EventHandler(this.bClearPlainImg_Click);
            // 
            // bClearEnImg
            // 
            this.bClearEnImg.Location = new System.Drawing.Point(832, 358);
            this.bClearEnImg.Margin = new System.Windows.Forms.Padding(4);
            this.bClearEnImg.Name = "bClearEnImg";
            this.bClearEnImg.Size = new System.Drawing.Size(100, 28);
            this.bClearEnImg.TabIndex = 23;
            this.bClearEnImg.Text = "Clear";
            this.bClearEnImg.UseVisualStyleBackColor = true;
            this.bClearEnImg.Click += new System.EventHandler(this.bClearEnImg_Click);
            // 
            // saveFileDialogText
            // 
            this.saveFileDialogText.Filter = "Text files | *.txt";
            // 
            // saveFileDialogImg
            // 
            this.saveFileDialogImg.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif;" +
    " *.png";
            // 
            // bOpenKey
            // 
            this.bOpenKey.Location = new System.Drawing.Point(680, 80);
            this.bOpenKey.Margin = new System.Windows.Forms.Padding(4);
            this.bOpenKey.Name = "bOpenKey";
            this.bOpenKey.Size = new System.Drawing.Size(155, 28);
            this.bOpenKey.TabIndex = 28;
            this.bOpenKey.Text = "Open parameters";
            this.bOpenKey.UseVisualStyleBackColor = true;
            this.bOpenKey.Click += new System.EventHandler(this.bOpenKey_Click);
            // 
            // bSaveKey
            // 
            this.bSaveKey.Location = new System.Drawing.Point(680, 116);
            this.bSaveKey.Margin = new System.Windows.Forms.Padding(4);
            this.bSaveKey.Name = "bSaveKey";
            this.bSaveKey.Size = new System.Drawing.Size(155, 28);
            this.bSaveKey.TabIndex = 29;
            this.bSaveKey.Text = "Save parameters";
            this.bSaveKey.UseVisualStyleBackColor = true;
            this.bSaveKey.Click += new System.EventHandler(this.bSaveKey_Click);
            // 
            // saveFileDialogKey
            // 
            this.saveFileDialogKey.Filter = "xml file | *.xml";
            // 
            // openFileDialogKey
            // 
            this.openFileDialogKey.FileName = "openFileDialog1";
            this.openFileDialogKey.Filter = "xml file | *.xml";
            // 
            // gbCipherParameters
            // 
            this.gbCipherParameters.Location = new System.Drawing.Point(16, 62);
            this.gbCipherParameters.Margin = new System.Windows.Forms.Padding(4);
            this.gbCipherParameters.Name = "gbCipherParameters";
            this.gbCipherParameters.Padding = new System.Windows.Forms.Padding(4);
            this.gbCipherParameters.Size = new System.Drawing.Size(639, 100);
            this.gbCipherParameters.TabIndex = 30;
            this.gbCipherParameters.TabStop = false;
            this.gbCipherParameters.Text = "cipher parameters";
            // 
            // pbPlainImg
            // 
            this.pbPlainImg.Location = new System.Drawing.Point(7, 7);
            this.pbPlainImg.Margin = new System.Windows.Forms.Padding(4);
            this.pbPlainImg.Name = "pbPlainImg";
            this.pbPlainImg.Size = new System.Drawing.Size(464, 343);
            this.pbPlainImg.TabIndex = 8;
            this.pbPlainImg.TabStop = false;
            // 
            // lError
            // 
            this.lError.AutoSize = true;
            this.lError.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lError.ForeColor = System.Drawing.Color.OrangeRed;
            this.lError.Location = new System.Drawing.Point(288, 16);
            this.lError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lError.Name = "lError";
            this.lError.Size = new System.Drawing.Size(0, 15);
            this.lError.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageTextEncryption);
            this.tabControl1.Controls.Add(this.tabPageImgEncryption);
            this.tabControl1.Location = new System.Drawing.Point(19, 176);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1095, 427);
            this.tabControl1.TabIndex = 24;
            // 
            // tabPageTextEncryption
            // 
            this.tabPageTextEncryption.Controls.Add(this.tbEnctyptedText);
            this.tabPageTextEncryption.Controls.Add(this.bClearEnText);
            this.tabPageTextEncryption.Controls.Add(this.tbPlainText);
            this.tabPageTextEncryption.Controls.Add(this.bOpenPlainText);
            this.tabPageTextEncryption.Controls.Add(this.bOpenEncryptedText);
            this.tabPageTextEncryption.Controls.Add(this.bSavePlainText);
            this.tabPageTextEncryption.Controls.Add(this.bClearPlainText);
            this.tabPageTextEncryption.Controls.Add(this.bEncrypt);
            this.tabPageTextEncryption.Controls.Add(this.bDecrypt);
            this.tabPageTextEncryption.Controls.Add(this.bSaveEncryptedText);
            this.tabPageTextEncryption.Location = new System.Drawing.Point(4, 25);
            this.tabPageTextEncryption.Name = "tabPageTextEncryption";
            this.tabPageTextEncryption.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTextEncryption.Size = new System.Drawing.Size(1087, 398);
            this.tabPageTextEncryption.TabIndex = 0;
            this.tabPageTextEncryption.Text = "Text Encryption";
            this.tabPageTextEncryption.UseVisualStyleBackColor = true;
            // 
            // tabPagepageImgEncryption
            // 
            this.tabPageImgEncryption.Controls.Add(this.pbPlainImg);
            this.tabPageImgEncryption.Controls.Add(this.bOpenEncryptedImg);
            this.tabPageImgEncryption.Controls.Add(this.bSavePlainImg);
            this.tabPageImgEncryption.Controls.Add(this.bEncryptImg);
            this.tabPageImgEncryption.Controls.Add(this.bClearPlainImg);
            this.tabPageImgEncryption.Controls.Add(this.bClearEnImg);
            this.tabPageImgEncryption.Controls.Add(this.bOpenImg);
            this.tabPageImgEncryption.Controls.Add(this.bSaveEncryptedImg);
            this.tabPageImgEncryption.Controls.Add(this.bDecryptImg);
            this.tabPageImgEncryption.Controls.Add(this.pbEncryptedImg);
            this.tabPageImgEncryption.Location = new System.Drawing.Point(4, 25);
            this.tabPageImgEncryption.Name = "tabPagepageImgEncryption";
            this.tabPageImgEncryption.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageImgEncryption.Size = new System.Drawing.Size(1087, 398);
            this.tabPageImgEncryption.TabIndex = 1;
            this.tabPageImgEncryption.Text = "Image Encryption";
            this.tabPageImgEncryption.UseVisualStyleBackColor = true;
            // 
            // EncryptorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 620);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.gbCipherParameters);
            this.Controls.Add(this.bSaveKey);
            this.Controls.Add(this.bOpenKey);
            this.Controls.Add(this.lError);
            this.Controls.Add(this.cbCipher);
            this.Controls.Add(this.l_cipherType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "EncryptorForm";
            this.ShowIcon = false;
            this.Text = "Encryptor";
            ((System.ComponentModel.ISupportInitialize)(this.pbEncryptedImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlainImg)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageTextEncryption.ResumeLayout(false);
            this.tabPageTextEncryption.PerformLayout();
            this.tabPageImgEncryption.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_cipherType;
        private System.Windows.Forms.ComboBox cbCipher;
        private System.Windows.Forms.TextBox tbPlainText;
        private System.Windows.Forms.TextBox tbEnctyptedText;
        private System.Windows.Forms.Button bEncrypt;
        private System.Windows.Forms.Button bDecrypt;
        private System.Windows.Forms.PictureBox pbEncryptedImg;
        private System.Windows.Forms.Button bDecryptImg;
        private System.Windows.Forms.Button bEncryptImg;
        private System.Windows.Forms.Button bOpenImg;
        private System.Windows.Forms.Button bOpenEncryptedImg;
        private System.Windows.Forms.OpenFileDialog openFileDialogImg;
        private System.Windows.Forms.Button bOpenPlainText;
        private System.Windows.Forms.Button bOpenEncryptedText;
        private System.Windows.Forms.OpenFileDialog openFileDialogText;
        private System.Windows.Forms.Button bSavePlainText;
        private System.Windows.Forms.Button bSaveEncryptedText;
        private System.Windows.Forms.Button bSavePlainImg;
        private System.Windows.Forms.Button bSaveEncryptedImg;
        private System.Windows.Forms.Button bClearPlainText;
        private System.Windows.Forms.Button bClearEnText;
        private System.Windows.Forms.Button bClearPlainImg;
        private System.Windows.Forms.Button bClearEnImg;
        private System.Windows.Forms.SaveFileDialog saveFileDialogText;
        private System.Windows.Forms.SaveFileDialog saveFileDialogImg;
        private System.Windows.Forms.Button bOpenKey;
        private System.Windows.Forms.Button bSaveKey;
        private System.Windows.Forms.SaveFileDialog saveFileDialogKey;
        private System.Windows.Forms.OpenFileDialog openFileDialogKey;
        private System.Windows.Forms.GroupBox gbCipherParameters;
        private System.Windows.Forms.PictureBox pbPlainImg;
        private System.Windows.Forms.Label lError;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageTextEncryption;
        private System.Windows.Forms.TabPage tabPageImgEncryption;
    }
}

