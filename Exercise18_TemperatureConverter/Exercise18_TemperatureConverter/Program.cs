using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise18_TemperatureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    double temperature = 0;
                    Console.WriteLine("Press F to convert from Celsius to Fahrenheit.");
                    Console.WriteLine("Press KF to convert from Kelvin to Fahrenheit.");
                    Console.WriteLine("Press C to convert from Fahrenheit to Celsius.");
                    Console.WriteLine("Press CK to convert from Celsius to Kelvin.");
                    Console.WriteLine("Press KC to convert from Kelvin to Celsius.");
                    Console.WriteLine("Press K to convert from Fahrenheit to Kelvin.");     
                    Console.Write("Your choise: ");
                    string userChoice = Console.ReadLine().ToUpper();

                    if (userChoice == "F")
                    {
                        Console.Write("\nPlease enter the temperature in Celsius: ");
                        double celsius = double.Parse(Console.ReadLine());
                        temperature = (celsius * 9 / 5) + 32;
                        Console.WriteLine($"The temperature in Fahrenheit is {temperature}.");
                    }
                    else if (userChoice == "KF")
                    {
                        Console.Write("\nPlease enter the temperature in Kelvin: ");
                        double kelvin = double.Parse(Console.ReadLine());
                        temperature = 9 / 5 * (kelvin - 273) + 32;
                        Console.WriteLine($"The temperature in Fahrenheit is {temperature}.");
                    }
                    else if (userChoice == "C")
                    {
                        Console.Write("\nPlease enter the temperature in Fahrenheit: ");
                        double fahrenheit = double.Parse(Console.ReadLine());
                        temperature = (fahrenheit - 32) * 5 / 9;
                        Console.WriteLine($"The temperature in Celsius is {temperature}.");
                    }
                    else if (userChoice == "CK")
                    {
                        Console.Write("\nPlease enter the temperature in Celsius: ");
                        double celsius = double.Parse(Console.ReadLine());
                        temperature = celsius + 273;
                        Console.WriteLine($"The temperature in Kelvin is {temperature}.");
                    }
                    else if (userChoice == "KC")
                    {
                        Console.Write("\nPlease enter the temperature in Kelvin: ");
                        double kelvin = double.Parse(Console.ReadLine());
                        temperature = kelvin - 273;
                        Console.WriteLine($"The temperature in Celsius is {temperature}.");
                    }
                    else if (userChoice == "K")
                    {
                        Console.Write("\nPlease enter the temperature in Fahrenheit: ");
                        double fahrenheit = double.Parse(Console.ReadLine());
                        temperature = 5 / 9 * (fahrenheit - 32) + 273;
                        Console.WriteLine($"The temperature in Kelvin is {temperature}.");
                    }
                    else
                    {
                        Console.WriteLine("This Temperature is not valid");
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Please enter only numeric value!");
                }
            }

            Console.ReadKey();
        }
    }
}
