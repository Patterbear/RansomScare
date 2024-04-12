using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RansomScare
{
    internal class Cryptography
    {
        public void EncryptFiles()
        {
            GenerateKey();
        }

        private List<string> ScanFiles()
        {
            List <string> files = new List<string>();

            return files;
        }

        private void GenerateKey()
        {
            
            // File size in bytes
            int fileSize = 1024;

            // Random object
            Random random = new Random();

            // List of bytes to target
            List<int> targets = new List<int>();

            for(int i = 0; i < (fileSize / 10); i++)
            {
                int target = random.Next(fileSize);
                targets.Add(target);
            }

            // Shifts amount for target bytes
            List<int> shifts = new List<int>();

            for (int i = 0; i < targets.Count; i++)
            {
                int shift = random.Next(255); // 255 is maximum byte value
                shifts.Add(shift);
            }
        }

        private string RetrieveKey()
        {
            return "";
        }

        private void EncryptFile(string file)
        {

        }
    }
}
