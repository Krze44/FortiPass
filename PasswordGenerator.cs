using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FortiPass;

namespace FortiPass
{
    internal class PasswordGenerator
    {
        public static string GeneratePassword(byte length, bool useUpper, bool useNum, bool useSpecial)
        {
            // declare a string of characters to use in the returned string
            string allowedChars = "abcdefghijklmnopqrstuvwxyz";

            // declare the string to be returned/outputted later
            string retString = "";

            // the number of special/upper characters, and numbers, impliment later
            //byte numUpper,numSpecial, numNumbers;

            // Checks to see if user wants, uppercase characters, special characters or numbers
            if (useUpper)
            {
                allowedChars += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            }
            if (useNum)
            {
                allowedChars += "0123456789";
            }
            if (useSpecial)
            {
                allowedChars += @"!@#$%^&*";
            }
            byte n = 0;
            while( length < 8 || length > 255 ) {

                if( n > 200 ) { length = 16; break; }
                length = (byte)( length % 16 );
                n++;
            }

            string allowedCharsCopy = allowedChars;

            for (int i = 0; i < length; i++)
            {
                string letterToAdd = Char.ToString(allowedCharsCopy[NumberGenerator.GetRandomNumber((byte)allowedCharsCopy.Length)]);
                // check how many repeat characters there are for our current letter we will add
                int count = 0;
                foreach( char c in retString ) {
                    if ( Char.ToString(c) == letterToAdd) { count++; }
                }
                // if it repeats too much, we remove it and add a new one
                if (count > 2) {
                    allowedCharsCopy = allowedCharsCopy.Replace(letterToAdd, "");
                    letterToAdd = Char.ToString(allowedCharsCopy[ NumberGenerator.GetRandomNumber((byte)allowedCharsCopy.Length) ]);
                    retString += letterToAdd;
                } else {
                    retString += letterToAdd;
                }
            }
            return retString;
        }
    }
}
