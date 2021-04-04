using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise36_ComputingStatistics
{
    public class PrintQuestion
    {
        public static void PrintQuestionWhileDone(List<int> source)
        {
            string text;
            
            do
            {
                Console.Write("Enter a number: ");
                text = Console.ReadLine();

                if (text == "done")
                {
                    break;
                }
                else if (!int.TryParse(text, out int num))
                {
                    Console.WriteLine("Please enter numeric values");
                }
                else
                {
                    source.Add(num);
                }

            } while (text != "done");

            SaveNumbersToSequence.SaveNumbers(source);
        }
    }
}