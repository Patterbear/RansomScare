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
    public partial class DecryptionScreen : Form
    {
        public DecryptionScreen()
        {
            InitializeComponent();

            // Prevent resizing
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;

            // Encrypts files
            new Cryptography().DecryptFiles();

            // Updates progress bar
            statusBar.PerformStep();

            // Enables 'finish' button
            decryptionDoneButton.Enabled = true;
        }

        private void decryptionDoneButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            DecryptedScreen decryptedScreen = new DecryptedScreen();
            decryptedScreen.ShowDialog();
            this.Close();
        }
    }
}
