using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise45_WordFinder
{
    public class FileWrite
    {
        public static void WriteFile(string path, List<string> info)
        {
            File.AppendAllLines(path, info);
        }
    }
}