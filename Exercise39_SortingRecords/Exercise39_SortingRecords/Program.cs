using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise39_SortingRecords
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new EmployeeInfoEntities1();
            //ITEmployeeData.AddEmployeeData();

            Console.WriteLine("Name\t\t    | Position\t\t| Separation Date");
            Console.WriteLine("--------------------|-------------------|----------------");

            string name;
            foreach (var employee in context.ITEmployee
                .OrderBy(e => e.LastName))
            {
                name = employee.FirstName + " " + employee.LastName;
                Console.WriteLine(
                    string.Format("{0, -19} | {1, -17} | {2:yyyy-MM-dd}",
                    name, employee.Position, employee.SeperationDate));
            }

            Console.ReadKey();
        }
    }
}