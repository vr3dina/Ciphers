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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.bEncode = new System.Windows.Forms.Button();
            this.bDecode = new System.Windows.Forms.Button();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 53);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(348, 279);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(491, 53);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(348, 279);
            this.textBox2.TabIndex = 5;
            // 
            // bEncode
            // 
            this.bEncode.Location = new System.Drawing.Point(379, 125);
            this.bEncode.Name = "bEncode";
            this.bEncode.Size = new System.Drawing.Size(96, 34);
            this.bEncode.TabIndex = 6;
            this.bEncode.Text = ">>";
            this.bEncode.UseVisualStyleBackColor = true;
            this.bEncode.Click += new System.EventHandler(this.bEncode_Click);
            // 
            // bDecode
            // 
            this.bDecode.Location = new System.Drawing.Point(379, 165);
            this.bDecode.Name = "bDecode";
            this.bDecode.Size = new System.Drawing.Size(96, 34);
            this.bDecode.TabIndex = 7;
            this.bDecode.Text = "<<";
            this.bDecode.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 349);
            this.Controls.Add(this.bDecode);
            this.Controls.Add(this.bEncode);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cbCipherMode);
            this.Controls.Add(this.l_cipherMode);
            this.Controls.Add(this.cbCipher);
            this.Controls.Add(this.l_cipherType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button bEncode;
        private System.Windows.Forms.Button bDecode;
    }
}

