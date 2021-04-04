using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise19_BMICalculator
{
    static class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            while (true)
            {
                try
                {
                    Console.Write("Enter your height in inches: ");
                    person.Height = double.Parse(Console.ReadLine());
                    Console.Write("Enter your weight in pounds: ");
                    person.Weight = double.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Please enter valid input");
                }
            }

            person.PersonState();

            Console.ReadKey();
        }
    }
}