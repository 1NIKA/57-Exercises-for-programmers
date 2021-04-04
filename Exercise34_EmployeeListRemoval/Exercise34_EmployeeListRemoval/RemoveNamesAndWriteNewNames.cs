using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise34_EmployeeListRemoval
{
    public class RemoveNamesAndWriteNewNames
    {
        public static void DeleteName(string path, string deleteLine)
        {
            string[] lines = File.ReadAllLines(path);
            List<string> names = lines.ToList();

            if (names.Contains(deleteLine))
            {
                names.Remove(deleteLine);
                File.WriteAllLines(path, names);
                Console.WriteLine("The name deleted succesfully");
            }
            else
            {
                Console.WriteLine("The name does not exist.");
            }
        }
    }
}
