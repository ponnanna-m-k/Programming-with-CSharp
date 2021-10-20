using System;
using System.Security.Cryptography;
using System.IO;
namespace Decryption
{
    class Program
    {




        static void Main(string[] args)
        {
            try
            {
                using (FileStream fileStream = new("D:\\Training\\Files\\test.txt", FileMode.Open))
                {
                    using (Aes aes = Aes.Create())
                    {
                        byte[] iv = new byte[aes.IV.Length];
                        int numBytesToRead = aes.IV.Length;
                        int numBytesRead = 0;
                        while (numBytesToRead > 0)
                        {
                            int n = fileStream.Read(iv, numBytesRead, numBytesToRead);
                            if (n == 0) break;





                            numBytesRead += n;
                            numBytesToRead -= n;
                        }





                        byte[] key =
                        {
                                    0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08,
                                    0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16
                                    };


                        using (CryptoStream cryptoStream = new(
                        fileStream,
                        aes.CreateDecryptor(key, iv),
                        CryptoStreamMode.Read))
                        {
                            using (StreamReader decryptReader = new(cryptoStream))
                            {
                                string decryptedMessage = decryptReader.ReadToEnd();
                                Console.WriteLine($"The decrypted original message: {decryptedMessage}");
                            }
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                Console.WriteLine($"The Decrption failed. {Ex}");
            }
        }
    }
}