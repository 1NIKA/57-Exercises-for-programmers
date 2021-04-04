using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise27_ValidatingInputs
{
    public class ValidationEmployeeId : IValidatorInput
    {
        public bool ValidatorInput(string employeeId)
        {
            if (employeeId.Length != 7)
            {
                Console.WriteLine($"{employeeId} is not a valid ID.");
                return false;
            }
            for (int i = 0; i < 2; i++)
            {
                if (!(employeeId[i] >= 65 && employeeId[i] <= 90))
                {
                    Console.WriteLine($"{employeeId} is not a valid ID.");
                    return false;
                }
            }
            if (employeeId[2] != '-')
            {
                Console.WriteLine($"{employeeId} is not a valid ID.");
                return false;
            }
            for (int i = 3; i < 6; i++)
            {
                if (!(employeeId[i] >= 49 && employeeId[i] <= 57))
                {
                    Console.WriteLine($"{employeeId} is not a valid ID.");
                    return false;
                }
            }

            return true; 
        }
    }
}