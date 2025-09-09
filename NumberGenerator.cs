using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace FortiPass
{
    public static class NumberGenerator
    {
        public static byte GetRandomNumber(byte range)
        {
            if (range < 26) range = 26;
            byte randomNumber;
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                byte[] rno = new byte[1];
                rng.GetBytes(rno);
                randomNumber = rno[ 0 ];
            }
            return (byte) (randomNumber % range);
        }
    }
}