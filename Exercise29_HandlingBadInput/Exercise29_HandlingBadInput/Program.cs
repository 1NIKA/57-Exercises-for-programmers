using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise29_HandlingBadInput
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("What is the rate of return? ");
                    int number = int.Parse(Console.ReadLine());
                    int years = 72 / number;
                    Console.WriteLine(
                    $"It will take {years} years to double your initial investment.");
                    break;
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("You cant divide to 0");
                }
                catch 
                {
                    Console.WriteLine("Sorry. That's not a valid input.");
                }
            }

            Console.ReadLine();
        }
    }
}
