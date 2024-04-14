using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
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

        static void CheckTedEncryptStatus()
        {
            string statusFile = Directory.GetCurrentDirectory() + "/.tedencrypt";

            if (File.Exists(statusFile))
            {
                if (File.ReadAllText(statusFile).Equals("e"))
                {
                    Application.Run(new EncryptedScreen());
                }
                else if (File.ReadAllText(statusFile).Equals("d"))
                {
                    Application.Run(new DecryptedScreen());
                } else
                {
                    Application.Run(new SplashScreen());
                }
            } else
            {
                Application.Run(new SplashScreen());
            }
            
        }
    }
}
