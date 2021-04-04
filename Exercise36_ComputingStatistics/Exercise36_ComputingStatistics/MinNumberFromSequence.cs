using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise36_ComputingStatistics
{
    public static class MinNumberFromSequence
    {
        public static int MinFromSource(this List<int> source)
        {
            return source.Min();
        }
    }
}
