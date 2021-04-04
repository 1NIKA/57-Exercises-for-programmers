using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise40_FilteringRecords
{
    public class SearchEmployees
    {
        public static IEnumerable<Employee> ListToLower(List<Employee> employees)
        {
            List<Employee> lowerCaseEmployees = new List<Employee>();

            foreach (var employee in employees)
            {
                lowerCaseEmployees.Add(
                    new Employee()
                    {
                        FirstName = employee.FirstName.ToLower(),
                        LastName = employee.LastName.ToLower(),
                        Position = employee.Position.ToLower(),
                        SeparationDate = employee.SeparationDate
                    });
            }

            return lowerCaseEmployees;
        }
    }
}