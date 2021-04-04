using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise46_WordFrequencyFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            var words = FileParser.CountWordsInFile("words.txt");

            foreach (var word in words
                .OrderByDescending(w => w.Value))
            {
                Console.WriteLine(string.Format(
                    "{0, 8}:  {1}", word.Key, new string('*', word.Value)));
            }

            Console.ReadKey();
        }
    }
}