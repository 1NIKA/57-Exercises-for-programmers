using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise45_WordFinder
{
    public class FileParser
    {
        public static Dictionary<string, string> ReplaceBadWordsWithGoodWordsImpl()
        {
            var words = new Dictionary<string, string>();

            using (StreamReader reader = new StreamReader("BadAndGoodWords.txt"))
            {
                while (reader.Peek() >= 0)
                {
                    string line = reader.ReadLine();
                    words.Add(line.Split(':')[0], line.Split(':')[1]);
                }
            }

            return words;
        }
    }
}
