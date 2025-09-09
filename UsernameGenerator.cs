using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FortiPass;

namespace FortiPass
{
    internal class UsernameGenerator
    {
        public static string GenerateUserName( byte length, bool useUpper, bool useNum, bool useSpecial ) {
            return PasswordGenerator.GeneratePassword(length, useUpper, useNum, useSpecial);
        }
    }
}
