using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercise34_EmployeeListRemoval
{
    static class Program
    {
        static void Main(string[] args)
        {
            string names = "EmployeeNames.txt";
            PrintNamesFromSource.PrintNames(names);

            Console.Write("\nEnter an employee name to remove: ");
            string removeName = Console.ReadLine();

            RemoveNamesAndWriteNewNames.DeleteName(names, removeName);
            Console.WriteLine();
            PrintNamesFromSource.PrintNames(names);

            Console.ReadKey();
        }        
    }
}