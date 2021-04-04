using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise26_MonthsToPayOffACreditCard
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your balance? ");
            double balance = double.Parse(Console.ReadLine());
            Console.Write("What is the APR on the card (as a percent)? ");
            double apr = double.Parse(Console.ReadLine());
            Console.Write("What is the monthly payment you can make? ");
            double montlyPayment = double.Parse(Console.ReadLine());

            CalculateMonthsUnitPaidOff(balance, apr, montlyPayment);

            Console.ReadKey();
        }

        static void CalculateMonthsUnitPaidOff(
            double balance, double apr, double monthlyPayment)
        {
            double i = apr / 100.0 / 365;
            double n = -1.0 / 30.0 * (Math.Log10(1 + balance / monthlyPayment *
                (1 - Math.Pow(1 + i, 30))) / Math.Log10(1 + i));

            Console.WriteLine($"It will take you {Math.Ceiling(n)} months to pay off this card.");
        }
    }
}
