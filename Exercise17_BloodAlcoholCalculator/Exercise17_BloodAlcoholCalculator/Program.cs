using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise17_BloodAlcoholCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> bacLimits = new Dictionary<string, double>
            {
                { "Georgia", 0.08 }, { "Brazil", 0.07 }, { "Germany", 0.01 },
                { "Scottland", 0.08 }, { "Portugal", 0.02 }, { "Sweden", 0 },
                { "Spain", 0.06 }, { "Norway", 0.06 }, { "Russia", 0.08 }
            };

            double BAC = 0;

            while (true)
            {
                try
                {
                    Console.Write("Your weight: ");
                    double weight = double.Parse(Console.ReadLine());
                    Console.Write("Your gender: (men/women) ");
                    string gender = Console.ReadLine();
                    Console.Write("Number of drinks: ");
                    int numberOfDrinks = int.Parse(Console.ReadLine());
                    Console.Write("The amount of alcohol by volume: ");
                    double amountOfAlcoholByVolume = double.Parse(Console.ReadLine());
                    Console.Write("The amount of time since your last drink: ");
                    double amountOfTimeSinceLastDrink = double.Parse(Console.ReadLine());

                    if (gender == "men")
                    {
                        BAC = ((amountOfAlcoholByVolume * 5.14) / (weight * 0.73)) - 0.15 *
                            amountOfTimeSinceLastDrink;
                    }
                    else if (gender == "women")
                    {
                        BAC = ((amountOfAlcoholByVolume * 5.14) / (weight * 0.66)) - 0.15 *
                            amountOfTimeSinceLastDrink;
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("enter valid input");
                }
            }

            var query = bacLimits
                .Where(x => x.Value > BAC)
                .OrderBy(x => x.Value);

            Console.WriteLine($"Your BAC is {Math.Round(BAC, 2)}");

            if (BAC >= 0.08)
                Console.WriteLine("It is not legal for you to drive.");
            else
            {
                Console.WriteLine("It is legal for you to drive in this countries");
                foreach (var item in query)
                {
                    Console.WriteLine($"country: {item.Key}; BAC: {item.Value}");
                }
            }

            Console.ReadKey();
        }
    }
}
