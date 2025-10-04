using JunX.NET8.EncryptionService;
using JunX.NET8.WinForms;

namespace JunX.NET8_Encryptor_Decryptor
{
    public partial class Main : Form
    {
        private const string MSG_TITLE = "JunX.NET8 Encryptor-Decryptor";

        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtKey.Text = "";
            Forms.ClearControlText(Forms.ControlType<RichTextBox>.Extract(this, "rtxt"));
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKey.Text))
            {
                MessageBox.Show("Please enter Key for encryption/decryption.", MSG_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(rtxtDecrypted.Text))
            {
                MessageBox.Show("No string to encrypt.", MSG_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            EncryptionService ES = new EncryptionService(txtKey.Text);
            try
            {
                rtxtEncrypted.Text = ES.Encrypt(rtxtDecrypted.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Encryption Error:\n\n" + ex.Message.ToString(), MSG_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKey.Text))
            {
                MessageBox.Show("Please enter Key for encryption/decryption.", MSG_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(rtxtEncrypted.Text))
            {
                MessageBox.Show("No string to decrypt.", MSG_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            EncryptionService ES = new EncryptionService(txtKey.Text);
            try
            {
                rtxtDecrypted.Text = ES.Decrypt(rtxtEncrypted.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Decryption Error:\n\n" + ex.Message.ToString(), MSG_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Form1_Load(this, EventArgs.Empty);
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}
