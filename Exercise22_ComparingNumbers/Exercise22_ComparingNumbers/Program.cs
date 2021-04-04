using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise22_ComparingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many numbers do you want to compare: ");
            int count = int.Parse(Console.ReadLine());
            int number;

            HashSet<int> numbers = new HashSet<int>();

            for (int i = 0; i < count; i++)
            {
                Console.Write("Enter the number: ");
                number = int.Parse(Console.ReadLine());
                numbers.Add(number);
            }

            Console.WriteLine(numbers.LargestNumber());
            Console.ReadKey();
        }
    }
}
