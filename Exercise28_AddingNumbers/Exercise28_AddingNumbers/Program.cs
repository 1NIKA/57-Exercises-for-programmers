using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise28_AddingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many numbers do you want to add? ");
            int numbers = int.Parse(Console.ReadLine());

            Add(numbers);

            Console.ReadKey();
        }

        static void Add(int number)
        {
            int sum = 0;
            for (int i = 1; i <= number; i++)
            {
                Console.Write("Enter a number: ");
                int.TryParse(Console.ReadLine(), out int numbers);
                sum += numbers;
            }

            Console.WriteLine($"The total is {sum}."); ;
        }
    }
}
