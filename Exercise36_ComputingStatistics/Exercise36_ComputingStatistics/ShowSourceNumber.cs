using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise36_ComputingStatistics
{
    public class ShowSourceNumber
    {
        public static void ShowItems(IEnumerable<int> source)
        {
            Console.Write($"Numbers: {string.Join(", ", source)}");
        }
    }
}
