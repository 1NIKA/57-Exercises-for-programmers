using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise27_ValidatingInputs
{
    public class ValidationZipCode : IValidatorInput
    {
        public bool ValidatorInput(string zip)
        {
            if(!int.TryParse(zip, out int zipNumber))
            {
                Console.WriteLine("The ZIP code must be numeric.");
                return false;
            }

            return true;
        }
    }
}
