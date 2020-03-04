namespace SymmetricBlockCiphers
{
    partial class EncoderForm
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
            this.l_cipherMode = new System.Windows.Forms.Label();
            this.cbCipherMode = new System.Windows.Forms.ComboBox();
            this.tbPlainText = new System.Windows.Forms.TextBox();
            this.tbEnctyptedText = new System.Windows.Forms.TextBox();
            this.bEncrypt = new System.Windows.Forms.Button();
            this.bDecrypt = new System.Windows.Forms.Button();
            this.pbPlainImg = new System.Windows.Forms.PictureBox();
            this.pbEncryptedImg = new System.Windows.Forms.PictureBox();
            this.bDecryptImg = new System.Windows.Forms.Button();
            this.bEncryptImg = new System.Windows.Forms.Button();
            this.bOpenImg = new System.Windows.Forms.Button();
            this.bOpenEncryptedImg = new System.Windows.Forms.Button();
            this.openFileDialogImg = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlainImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEncryptedImg)).BeginInit();
            this.SuspendLayout();
            // 
            // l_cipherType
            // 
            this.l_cipherType.AutoSize = true;
            this.l_cipherType.Location = new System.Drawing.Point(13, 13);
            this.l_cipherType.Name = "l_cipherType";
            this.l_cipherType.Size = new System.Drawing.Size(41, 15);
            this.l_cipherType.TabIndex = 0;
            this.l_cipherType.Text = "cipher";
            // 
            // cbCipher
            // 
            this.cbCipher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCipher.FormattingEnabled = true;
            this.cbCipher.Items.AddRange(new object[] {
            "DES",
            "AES"});
            this.cbCipher.Location = new System.Drawing.Point(74, 10);
            this.cbCipher.Name = "cbCipher";
            this.cbCipher.Size = new System.Drawing.Size(121, 21);
            this.cbCipher.TabIndex = 1;
            this.cbCipher.SelectedIndexChanged += new System.EventHandler(this.cbCipher_SelectedIndexChanged);
            // 
            // l_cipherMode
            // 
            this.l_cipherMode.AutoSize = true;
            this.l_cipherMode.Location = new System.Drawing.Point(419, 13);
            this.l_cipherMode.Name = "l_cipherMode";
            this.l_cipherMode.Size = new System.Drawing.Size(76, 15);
            this.l_cipherMode.TabIndex = 2;
            this.l_cipherMode.Text = "cipher mode";
            // 
            // cbCipherMode
            // 
            this.cbCipherMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCipherMode.FormattingEnabled = true;
            this.cbCipherMode.Items.AddRange(new object[] {
            "CBC",
            "ECB",
            "OFB",
            "CFB",
            "CTS"});
            this.cbCipherMode.Location = new System.Drawing.Point(501, 10);
            this.cbCipherMode.Name = "cbCipherMode";
            this.cbCipherMode.Size = new System.Drawing.Size(121, 21);
            this.cbCipherMode.TabIndex = 3;
            this.cbCipherMode.SelectedIndexChanged += new System.EventHandler(this.cbCipherMode_SelectedIndexChanged);
            // 
            // tbPlainText
            // 
            this.tbPlainText.Location = new System.Drawing.Point(12, 53);
            this.tbPlainText.Multiline = true;
            this.tbPlainText.Name = "tbPlainText";
            this.tbPlainText.Size = new System.Drawing.Size(348, 279);
            this.tbPlainText.TabIndex = 4;
            // 
            // tbEnctyptedText
            // 
            this.tbEnctyptedText.Location = new System.Drawing.Point(491, 53);
            this.tbEnctyptedText.Multiline = true;
            this.tbEnctyptedText.Name = "tbEnctyptedText";
            this.tbEnctyptedText.Size = new System.Drawing.Size(348, 279);
            this.tbEnctyptedText.TabIndex = 5;
            // 
            // bEncrypt
            // 
            this.bEncrypt.Location = new System.Drawing.Point(379, 125);
            this.bEncrypt.Name = "bEncrypt";
            this.bEncrypt.Size = new System.Drawing.Size(96, 34);
            this.bEncrypt.TabIndex = 6;
            this.bEncrypt.Text = ">>";
            this.bEncrypt.UseVisualStyleBackColor = true;
            this.bEncrypt.Click += new System.EventHandler(this.bEncrypt_Click);
            // 
            // bDecrypt
            // 
            this.bDecrypt.Location = new System.Drawing.Point(379, 165);
            this.bDecrypt.Name = "bDecrypt";
            this.bDecrypt.Size = new System.Drawing.Size(96, 34);
            this.bDecrypt.TabIndex = 7;
            this.bDecrypt.Text = "<<";
            this.bDecrypt.UseVisualStyleBackColor = true;
            this.bDecrypt.Click += new System.EventHandler(this.bDecrypt_Click);
            // 
            // pbPlainImg
            // 
            this.pbPlainImg.Location = new System.Drawing.Point(12, 359);
            this.pbPlainImg.Name = "pbPlainImg";
            this.pbPlainImg.Size = new System.Drawing.Size(348, 279);
            this.pbPlainImg.TabIndex = 8;
            this.pbPlainImg.TabStop = false;
            // 
            // pbEncryptedImg
            // 
            this.pbEncryptedImg.Location = new System.Drawing.Point(491, 359);
            this.pbEncryptedImg.Name = "pbEncryptedImg";
            this.pbEncryptedImg.Size = new System.Drawing.Size(348, 279);
            this.pbEncryptedImg.TabIndex = 9;
            this.pbEncryptedImg.TabStop = false;
            // 
            // bDecryptImg
            // 
            this.bDecryptImg.Location = new System.Drawing.Point(379, 487);
            this.bDecryptImg.Name = "bDecryptImg";
            this.bDecryptImg.Size = new System.Drawing.Size(96, 34);
            this.bDecryptImg.TabIndex = 11;
            this.bDecryptImg.Text = "<<";
            this.bDecryptImg.UseVisualStyleBackColor = true;
            this.bDecryptImg.Click += new System.EventHandler(this.bDecryptImg_Click);
            // 
            // bEncryptImg
            // 
            this.bEncryptImg.Location = new System.Drawing.Point(379, 447);
            this.bEncryptImg.Name = "bEncryptImg";
            this.bEncryptImg.Size = new System.Drawing.Size(96, 34);
            this.bEncryptImg.TabIndex = 10;
            this.bEncryptImg.Text = ">>";
            this.bEncryptImg.UseVisualStyleBackColor = true;
            this.bEncryptImg.Click += new System.EventHandler(this.bEncryptImg_Click);
            // 
            // bOpenImg
            // 
            this.bOpenImg.Location = new System.Drawing.Point(12, 645);
            this.bOpenImg.Name = "bOpenImg";
            this.bOpenImg.Size = new System.Drawing.Size(75, 23);
            this.bOpenImg.TabIndex = 12;
            this.bOpenImg.Text = "Open";
            this.bOpenImg.UseVisualStyleBackColor = true;
            this.bOpenImg.Click += new System.EventHandler(this.bOpenImg_Click);
            // 
            // bOpenEncryptedImg
            // 
            this.bOpenEncryptedImg.Location = new System.Drawing.Point(491, 645);
            this.bOpenEncryptedImg.Name = "bOpenEncryptedImg";
            this.bOpenEncryptedImg.Size = new System.Drawing.Size(75, 23);
            this.bOpenEncryptedImg.TabIndex = 13;
            this.bOpenEncryptedImg.Text = "Open";
            this.bOpenEncryptedImg.UseVisualStyleBackColor = true;
            this.bOpenEncryptedImg.Click += new System.EventHandler(this.bOpenEncryptedImg_Click);
            // 
            // openFileDialogImg
            // 
            this.openFileDialogImg.FileName = "openFileDialog1";
            // 
            // EncoderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 694);
            this.Controls.Add(this.bOpenEncryptedImg);
            this.Controls.Add(this.bOpenImg);
            this.Controls.Add(this.bDecryptImg);
            this.Controls.Add(this.bEncryptImg);
            this.Controls.Add(this.pbEncryptedImg);
            this.Controls.Add(this.pbPlainImg);
            this.Controls.Add(this.bDecrypt);
            this.Controls.Add(this.bEncrypt);
            this.Controls.Add(this.tbEnctyptedText);
            this.Controls.Add(this.tbPlainText);
            this.Controls.Add(this.cbCipherMode);
            this.Controls.Add(this.l_cipherMode);
            this.Controls.Add(this.cbCipher);
            this.Controls.Add(this.l_cipherType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EncoderForm";
            this.ShowIcon = false;
            this.Text = "EncoderDecoder";
            ((System.ComponentModel.ISupportInitialize)(this.pbPlainImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEncryptedImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_cipherType;
        private System.Windows.Forms.ComboBox cbCipher;
        private System.Windows.Forms.Label l_cipherMode;
        private System.Windows.Forms.ComboBox cbCipherMode;
        private System.Windows.Forms.TextBox tbPlainText;
        private System.Windows.Forms.TextBox tbEnctyptedText;
        private System.Windows.Forms.Button bEncrypt;
        private System.Windows.Forms.Button bDecrypt;
        private System.Windows.Forms.PictureBox pbPlainImg;
        private System.Windows.Forms.PictureBox pbEncryptedImg;
        private System.Windows.Forms.Button bDecryptImg;
        private System.Windows.Forms.Button bEncryptImg;
        private System.Windows.Forms.Button bOpenImg;
        private System.Windows.Forms.Button bOpenEncryptedImg;
        private System.Windows.Forms.OpenFileDialog openFileDialogImg;
    }
}

