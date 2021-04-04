using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise25_PasswordStrengthIndicator
{
    class PasswordValidatorForStrongPassword : IPasswordValidator
    {
        public void PasswordValidator(string password) //abc123xyz
        {
            char[] array = password.ToCharArray();
            int countForStrings = 0;
            int countForNums = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if ((int)array[i] >= 65 && (int)array[i] <= 90 || (int)array[i] >= 97 && (int)array[i] <= 122)
                {
                    countForStrings++;
                }
                
                if ((int)array[i] >= 48 && (int)array[i] <= 57)
                {
                    countForNums++;
                }
            }

            if (countForNums > 0 && (countForNums + countForStrings) >= 8)
            {
                Console.WriteLine($"The password '{password}' is a strong password.");
            }
        }
    }
}
