﻿namespace SymmetricBlockCiphers
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbIV = new System.Windows.Forms.TextBox();
            this.bOpenKey = new System.Windows.Forms.Button();
            this.bSaveKey = new System.Windows.Forms.Button();
            this.saveFileDialogKey = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogKey = new System.Windows.Forms.OpenFileDialog();
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
            // 
            // l_cipherMode
            // 
            this.l_cipherMode.AutoSize = true;
            this.l_cipherMode.Location = new System.Drawing.Point(214, 13);
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
            "CFB",
            "CTS"});
            this.cbCipherMode.Location = new System.Drawing.Point(296, 10);
            this.cbCipherMode.Name = "cbCipherMode";
            this.cbCipherMode.Size = new System.Drawing.Size(121, 21);
            this.cbCipherMode.TabIndex = 3;
            // 
            // tbPlainText
            // 
            this.tbPlainText.Location = new System.Drawing.Point(14, 97);
            this.tbPlainText.Multiline = true;
            this.tbPlainText.Name = "tbPlainText";
            this.tbPlainText.Size = new System.Drawing.Size(348, 279);
            this.tbPlainText.TabIndex = 4;
            // 
            // tbEnctyptedText
            // 
            this.tbEnctyptedText.Location = new System.Drawing.Point(493, 97);
            this.tbEnctyptedText.Multiline = true;
            this.tbEnctyptedText.Name = "tbEnctyptedText";
            this.tbEnctyptedText.Size = new System.Drawing.Size(348, 279);
            this.tbEnctyptedText.TabIndex = 5;
            // 
            // bEncrypt
            // 
            this.bEncrypt.Location = new System.Drawing.Point(381, 169);
            this.bEncrypt.Name = "bEncrypt";
            this.bEncrypt.Size = new System.Drawing.Size(96, 34);
            this.bEncrypt.TabIndex = 6;
            this.bEncrypt.Text = ">>";
            this.bEncrypt.UseVisualStyleBackColor = true;
            this.bEncrypt.Click += new System.EventHandler(this.bEncrypt_Click);
            // 
            // bDecrypt
            // 
            this.bDecrypt.Location = new System.Drawing.Point(381, 209);
            this.bDecrypt.Name = "bDecrypt";
            this.bDecrypt.Size = new System.Drawing.Size(96, 34);
            this.bDecrypt.TabIndex = 7;
            this.bDecrypt.Text = "<<";
            this.bDecrypt.UseVisualStyleBackColor = true;
            this.bDecrypt.Click += new System.EventHandler(this.bDecrypt_Click);
            // 
            // pbPlainImg
            // 
            this.pbPlainImg.Location = new System.Drawing.Point(14, 420);
            this.pbPlainImg.Name = "pbPlainImg";
            this.pbPlainImg.Size = new System.Drawing.Size(348, 279);
            this.pbPlainImg.TabIndex = 8;
            this.pbPlainImg.TabStop = false;
            // 
            // pbEncryptedImg
            // 
            this.pbEncryptedImg.Location = new System.Drawing.Point(493, 420);
            this.pbEncryptedImg.Name = "pbEncryptedImg";
            this.pbEncryptedImg.Size = new System.Drawing.Size(348, 279);
            this.pbEncryptedImg.TabIndex = 9;
            this.pbEncryptedImg.TabStop = false;
            // 
            // bDecryptImg
            // 
            this.bDecryptImg.Location = new System.Drawing.Point(381, 548);
            this.bDecryptImg.Name = "bDecryptImg";
            this.bDecryptImg.Size = new System.Drawing.Size(96, 34);
            this.bDecryptImg.TabIndex = 11;
            this.bDecryptImg.Text = "<<";
            this.bDecryptImg.UseVisualStyleBackColor = true;
            this.bDecryptImg.Click += new System.EventHandler(this.bDecryptImg_Click);
            // 
            // bEncryptImg
            // 
            this.bEncryptImg.Location = new System.Drawing.Point(381, 508);
            this.bEncryptImg.Name = "bEncryptImg";
            this.bEncryptImg.Size = new System.Drawing.Size(96, 34);
            this.bEncryptImg.TabIndex = 10;
            this.bEncryptImg.Text = ">>";
            this.bEncryptImg.UseVisualStyleBackColor = true;
            this.bEncryptImg.Click += new System.EventHandler(this.bEncryptImg_Click);
            // 
            // bOpenImg
            // 
            this.bOpenImg.Location = new System.Drawing.Point(14, 706);
            this.bOpenImg.Name = "bOpenImg";
            this.bOpenImg.Size = new System.Drawing.Size(75, 23);
            this.bOpenImg.TabIndex = 12;
            this.bOpenImg.Text = "Open";
            this.bOpenImg.UseVisualStyleBackColor = true;
            this.bOpenImg.Click += new System.EventHandler(this.bOpenImg_Click);
            // 
            // bOpenEncryptedImg
            // 
            this.bOpenEncryptedImg.Location = new System.Drawing.Point(493, 706);
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
            this.openFileDialogImg.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif;" +
    " *.png";
            // 
            // bOpenPlainText
            // 
            this.bOpenPlainText.Location = new System.Drawing.Point(14, 382);
            this.bOpenPlainText.Name = "bOpenPlainText";
            this.bOpenPlainText.Size = new System.Drawing.Size(75, 23);
            this.bOpenPlainText.TabIndex = 14;
            this.bOpenPlainText.Text = "Open";
            this.bOpenPlainText.UseVisualStyleBackColor = true;
            this.bOpenPlainText.Click += new System.EventHandler(this.bOpenPlainText_Click);
            // 
            // bOpenEncryptedText
            // 
            this.bOpenEncryptedText.Location = new System.Drawing.Point(493, 382);
            this.bOpenEncryptedText.Name = "bOpenEncryptedText";
            this.bOpenEncryptedText.Size = new System.Drawing.Size(75, 23);
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
            this.bSavePlainText.Location = new System.Drawing.Point(95, 382);
            this.bSavePlainText.Name = "bSavePlainText";
            this.bSavePlainText.Size = new System.Drawing.Size(75, 23);
            this.bSavePlainText.TabIndex = 16;
            this.bSavePlainText.Text = "Save";
            this.bSavePlainText.UseVisualStyleBackColor = true;
            this.bSavePlainText.Click += new System.EventHandler(this.bSavePlainText_Click);
            // 
            // bSaveEncryptedText
            // 
            this.bSaveEncryptedText.Location = new System.Drawing.Point(574, 382);
            this.bSaveEncryptedText.Name = "bSaveEncryptedText";
            this.bSaveEncryptedText.Size = new System.Drawing.Size(75, 23);
            this.bSaveEncryptedText.TabIndex = 17;
            this.bSaveEncryptedText.Text = "Save";
            this.bSaveEncryptedText.UseVisualStyleBackColor = true;
            this.bSaveEncryptedText.Click += new System.EventHandler(this.bSaveEncryptedText_Click);
            // 
            // bSavePlainImg
            // 
            this.bSavePlainImg.Location = new System.Drawing.Point(95, 706);
            this.bSavePlainImg.Name = "bSavePlainImg";
            this.bSavePlainImg.Size = new System.Drawing.Size(75, 23);
            this.bSavePlainImg.TabIndex = 18;
            this.bSavePlainImg.Text = "Save";
            this.bSavePlainImg.UseVisualStyleBackColor = true;
            this.bSavePlainImg.Click += new System.EventHandler(this.bSavePlainImg_Click);
            // 
            // bSaveEncryptedImg
            // 
            this.bSaveEncryptedImg.Location = new System.Drawing.Point(574, 706);
            this.bSaveEncryptedImg.Name = "bSaveEncryptedImg";
            this.bSaveEncryptedImg.Size = new System.Drawing.Size(75, 23);
            this.bSaveEncryptedImg.TabIndex = 19;
            this.bSaveEncryptedImg.Text = "Save";
            this.bSaveEncryptedImg.UseVisualStyleBackColor = true;
            this.bSaveEncryptedImg.Click += new System.EventHandler(this.bSaveEncryptedImg_Click);
            // 
            // bClearPlainText
            // 
            this.bClearPlainText.Location = new System.Drawing.Point(176, 382);
            this.bClearPlainText.Name = "bClearPlainText";
            this.bClearPlainText.Size = new System.Drawing.Size(75, 23);
            this.bClearPlainText.TabIndex = 20;
            this.bClearPlainText.Text = "Clear";
            this.bClearPlainText.UseVisualStyleBackColor = true;
            this.bClearPlainText.Click += new System.EventHandler(this.bClearPlainText_Click);
            // 
            // bClearEnText
            // 
            this.bClearEnText.Location = new System.Drawing.Point(655, 382);
            this.bClearEnText.Name = "bClearEnText";
            this.bClearEnText.Size = new System.Drawing.Size(75, 23);
            this.bClearEnText.TabIndex = 21;
            this.bClearEnText.Text = "Clear";
            this.bClearEnText.UseVisualStyleBackColor = true;
            this.bClearEnText.Click += new System.EventHandler(this.bClearEnText_Click);
            // 
            // bClearPlainImg
            // 
            this.bClearPlainImg.Location = new System.Drawing.Point(176, 706);
            this.bClearPlainImg.Name = "bClearPlainImg";
            this.bClearPlainImg.Size = new System.Drawing.Size(75, 23);
            this.bClearPlainImg.TabIndex = 22;
            this.bClearPlainImg.Text = "Clear";
            this.bClearPlainImg.UseVisualStyleBackColor = true;
            this.bClearPlainImg.Click += new System.EventHandler(this.bClearPlainImg_Click);
            // 
            // bClearEnImg
            // 
            this.bClearEnImg.Location = new System.Drawing.Point(655, 706);
            this.bClearEnImg.Name = "bClearEnImg";
            this.bClearEnImg.Size = new System.Drawing.Size(75, 23);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "key";
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(45, 49);
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(150, 20);
            this.tbKey.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "IV";
            // 
            // tbIV
            // 
            this.tbIV.Location = new System.Drawing.Point(237, 49);
            this.tbIV.Name = "tbIV";
            this.tbIV.Size = new System.Drawing.Size(180, 20);
            this.tbIV.TabIndex = 27;
            // 
            // bOpenKey
            // 
            this.bOpenKey.Location = new System.Drawing.Point(449, 13);
            this.bOpenKey.Name = "bOpenKey";
            this.bOpenKey.Size = new System.Drawing.Size(75, 23);
            this.bOpenKey.TabIndex = 28;
            this.bOpenKey.Text = "Open";
            this.bOpenKey.UseVisualStyleBackColor = true;
            this.bOpenKey.Click += new System.EventHandler(this.bOpenKey_Click);
            // 
            // bSaveKey
            // 
            this.bSaveKey.Location = new System.Drawing.Point(449, 49);
            this.bSaveKey.Name = "bSaveKey";
            this.bSaveKey.Size = new System.Drawing.Size(75, 23);
            this.bSaveKey.TabIndex = 29;
            this.bSaveKey.Text = "Save";
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
            // EncoderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 736);
            this.Controls.Add(this.bSaveKey);
            this.Controls.Add(this.bOpenKey);
            this.Controls.Add(this.tbIV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbKey);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bClearEnImg);
            this.Controls.Add(this.bClearPlainImg);
            this.Controls.Add(this.bClearEnText);
            this.Controls.Add(this.bClearPlainText);
            this.Controls.Add(this.bSaveEncryptedImg);
            this.Controls.Add(this.bSavePlainImg);
            this.Controls.Add(this.bSaveEncryptedText);
            this.Controls.Add(this.bSavePlainText);
            this.Controls.Add(this.bOpenEncryptedText);
            this.Controls.Add(this.bOpenPlainText);
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
            this.Text = "Encryptor";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbIV;
        private System.Windows.Forms.Button bOpenKey;
        private System.Windows.Forms.Button bSaveKey;
        private System.Windows.Forms.SaveFileDialog saveFileDialogKey;
        private System.Windows.Forms.OpenFileDialog openFileDialogKey;
    }
}
