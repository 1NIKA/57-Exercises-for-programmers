using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise40_FilteringRecords
{
    public interface ISearchEmployeesFromData
    {
        void SearchEmployees(List<Employee> employees, 
            List<Employee> lowerCaseEmployees, string searchString);
    }
}
