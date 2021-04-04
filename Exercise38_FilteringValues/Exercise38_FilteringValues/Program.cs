using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise38_FilteringValues
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = LinesToIEnumerable("file.txt")
                .Where(x => x % 2 == 0);

            Console.WriteLine($"The even numbers are {string.Join(" ", result)}.");
            Console.ReadKey();
        }

        static IEnumerable<int> LinesToIEnumerable(string path)
        {
            foreach (string line in File.ReadLines(path))
            {
                yield return int.Parse(line);
            }
        }
    }
}