using System;
using System.Windows.Forms;

namespace TedEncrypt
{
    public partial class DecryptionScreen : Form
    {
        public DecryptionScreen()
        {
            InitializeComponent();

            // Prevent resizing
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void decryptionDoneButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DecryptedScreen decryptedScreen = new DecryptedScreen();
            decryptedScreen.ShowDialog();
            this.Close();
        }

        private void beginButton_Click(object sender, EventArgs e)
        {
            // Disable 'begin' button
            beginButton.Enabled = false;

            // Update status label
            statusLabel.Text = "Status: Decrypting...";
            statusLabel.Update();

            // Decrypts files
            new Cryptography().DecryptFiles();

            // Update status label
            statusLabel.Text = "Status: Decrypted";
            statusLabel.Update();

            // Hide 'begin' button
            beginButton.Hide();

            // Enables 'finish' button
            decryptionDoneButton.Enabled = true;
        }
    }
}
