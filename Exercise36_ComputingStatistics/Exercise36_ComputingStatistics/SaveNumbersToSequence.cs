using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise36_ComputingStatistics
{
    public class SaveNumbersToSequence
    {
        public static List<int> SaveNumbers(IEnumerable<int> source)
        {
            List<int> numbers = new List<int>();

            foreach (var item in source)
            {
                numbers.Add(item);
            }

            return numbers;
        }
    }
}
