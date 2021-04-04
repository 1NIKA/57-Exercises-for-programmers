using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise46_WordFrequencyFinder
{
    public class FileParser
    {
        public static Dictionary<string, int> CountWordsInFile(string path)
        {
            var countWords = new Dictionary<string, int>();

            using (StreamReader reader = new StreamReader(path))
            {
                while (reader.Peek() >= 0)
                {
                    string line = reader.ReadLine().ToLower();
                    string[] words = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    for (int i = 0; i < words.Length; i++)
                    {
                        string word = words[i];

                        if (!char.IsLetterOrDigit(word[word.Length - 1]))
                        {
                            word = word.Remove(word.Length - 1);
                        }

                        if (countWords.ContainsKey(word))
                        {
                            countWords[word]++;
                        }
                        else
                        {
                            countWords.Add(word, 1);
                        }
                    }
                }

                return countWords;
            }
        }
    }
}