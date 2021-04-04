using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2_CountingtheNumberofCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is the input string? ");
            string name = Console.ReadLine();
            int count = name.Length;

            if (name == "")
                Console.WriteLine("Pleasy enter something");
            else
                Console.WriteLine($"{name} has {count} characters.");

            Console.ReadKey();
        }
    }
}
