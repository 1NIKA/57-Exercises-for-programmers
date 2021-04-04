using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise25_PasswordStrengthIndicator
{
    public class PasswordValidatorForWeakPassword : IPasswordValidator
    {
        public void PasswordValidator(string password)
        {
            char[] array = password.ToCharArray();
            int count = 0; 

            for (int i = 0; i < array.Length; i++)
            {
                if ((int)array[i] >= 65 && (int)array[i] <= 90 || (int)array[i] >= 97 && (int)array[i] <= 122)
                {
                    count++;
                    if (count == password.Length)
                    {
                        Console.WriteLine($"The password '{password}' is a weak password.");
                    }
                }
            }
        }
    }
}
