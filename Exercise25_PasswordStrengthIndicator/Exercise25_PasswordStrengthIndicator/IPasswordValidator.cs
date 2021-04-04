using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise25_PasswordStrengthIndicator
{
    public interface IPasswordValidator
    {
        void PasswordValidator(string password);
    }
}
