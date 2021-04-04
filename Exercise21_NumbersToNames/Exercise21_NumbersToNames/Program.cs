using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise21_NumbersToNames
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the number of the month: ");
            int month = int.Parse(Console.ReadLine());
            bool isFind = false;

            foreach (var item in MonthsNumbersData.numberMonths)
            {
                if (item.Key == month)
                {
                    Console.WriteLine($"The name of the month is {item.Value}.");
                    isFind = true;
                }
            }
            
            if (!isFind)
            {
                Console.WriteLine("error message!");
            }

            Console.ReadKey();
        }
    }
}
