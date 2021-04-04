using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise42_ParsingADataFile
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintItems();
            List<Employee> employees = ParsingFilesData.EmployeeInfo("employees.txt");

            PrintEmployeeInfo(employees);
            
            Console.ReadKey();
        }

        static void PrintItems()
        {
            Console.WriteLine("Last\t  First\t    Salary");
            Console.WriteLine("------------------------------");
        }

        static void PrintEmployeeInfo(List<Employee> employees)
        {
            foreach (var employee in employees
                .OrderByDescending(s => s.Salary))
            {
                Console.WriteLine(
                    string.Format("{0, -9} {1, -9} {2}",
                    employee.LastName, employee.FirstName, employee.Salary.ToString(
                        "C", CultureInfo.GetCultureInfo("en-US"))));
            }
        }
    }
}