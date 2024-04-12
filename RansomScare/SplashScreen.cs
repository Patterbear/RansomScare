using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RansomScare
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {

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
                Console.WriteLine("Proceed");
                // Proceed to next window
            } else
            {
                MessageBox.Show("Please read the information and tick the checkbox to proceed.", "Warning");
            }
        }
    }
}
