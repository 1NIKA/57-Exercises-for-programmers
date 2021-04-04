using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercise40_FilteringRecords
{
    public class EmployeesDataFromFile
    {
        public static List<Employee> FileDataToList(IEnumerable<string> path)
        {
            string[] lines = new string[4];
            List<Employee> employees = new List<Employee>();

            foreach (string line in path)
            {
                lines = line.Split(' ');
                if (lines.Length == 4)
                {
                    employees.Add(new Employee
                    {
                        FirstName = lines[0],
                        LastName = lines[1],
                        Position = lines[2],
                        SeparationDate = DateTime.Parse(lines[3])
                    });
                }
                else
                {
                    employees.Add(new Employee
                    {
                        FirstName = lines[0],
                        LastName = lines[1],
                        Position = lines[2],
                    });
                }
            }

            return employees;
        }
    }
}