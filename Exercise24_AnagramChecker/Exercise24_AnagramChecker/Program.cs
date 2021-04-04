using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise24_AnagramChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two strings and I'll tell you if " +
                "they are anagrams:");
            Console.Write("Enter the first string: ");
            string firstText = Console.ReadLine();
            Console.Write("Enter the second string: ");
            string secondText = Console.ReadLine();

            if (IsAnagram(firstText, secondText))
            {
                Console.WriteLine(
                    $"\"{firstText}\" and \"{secondText}\" are anagrams.");
            }


            Console.ReadKey();
        }

        static bool IsAnagram(string first, string second)
        {
            if (first.Length != second.Length)
                return false;

            if (first == second)
                return true;

            Dictionary<char, int> pool = new Dictionary<char, int>();
            foreach (char element in first.ToCharArray())
            {
                if (pool.ContainsKey(element))
                    pool[element]++;
                else
                    pool.Add(element, 1);
            }

            foreach (char element in second.ToCharArray())
            {
                if (!pool.ContainsKey(element))
                    return false;
                if (--pool[element] == 0)
                    pool.Remove(element);
            }

            return pool.Count == 0;
        }
    }
}
