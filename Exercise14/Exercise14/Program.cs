using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise14_TaxCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            const double Tax = 5.5; 
            Console.Write("What is the order amount? ");
            int amount = int.Parse(Console.ReadLine());
            Console.Write("What is the state? ");
            string state = Console.ReadLine().ToUpper();

            if (state == "WI")
            {
                double tax = amount * Tax / 100;
                double sum = amount + tax;
                Console.WriteLine($"The subtotal is {amount.ToString("C", CultureInfo.GetCultureInfo("en-US"))}.");
                Console.WriteLine($"The tax is {tax.ToString("C", CultureInfo.GetCultureInfo("en-US"))}.");
                Console.WriteLine($"The total is {sum.ToString("C", CultureInfo.GetCultureInfo("en-US"))}.");
            }
            if (state == "MN")
            {
                Console.WriteLine($"The total is {amount.ToString("C", CultureInfo.GetCultureInfo("en-US"))}");
            }

            Console.ReadKey();
        }
    }
}
