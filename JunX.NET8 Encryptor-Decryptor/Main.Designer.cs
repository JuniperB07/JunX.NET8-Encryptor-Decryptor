namespace JunX.NET8_Encryptor_Decryptor
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            rtxtEncrypted = new RichTextBox();
            rtxtDecrypted = new RichTextBox();
            label4 = new Label();
            btnDecrypt = new Button();
            btnEncrypt = new Button();
            btnClear = new Button();
            label5 = new Label();
            txtKey = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.JunX_NET8;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(583, 193);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Century Gothic", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 218);
            label1.Name = "label1";
            label1.Size = new Size(583, 50);
            label1.TabIndex = 1;
            label1.Text = "JunX.NET8 Encryptor-Decryptor";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Location = new Point(12, 268);
            label2.Name = "label2";
            label2.Size = new Size(583, 79);
            label2.TabIndex = 2;
            label2.Text = "This app is made to encrypt or decrypt strings using the JunX.NET8.EncryptionService.";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(324, 379);
            label3.Name = "label3";
            label3.Size = new Size(173, 23);
            label3.TabIndex = 3;
            label3.Text = "Encrypted String:";
            // 
            // rtxtEncrypted
            // 
            rtxtEncrypted.Location = new Point(324, 405);
            rtxtEncrypted.Name = "rtxtEncrypted";
            rtxtEncrypted.Size = new Size(271, 120);
            rtxtEncrypted.TabIndex = 3;
            rtxtEncrypted.Text = "";
            // 
            // rtxtDecrypted
            // 
            rtxtDecrypted.Location = new Point(12, 405);
            rtxtDecrypted.Name = "rtxtDecrypted";
            rtxtDecrypted.Size = new Size(271, 120);
            rtxtDecrypted.TabIndex = 2;
            rtxtDecrypted.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 379);
            label4.Name = "label4";
            label4.Size = new Size(178, 23);
            label4.TabIndex = 5;
            label4.Text = "Decrypted String:";
            // 
            // btnDecrypt
            // 
            btnDecrypt.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnDecrypt.Location = new Point(389, 531);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(141, 47);
            btnDecrypt.TabIndex = 5;
            btnDecrypt.Text = "Decrypt";
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // btnEncrypt
            // 
            btnEncrypt.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnEncrypt.Location = new Point(77, 531);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(141, 47);
            btnEncrypt.TabIndex = 4;
            btnEncrypt.Text = "Encrypt";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
            btnClear.Location = new Point(233, 584);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(141, 47);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 347);
            label5.Name = "label5";
            label5.Size = new Size(51, 23);
            label5.TabIndex = 10;
            label5.Text = "Key:";
            // 
            // txtKey
            // 
            txtKey.Location = new Point(69, 344);
            txtKey.Name = "txtKey";
            txtKey.Size = new Size(526, 32);
            txtKey.TabIndex = 1;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(12F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(607, 644);
            Controls.Add(txtKey);
            Controls.Add(label5);
            Controls.Add(btnClear);
            Controls.Add(btnEncrypt);
            Controls.Add(btnDecrypt);
            Controls.Add(rtxtDecrypted);
            Controls.Add(label4);
            Controls.Add(rtxtEncrypted);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "JunX.NET8 Encryptor-Decryptor";
            FormClosing += Main_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private RichTextBox rtxtEncrypted;
        private RichTextBox rtxtDecrypted;
        private Label label4;
        private Button btnDecrypt;
        private Button btnEncrypt;
        private Button btnClear;
        private Label label5;
        private TextBox txtKey;
    }
}
