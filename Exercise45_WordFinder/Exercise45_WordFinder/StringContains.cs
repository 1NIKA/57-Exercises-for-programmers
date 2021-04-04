using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercise45_WordFinder
{
    public class StringContains
    {
        public static IEnumerable<string> ReplaceBadWordsWithGoodWords(string path)
        {
            var words = FileParser.ReplaceBadWordsWithGoodWordsImpl();
            var file = new List<string>();

            using (StreamReader streamReader = new StreamReader(path))
            {
                while (streamReader.Peek() >= 0)
                {
                    string line = streamReader.ReadLine();

                    foreach (var word in words)
                    {
                        line = line.Replace(word.Key, word.Value);
                    }

                    file.Add(line);
                }
            }

            return file;
        }
    }
}