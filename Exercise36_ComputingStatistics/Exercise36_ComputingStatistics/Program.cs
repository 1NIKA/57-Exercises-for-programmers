using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise36_ComputingStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            PrintQuestion.PrintQuestionWhileDone(numbers);
            SaveNumbersToSequence.SaveNumbers(numbers);
            
            ShowSourceNumber.ShowItems(numbers);
            Console.WriteLine();
            Console.WriteLine($"The average is {numbers.Average()}.");
            Console.WriteLine($"The minimum is {numbers.MinFromSource()}.");
            Console.WriteLine($"The maximum is {numbers.MaxFromSource()}.");
            Console.WriteLine($"The standard deviation is {numbers.StandardDeviation()}.");

            Console.ReadKey();
        }
    }
}