using System;
using System.Collections.Generic;
using System.IO;

namespace TedEncrypt
{
    internal class Cryptography
    {
        public void EncryptFiles()
        {

            // Get list of suitable files in directory
            List<string> files = ScanFiles();

            // Get largest file size in bytes so key is only as long as needed
            int largestFileBytes = GetLargestFileBytes(files);

            // Generate and save key
            GenerateKey(largestFileBytes);

            // Retrieve saved key
            string key = RetrieveKey();
            
            // Encrypt files
            for(int i  = 0; i < files.Count; i++)
            {
                EncryptFile(files[i], key);
            }

            // Set hidden .tedencrypt file to 'e' to indicate directory files are encrypted
            string tedEncryptFile = Directory.GetCurrentDirectory() + "/.tedencrypt";
            File.SetAttributes(tedEncryptFile, FileAttributes.Normal);
            File.WriteAllText(tedEncryptFile, "e");
            File.SetAttributes(tedEncryptFile, FileAttributes.Hidden);
        }

        public void DecryptFiles()
        {
            // Get list of files in directory
            List<string> files = ScanFiles();

            // Retrieve saved key
            string key = RetrieveKey();

            // Decrypt files
            for (int i = 0; i < files.Count; i++)
            {
                DecryptFile(files[i], key);
            }

            // Set hidden .tedencrypt file to 'd' to indicate directory files are decrypted
            string tedEncryptFile = Directory.GetCurrentDirectory() + "/.tedencrypt";
            File.SetAttributes(tedEncryptFile, FileAttributes.Normal);
            File.WriteAllText(tedEncryptFile, "d");
            File.SetAttributes(tedEncryptFile, FileAttributes.Hidden);
        }


        // Directory file scan function
        // returns list of all files in the directory, excluding TedEncrypt's own
        private List<string> ScanFiles()
        {

            string directory = Directory.GetCurrentDirectory();

            // Get file names
            List <string> files = new List<string>(Directory.GetFiles(directory));

            // Remove 'key' and executable to prevent encrypting them
            files.Remove(directory + "\\key");
            files.Remove(directory + "\\TedEncrypt.exe");
            files.Remove(directory + "\\.tedencrypt");

            // Exclude .pdb and .exe.config for debug
            files.Remove(directory + "\\TedEncrypt.exe.config");
            files.Remove(directory + "\\TedEncrypt.pdb");

            return files;
        }


        // Get largest file's bytes function
        // returns the size in bytes of the largest file in the directory
        // used to determine length of the key
        private int GetLargestFileBytes(List<string> files)
        {
            int bytes = 0;

            for(int i = 0;i < files.Count;i++)
            {
                int fileSize = (int) new FileInfo(files[i]).Length;
                if (fileSize > bytes)
                {
                    bytes = fileSize;
                }
            }

            return bytes;
        }


        // Generates and saves key
        // the key is comprised of integers known as shifts
        // shifts are numbers to be added to each byte to corrupt the file
        private void GenerateKey(int largestFileBytes)
        {
            // Random object for shift amount generation
            Random random = new Random();

            // Format key
            string key = "";

            for (int i = 0;i < largestFileBytes;i++)
            {
                key += random.Next(255).ToString() + "-";
            }

            // Remove final '-'
            key = key.Substring(0, key.Length - 1);

            // Save key to file
            File.WriteAllText(Directory.GetCurrentDirectory() + "/key", key);

        }


        // Key retrieval function
        private string RetrieveKey()
        {
            return File.ReadAllText(Directory.GetCurrentDirectory() + "/key");
        }


        // Encrypt file function
        // encrypts an individual file
        private void EncryptFile(string file, string key)
        {

            // Get list of targets and their shift values
            string[] keys = key.Split('-');

            // Creates byte array from file
            byte[] fileBytes = File.ReadAllBytes(file);

            // Change target bytes
            for(int i = 0; i < fileBytes.Length; i++)
            {

                byte[] shift = BitConverter.GetBytes(Int32.Parse(keys[i]));

                // shift value is always in the first byte, this ensures the byte at index 0 will be used
                if (!BitConverter.IsLittleEndian) { Array.Reverse(shift); }

                fileBytes[i] = (byte) (fileBytes[i] + shift[0]);
            }

            // Save file
            File.WriteAllBytes(file, fileBytes);
        }

        // Decrypt file function
        // decrypts single file with key
        private void DecryptFile(string file, string key)
        {
            // Get list of targets and their shift values
            string[] keys = key.Split('-');

            // Creates byte array from file
            byte[] fileBytes = File.ReadAllBytes(file);

            // Change target bytes
            for (int i = 0; i < fileBytes.Length; i++)
            {

                byte[] shift = BitConverter.GetBytes(Int32.Parse(keys[i]));

                // shift value is always in the first byte, this ensures the byte at index 0 will be used
                if (!BitConverter.IsLittleEndian) { Array.Reverse(shift); }

                fileBytes[i] = (byte)(fileBytes[i] - shift[0]);
            }

            // Save file
            File.WriteAllBytes(file, fileBytes);
        }
    }
}
