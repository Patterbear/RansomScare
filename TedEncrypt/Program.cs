using System;
using System.IO;
using System.Windows.Forms;

namespace TedEncrypt
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            CheckTedEncryptStatus();
            
        }

        // Check TedEncrypt status
        // check to see if folder has been previously encrypted or if new key is needed
        // uses hidden .tedencrypt file
        static void CheckTedEncryptStatus()
        {
            string statusFile = Directory.GetCurrentDirectory() + "/.tedencrypt";

            if (File.Exists(statusFile))
            {
                // Files are encrypted
                if (File.ReadAllText(statusFile).Equals("e"))
                {
                    Application.Run(new EncryptedScreen());
                }
                // Files are decrypted
                else if (File.ReadAllText(statusFile).Equals("d"))
                {
                    Application.Run(new DecryptedScreen());
                } else // file exists but is invalid
                {
                    Application.Run(new SplashScreen());
                }
            } else // file does not exist
            {
                Application.Run(new SplashScreen());
            }
            
        }
    }
}
