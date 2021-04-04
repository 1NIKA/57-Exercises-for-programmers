using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercise45_WordFinder
{
    public class WordCounter
    {
        public static int CountWord(string path)
        {
            var wordsDictionary = FileParser.ReplaceBadWordsWithGoodWordsImpl();
            int count = 0;

            foreach (string line in File.ReadAllLines(path))
            {
                var words = line.Split();

                foreach (string word in words)
                {
                    foreach (var item in wordsDictionary)
                    {
                        if (Regex.IsMatch(word, item.Key))
                            count++;
                    }
                }
            }

            return count;
        }
    } 
}  
