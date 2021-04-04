using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercise43_WebsiteGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Site name: ");
            string folderName = Console.ReadLine();
            Console.Write("Author: ");
            string author = Console.ReadLine();

            MainDirectory.CreateFolder(folderName);
            IndexCsHtml.CreateIndexHtmlFile(folderName, folderName, author);
            ZipFile.CreateFromDirectory(folderName, "result.zip");

            Console.WriteLine($"Created ./{folderName}");
            Console.WriteLine($"Created ./{folderName}/index.html");

            Console.ReadKey();
        }
    }
}