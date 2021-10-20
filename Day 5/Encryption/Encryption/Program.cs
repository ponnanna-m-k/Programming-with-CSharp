using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using(FileStream fs = new FileStream("D:\\Training\\Files\\test.txt", FileMode.OpenOrCreate))
                {
                    using (Aes aes = Aes.Create())
                    {
                        byte[] key ={0x01, 0x02, 0x03, 0x04, 0x05, 0x06, 0x07, 0x08,
                                     0x09, 0x10, 0x11, 0x12, 0x13, 0x14, 0x15, 0x16};

                        aes.Key = key;
                        byte[] iv = aes.IV;
                        fs.Write(iv, 0, iv.Length); 
                        using (CryptoStream cryptoStream = new CryptoStream(fs, aes.CreateEncryptor(), CryptoStreamMode.Write))
                        {
                            using (StreamWriter encryptWriter = new StreamWriter(cryptoStream))
                            {
                                encryptWriter.WriteLine("Hello World!");
                            }
                        }
                    }
                }
                Console.WriteLine("The file was encrypted.");
                Console.ReadKey();
            }



            catch (Exception Ex)
            {
                Console.WriteLine($"The Encryption Failed. {Ex}");
            }
        }
    }
}