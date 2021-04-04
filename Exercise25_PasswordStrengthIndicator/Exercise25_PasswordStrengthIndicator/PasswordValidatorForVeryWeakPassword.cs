using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise25_PasswordStrengthIndicator
{
    public class PasswordValidatorForVeryWeakPassword : IPasswordValidator
    {
        public void PasswordValidator(string password)
        {
            if (int.TryParse(password, out int result))
            {
                Console.WriteLine($"The password '{result}' is a very weak password.");
            }
        }
    }
}
