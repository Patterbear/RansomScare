# TedEncrypt File Encryption Tool
A GUI-based file encryption tool written in C# that makes use of the .NET framework. Files in the current directory are 'scrambled' byte by byte according to a generated key, rendering them completely unintelligible. They can only be decrypted if the key is placed into the current directory.


## Download and Use (Standalone .exe file)
The program in its easy 'click-to-run' .exe file can be  downloaded from https://drive.google.com/file/d/1Oa7S22P6VwH9V30_Fko7lx8ihMqtHAF8/.

To install, simply place the file into the directory whose files you wish to encrypt/decrypt.

### Disclaimer
Chrome will sometimes flag the download as suspicious and Microsoft may try and prevent it running.

The program's code is open for anybody to view and it is impossible for the program to modify any files that the user shouldn't/does't want to be modifying.

### Encryption
Run the 'TedEncrypt.exe' file in the directory whose files you wish to encrypt. If it is your first time encrypting in this directory, read the information before proceeding. Press the 'Encrypt' (or 'Proceed') button to encrypt the files.

A 'key' file will be generated and will be used to encrypt the files. Once encryption is complete, move the key file to a secure, separate location.


### Decryption
Move the key file back to the directory whose files you wish to decrypt. Run the 'TedEncrypt.exe' executable and press 'Decrypt'. As long as the correct key file is present, the files will decrypt.
