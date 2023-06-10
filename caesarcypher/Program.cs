using System.Collections.Concurrent;
using decryption;
using encryption;
using displayInputOutput;

namespace caesarcypher
{
    class Program
    {
        static void Main(string[] args)
        {
            string plainText = "Attack at the night to bitches";
            string cipherText = "dwwdfn dw wkh qljkw wr elwfkhv";
            int uniNumber = 3;

            Display.DisplayEncrypted(plainText, uniNumber);
            Display.DisplayDecrypted(cipherText, uniNumber);

        }
    }
}