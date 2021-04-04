using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Exercise40_FilteringRecords
{
    public class SearchEmployeesFromFileWithName
    {
        public static void SearchEmployeesFromFileByName(List<Employee> employees, 
            List<Employee> lowerCaseEmployees, string searchString)
        {
            string name;

            foreach (var employee in lowerCaseEmployees
                .Where(e => e.FirstName.Contains(searchString) ||
                e.LastName.Contains(searchString) ||
                e.Position.Contains(searchString))
                .OrderBy(e => e.FirstName))
            {
                foreach (var item in employees)
                {
                    if (employee.FirstName == item.FirstName.ToLower() &&
                        employee.LastName == item.LastName.ToLower() &&
                        employee.Position == item.Position.ToLower())
                    {
                        name = item.FirstName + " " + item.LastName;
                        Console.WriteLine(
                            string.Format("{0, -19} | {1, -17} | {2:yyyy-MM-dd}",
                            name, item.Position, item.SeparationDate));
                    }
                }
            }
        }
    }
}