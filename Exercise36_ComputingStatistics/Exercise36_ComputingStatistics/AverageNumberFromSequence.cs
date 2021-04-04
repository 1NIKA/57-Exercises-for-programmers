using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise36_ComputingStatistics
{
    public static class AverageNumberFromSequence
    {
        public static double Average(this List<int> source)
        {
            double average = source.Sum() / source.Count;
            
            return average;
        }
    }
}
