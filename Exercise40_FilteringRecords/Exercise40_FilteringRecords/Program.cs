using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise40_FilteringRecords
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> lines = File.ReadAllLines("employees.txt");
            var employees = EmployeesDataFromFile.FileDataToList(lines);
            var lowerCaseEmployees = SearchEmployees.ListToLower(employees);
            
            Console.Write("Which one do you want to search (name/date n/d): ");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            if (keyInfo.Key == ConsoleKey.N)
            {
                Console.Write("\nEnter a search string: ");
                string searchString = Console.ReadLine().ToLower();
                PrintQuestions();
                SearchEmployeesWithName.SearchEmployeesByName(
                    employees, (List<Employee>)lowerCaseEmployees, searchString);
            }
            else if (keyInfo.Key == ConsoleKey.D)
            {
                PrintQuestions();
                SearchEmployeesWithDate.SearchEmployeesByDate(employees);
            }
            
            Console.ReadKey();
        }

        static void PrintQuestions()
        {
            Console.WriteLine("\nResults:");
            Console.WriteLine("Name\t\t    | Position\t\t| Separation Date");
            Console.WriteLine("--------------------|-------------------|----------------");
        }
    }
}