using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TedEncrypt
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();

            // Prevent resizing
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void githubLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Open my Github profile
            System.Diagnostics.Process.Start("http://github.com/Patterbear");

            // Set link to purple to indicate it has been visited
            githubLink.LinkVisited = true;
        }

        private void proceedButton_Click(object sender, EventArgs e)
        {
            // Checks that the tick box has been ticked
            if(understoodTickBox.Checked)
            {
                // creates initial .tedencrypt file
                string tedencryptFile = Directory.GetCurrentDirectory() + "/.tedencrypt";
                File.Create(tedencryptFile);
                File.SetAttributes(tedencryptFile, FileAttributes.Hidden);

                // Launches encryption screen and closes itself
                this.Hide();
                EncryptionScreen encryptionScreen = new EncryptionScreen();
                encryptionScreen.ShowDialog();
                this.Close();

            } else
            {
                MessageBox.Show("Please read the information and tick the checkbox to proceed.", "Warning");
            }
        }
    }
}
