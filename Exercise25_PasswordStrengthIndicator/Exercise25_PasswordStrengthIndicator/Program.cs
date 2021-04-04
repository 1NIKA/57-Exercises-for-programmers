using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise25_PasswordStrengthIndicator
{
    class Program
    {
        static void Main(string[] args)
        {
            PasswordValidatorForVeryWeakPassword veryWeakPassword = new PasswordValidatorForVeryWeakPassword();
            PasswordValidatorForWeakPassword weakPassword = new PasswordValidatorForWeakPassword();
            PasswordValidatorForStrongPassword strongPassword = new PasswordValidatorForStrongPassword();
            PasswordValidatorForVeryStrongPassword veryStrongPassword = new PasswordValidatorForVeryStrongPassword();
            
            veryWeakPassword.PasswordValidator("123456");
            weakPassword.PasswordValidator("abcdef");
            strongPassword.PasswordValidator("abc123xyz");
            veryStrongPassword.PasswordValidator("1337h@xor!");

            Console.ReadKey();
        }
    }
}
