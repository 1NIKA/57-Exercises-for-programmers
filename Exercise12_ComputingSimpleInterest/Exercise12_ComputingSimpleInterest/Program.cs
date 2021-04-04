using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12_ComputingSimpleInterest
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter the principal: ");
                    double principal = double.Parse(Console.ReadLine());
                    Console.Write("Enter the rate of interest: ");
                    double rateOfInterest = double.Parse(Console.ReadLine());
                    Console.Write("Enter the number of years: ");
                    int year = int.Parse(Console.ReadLine());

                    double[] investments = CalculateSimpleInterest(principal, rateOfInterest, year);
                    int years = 1;

                    foreach (double investment in investments)
                    {
                        
                        Console.WriteLine($"\nAfter {years++} years at {rateOfInterest}%, " +
                            $"the investment will\nbe worth {investment.ToString("C", new CultureInfo("en-US"))}.\n");
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Pleasy enter valid input!");
                }
            }
             
            Console.ReadKey();
        }

        static double[] CalculateSimpleInterest(double principal, double rateOfInterest, int years)
        {
            double[] investments = new double[years];
            for (int i = 1; i <= years; ++i)
            {
                double investment = principal + ((principal * rateOfInterest / 100) * i);
                investments[i - 1] = investment;
            }

            return investments;
        }
    }
}
