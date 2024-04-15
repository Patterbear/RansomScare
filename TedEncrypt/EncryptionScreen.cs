using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TedEncrypt
{
    public partial class EncryptionScreen : Form
    {
        public EncryptionScreen()
        {
            InitializeComponent();

            // Prevent resizing
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;

        }

        private void encryptionDoneButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            EncryptedScreen encryptedScreen = new EncryptedScreen();
            encryptedScreen.ShowDialog();
            this.Close();
        }

        private void beginButton_Click(object sender, EventArgs e)
        {
            // Disable 'begin' button
            beginButton.Enabled = false;

            // Update status label
            statusLabel.Text = "Status: Encrypting...";
            statusLabel.Update();

            // Decrypts files
            new Cryptography().EncryptFiles();

            // Update status label
            statusLabel.Text = "Status: Encrypted";
            statusLabel.Update();

            // Hide 'begin' button
            beginButton.Hide();

            // Enables 'finish' button
            encryptionDoneButton.Enabled = true;
        }
    }
}
