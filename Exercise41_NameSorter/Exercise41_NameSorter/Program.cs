using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exercise41_NameSorter
{
    class Program
    {
        static void Main(string[] args)
        {
            int countName = UsersNames.NamesCountFromFile("names.txt");
            Console.WriteLine($"Total of {countName} names");
            Console.WriteLine("-----------------");
            UsersNames.PrintSortedNamesFromFile("names.txt");

            Console.ReadKey();
        }
    }
}