using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise13_DeterminingCompoundInterest
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("What is the principal amount? ");
                    double principalAmount = double.Parse(Console.ReadLine());
                    Console.Write("What is the rate? ");
                    double rate = double.Parse(Console.ReadLine());
                    Console.Write("What is the number of years? ");
                    int numberOfYears = int.Parse(Console.ReadLine());
                    Console.Write("What is the number of times the interest\n" +
                        "is compounded per years? ");
                    int interestPerYears = int.Parse(Console.ReadLine());

                    double investment = principalAmount * Math.Pow(1 + rate / (100 * interestPerYears), numberOfYears * interestPerYears);

                    Console.WriteLine($"${principalAmount} invested at {rate}% for " +
                        $"{numberOfYears} years\ncompounded {interestPerYears} times per " +
                        $"years is ${Math.Round(investment, 2)}.");
                    break;
                }
                catch
                {
                    Console.WriteLine("Pleasy enter valid inputs!");
                }
            }

            Console.ReadKey();
        }
    }
}
