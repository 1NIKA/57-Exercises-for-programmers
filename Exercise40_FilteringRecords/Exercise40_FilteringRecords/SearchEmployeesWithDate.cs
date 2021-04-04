using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise40_FilteringRecords
{
    public class SearchEmployeesWithDate
    {
        public static void SearchEmployeesByDate(List<Employee> employees)
        {
            string name;

            foreach (var employee in employees
                    .Where(x => x.SeparationDate < DateTime.Now.AddMonths(-6)))
            {
                    name = employee.FirstName + " " + employee.LastName;
                    Console.WriteLine(
                        string.Format("{0, -19} | {1, -17} | {2:yyyy-MM-dd}",
                        name, employee.Position, employee.SeparationDate));
            }
        }
    }
}