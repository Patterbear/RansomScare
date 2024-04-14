using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TedEncrypt
{
    public partial class EncryptedScreen : Form
    {
        public EncryptedScreen()
        {
            InitializeComponent();

            // Prevent resizing
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void decryptButton_Click(object sender, EventArgs e)
        {
            // Checks for key before attempting decryption
            if(CheckForKey() is true)
            {
                Console.WriteLine("Key found.");
            } else
            {
                MessageBox.Show("Please put the key into the directory.", "Key not found");
            }
        }

        // Key check function
        // checks to see if a key is present in the directory
        private bool CheckForKey()
        {
            return File.Exists(Directory.GetCurrentDirectory() + "\\key");
        }
    }
}
