﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decryption
{

    class Decryption
    {
        public static string Decrypt(string cipherText, int shift)
        {
            char[] cipherArray = cipherText.ToLower().ToCharArray();

            for (int i = 0; i < cipherArray.Length; i++)
            {
                char letter = cipherArray[i];
                if (letter != ' ')
                {
                    letter = (char)(letter - shift);
                    if (letter > 'z')
                    {
                        letter = (char)(letter - 26);
                    }
                    else if (letter < 'a')
                    {
                        letter = (char)(letter + 26);
                    }
                    cipherArray[i] = letter;
                }
            }
            return new string(cipherArray);
        }
    }
}
