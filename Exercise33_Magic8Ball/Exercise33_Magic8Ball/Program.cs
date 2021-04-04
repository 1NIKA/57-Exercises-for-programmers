using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise33_Magic8Ball
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What's your question? ");
            string question = Console.ReadLine();

            Random rand = new Random();
            int random = rand.Next(0, 4);

            string[] source = { "Yes", "No", "Maybe", "Ask again later." };

            Console.WriteLine(source[random]);
            Console.ReadKey();
        }
    }
}
