using System.Collections.Concurrent;
using System.IO;
using encryption;
using decryption;
using displayInputOutput;
using System.Globalization;

namespace caesarcypher
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileDirectory = @"C:\Users\LEGION Y520\Desktop\EncDecr\rncdec.txt";
            string plainText = "Why Are You Geh";
            int uniNumber = 3;

 
            Display.DisplayEncryptDoc(plainText, uniNumber,fileDirectory);

            Display.DisplayDecryption(plainText, uniNumber, fileDirectory);
        }
    }
}