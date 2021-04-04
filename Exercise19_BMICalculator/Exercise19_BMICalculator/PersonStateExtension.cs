using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise19_BMICalculator
{
    public static class PersonStateExtension
    {
        public static void PersonState(this Person person)
        {
            double bodyMass = BodyMassIndex.BMI(person);

            Console.WriteLine($"Your BMI is {bodyMass}.");
            if (bodyMass >= 18.5 && bodyMass <= 25)
            {
                Console.WriteLine("You are within the ideal weight range.");
            }
            else if (bodyMass < 18.5)
            {
                Console.WriteLine("You are underweight. You should see your doctor.");
            }
            else
            {
                Console.WriteLine("You are overweight. You should see your doctor.");
            }
        }
    }
}
