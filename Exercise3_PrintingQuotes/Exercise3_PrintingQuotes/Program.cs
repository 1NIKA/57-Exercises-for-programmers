using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_PrintingQuotes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is the quote? ");
            string words = Console.ReadLine();
            Console.Write("Who said it? ");
            string name = Console.ReadLine();

            Console.WriteLine(name + " says, " + '"' + words + '"');
            Console.ReadKey();
        }
    }
}
