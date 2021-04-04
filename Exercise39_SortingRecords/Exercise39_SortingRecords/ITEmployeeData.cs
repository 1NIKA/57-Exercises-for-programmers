using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise39_SortingRecords
{
    static class ITEmployeeData
    {
        public static void AddEmployeeData()
        {
            var context = new EmployeeInfoEntities1();

            var employees = new List<ITEmployee>
            {
                new ITEmployee()
                {
                    FirstName = "John", LastName = "Johnson", Position = "Manager", SeperationDate = new DateTime(2016, 12, 31)
                },
                new ITEmployee()
                {
                    FirstName = "Tou", LastName = "Xiong", Position = "Software Engineer", SeperationDate = new DateTime(2016, 10, 5)
                },
                new ITEmployee()
                {
                    FirstName = "Michaela", LastName = "Michaelson", Position = "District Manager", SeperationDate = new DateTime(2015, 12, 19)
                },
                new ITEmployee()
                {
                    FirstName = "Jake", LastName = "Jacobson", Position = "Programmer"
                },
                new ITEmployee()
                {
                    FirstName = "Jacquelyn", LastName = "Jackson", Position = "DBA"
                },
                new ITEmployee()
                {
                    FirstName = "Sally", LastName = "Weber", Position = "Web Developer", SeperationDate = new DateTime(2015, 12, 18)
                }
            };

            context.ITEmployee.AddRange(employees);
            context.SaveChanges();
        }
    }
}
