using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise27_ValidatingInputs
{
    class Program
    {
        static void Main(string[] args)
        {
            ValidationFirstname firstname = new ValidationFirstname();
            ValidationLastname lastname = new ValidationLastname();
            ValidationZipCode zip = new ValidationZipCode();
            ValidationEmployeeId id = new ValidationEmployeeId();

            Console.Write("Enter the first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter the last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter the zip code: ");
            string zipCode = Console.ReadLine();
            Console.Write("Enter the employee ID: ");
            string employeeId = Console.ReadLine();

            bool validateFirstname = firstname.ValidatorInput(firstName);
            bool validateLastname = lastname.ValidatorInput(lastName);
            bool validateZipcode = zip.ValidatorInput(zipCode);
            bool validateEmployeeId = id.ValidatorInput(employeeId);

            while (!validateFirstname || !validateLastname || !validateZipcode || !validateEmployeeId)
            {
                Console.Write("Enter the first name: ");
                firstName = Console.ReadLine();
                Console.Write("Enter the last name: ");
                lastName = Console.ReadLine();
                Console.Write("Enter the zip code: ");
                zipCode = Console.ReadLine();
                Console.Write("Enter the employee ID: ");
                employeeId = Console.ReadLine();

                validateFirstname = firstname.ValidatorInput(firstName);
                validateLastname = lastname.ValidatorInput(lastName);
                validateZipcode = zip.ValidatorInput(zipCode);
                validateEmployeeId = id.ValidatorInput(employeeId);
            }

            if (validateFirstname && validateLastname && validateZipcode && validateEmployeeId)
            {
                Console.WriteLine("There were no errors found.");
            }  
            
            Console.ReadKey();
        }
    }
}
