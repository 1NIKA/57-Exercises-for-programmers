using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise27_ValidatingInputs
{
    public class ValidationLastname : IValidatorInput
    {
        public bool ValidatorInput(string lastName)
        {
            if (lastName.Length == 0)
            {
                Console.WriteLine("The last name must be filled in.");
                return false;
            }
            else if (lastName.Length <= 2)
            {
                Console.WriteLine($"\"{lastName}\" is not a valid last name. " +
                    $"It is too short.");
                return false;
            }

            return true;
        }
    }
}
