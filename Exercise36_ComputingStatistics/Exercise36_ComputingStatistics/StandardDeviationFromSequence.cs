using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise36_ComputingStatistics
{
    public static class StandardDeviationFromSequence
    {
        public static double StandardDeviation(this List<int> source)
        {
            List<double> squaredValues = new List<double>();

            foreach (var item in source)
            {
                squaredValues.Add(Math.Pow((item - source.Average()), 2));
            }

            double standardDeviation = Math.Sqrt(squaredValues.Average());

            return Math.Round(standardDeviation, 2);
        }
    }
}