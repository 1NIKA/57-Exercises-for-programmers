using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercise45_WordFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Before modify:");
            FileRead.ReadFile("filereader.txt");

            Console.WriteLine("\nAfter modify:");
            Console.WriteLine($"The number of replacements: {WordCounter.CountWord("filereader.txt")}");
            FileWrite.WriteFile("modifiedFile.txt", (List<string>)StringContains.ReplaceBadWordsWithGoodWords("filereader.txt"));
            FileRead.ReadFile("modifiedFile.txt");

            Console.ReadKey();
        }
    }
}