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
            GenerateKey();
        }

        private List<string> ScanFiles()
        {
            List <string> files = new List<string>();

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
            return "";
        }

        private void EncryptFile(string file)
        {

        }

        // List printing function for debug
        private void printList(List<int> list) {
            string output = "[";
            for (int i = 0; i < list.Count; i++)
            {
                output += list[i].ToString() + ", ";
            }

            // Remove final ', ' and add closing square bracket
            output = output.Substring(0, output.Length - 2) + "]";

            Console.WriteLine(output);
        }
    }
}
