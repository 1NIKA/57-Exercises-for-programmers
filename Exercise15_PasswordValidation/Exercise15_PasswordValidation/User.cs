using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise15_PasswordValidation
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public Dictionary<string, string> UserValidation { get; set; }
    }
}
