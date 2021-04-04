using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise19_BMICalculator
{
    public class BodyMassIndex
    {
        public static double BMI(Person person)
        {
            double bmi = (person.Weight / (person.Height * person.Height)) * 703;

            return Math.Round(bmi, 1);
        }
    }
}
