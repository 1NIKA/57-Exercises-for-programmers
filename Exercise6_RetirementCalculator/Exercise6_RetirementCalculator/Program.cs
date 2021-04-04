using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6_RetirementCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your current age? ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("At what age would you like to retire? ");
            int retire = int.Parse(Console.ReadLine());

            Console.WriteLine($"You have {retire - age} years left until you can retire.");
            Console.WriteLine($"It's {DateTime.Now.Year}," +
                $" so you can retire in {DateTime.Now.Year + (retire - age)}.");

            Console.ReadKey();
        }
    }
}
