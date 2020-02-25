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
            this.tbDecryptedText = new System.Windows.Forms.TextBox();
            this.tbEnctyptedText = new System.Windows.Forms.TextBox();
            this.bEncrypt = new System.Windows.Forms.Button();
            this.bDecrypt = new System.Windows.Forms.Button();
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
            // 
            // tbDecryptedText
            // 
            this.tbDecryptedText.Location = new System.Drawing.Point(12, 53);
            this.tbDecryptedText.Multiline = true;
            this.tbDecryptedText.Name = "tbDecryptedText";
            this.tbDecryptedText.Size = new System.Drawing.Size(348, 279);
            this.tbDecryptedText.TabIndex = 4;
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
            // EncoderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 349);
            this.Controls.Add(this.bDecrypt);
            this.Controls.Add(this.bEncrypt);
            this.Controls.Add(this.tbEnctyptedText);
            this.Controls.Add(this.tbDecryptedText);
            this.Controls.Add(this.cbCipherMode);
            this.Controls.Add(this.l_cipherMode);
            this.Controls.Add(this.cbCipher);
            this.Controls.Add(this.l_cipherType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EncoderForm";
            this.ShowIcon = false;
            this.Text = "EncoderDecoder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_cipherType;
        private System.Windows.Forms.ComboBox cbCipher;
        private System.Windows.Forms.Label l_cipherMode;
        private System.Windows.Forms.ComboBox cbCipherMode;
        private System.Windows.Forms.TextBox tbDecryptedText;
        private System.Windows.Forms.TextBox tbEnctyptedText;
        private System.Windows.Forms.Button bEncrypt;
        private System.Windows.Forms.Button bDecrypt;
    }
}

