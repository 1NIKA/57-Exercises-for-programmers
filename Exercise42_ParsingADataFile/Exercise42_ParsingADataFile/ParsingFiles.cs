using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercise42_ParsingADataFile
{
    public class ParsingFilesData
    {
        public static List<Employee> EmployeeInfo(string path) 
        {
            var reader = new StreamReader(path);
            List<Employee> employees = new List<Employee>();

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                employees.Add(new Employee
                {
                    LastName = values[0],
                    FirstName = values[1],
                    Salary = int.Parse(values[2])
                });
            }

            return employees;
        }
    }
}