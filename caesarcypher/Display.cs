using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using encryption;
using decryption;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace displayInputOutput
{
    class Display
    {
        #region Display From Console
        public static void DisplayEncrypted(string plaintxt, int shift)
        {
            Console.WriteLine("| Encryption |\n------------------------\nPlain Text: ");
            foreach (var item in plaintxt)
            {
                Console.Write(item);
            }
            Console.WriteLine("\n------------------------\nCipher Text: ");

            string encryptedText = Encryption.Encrypt(plaintxt, shift);
            Console.WriteLine(encryptedText);
            Console.WriteLine("------------------------\n| Encryption Is Done. |\n");
        }


        public static void DisplayDecrypted(string cipherText, int shift)
        {
            Console.WriteLine("| Decryption |\n------------------------\nPlain Text: ");
            foreach (var item in cipherText)
            {
                Console.Write(item);
            }
            Console.WriteLine("\n------------------------\nCipher Text: ");
            var decryptedText = Decryption.Decrypt(cipherText, shift);
            Console.WriteLine(decryptedText);
            Console.WriteLine("------------------------\n| Decryption Is Done. |");
        }
        #endregion
        public static void DisplayEncryptDoc(string text, int num, string directory)
        {
            string encryptedText = Encryption.Encrypt(text, num);
            using (StreamWriter sw = new StreamWriter(directory))
            {
                sw.WriteLine(encryptedText);
            }

            Console.WriteLine($"Input Text:\n{text}");
            Console.WriteLine("-------------------------------");
            Console.WriteLine();
            using (StreamReader sr = new StreamReader(directory))
            {
                Console.WriteLine($"Encrypted Text:\n{sr.ReadToEnd()}" +
                    "-------------------------------\n");
            }
            Console.WriteLine();
        }
        
        public static void DisplayDecryption(string cipherText, int num, string directory)
        {
            StreamReader sr = new StreamReader(directory);
            string decryptRead = sr.ReadLine();
            string encrypted = Encryption.Encrypt(cipherText, num);
            Console.WriteLine($"Encrypted Text From Document:\n{encrypted}");
            Console.WriteLine("-------------------------------");
            string decryptedText = Decryption.Decrypt(decryptRead, num);
            Console.WriteLine();
            Console.WriteLine($"Decrypted Info:\n{decryptedText}");
            Console.WriteLine("-------------------------------");
        }
    }
}