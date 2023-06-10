using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using encryption;
using decryption;

namespace displayInputOutput
{
    class Display
    {
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
    }
}
