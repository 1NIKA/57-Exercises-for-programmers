using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise41_NameSorter
{
    public class UsersNames
    {
        public static void PrintSortedNamesFromFile(string path)
        {
            foreach (string name in File.ReadAllLines(path)
                .OrderBy(x => x))
            {
                Console.WriteLine(name);
            }
        }

        public static int NamesCountFromFile(string path)
        {
            int count = File.ReadAllLines(path).Length;

            return count;
        }
    }
}