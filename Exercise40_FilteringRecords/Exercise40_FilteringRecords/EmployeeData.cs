using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise40_FilteringRecords
{
    public class EmployeeData
    {
        public static List<Employee> employees = new List<Employee>
        {
            new Employee
            {
                FirstName = "John",
                LastName = "Johnson",
                Position = "Manager",
                SeparationDate = new DateTime(2016, 12, 31)
            },
            new Employee
            {
                FirstName = "Tou",
                LastName = "Xiong",
                Position = "Software Engineer",
                SeparationDate = new DateTime(2016, 10, 5)
            },
            new Employee
            {
                FirstName = "Michaela",
                LastName = "Michaelson",
                Position = "District Manager",
                SeparationDate = new DateTime(2015, 12, 19)
            },
            new Employee
            {
                FirstName = "Jake",
                LastName = "Jacobson",
                Position = "Programmer",
            },
            new Employee
            {
                FirstName = "Jacquelyn",
                LastName = "Jackson",
                Position = "DBA",
            },
            new Employee
            {
                FirstName = "Sally",
                LastName = "Weber",
                Position = "Web Developer",
                SeparationDate = new DateTime(2015, 12, 18)
            }
        };
    }
}