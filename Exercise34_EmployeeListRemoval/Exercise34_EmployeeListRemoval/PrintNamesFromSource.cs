using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise34_EmployeeListRemoval
{
    public class PrintNamesFromSource
    {
        public static void PrintNames(string path)
        {
            string[] lines = File.ReadAllLines(path);

            Console.WriteLine($"There are {lines.Length} employees:");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}