using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerice37_PasswordGenerator
{
    public class RandomPassword
    {
        public static string RandomPasswordGenerator(int length, 
            int characters, int numbers)
        {
            string randomGeneratedPassword = "";
            Random rand = new Random();

            IEnumerable<char> newChar = RandomPasswordGeneratorImpl(length, characters, numbers);
            var result = newChar.OrderBy(x => rand.Next());
            
            foreach (var item in result)
            {
                randomGeneratedPassword += item;
            }

            return randomGeneratedPassword;
        }

        private static IEnumerable<char> RandomPasswordGeneratorImpl(int length,
            int characters, int numbers)
        {
            List<char> generatedPassword = new List<char>();

            List<char> specialCharacters = new List<char>()
            { '~', '!', '@', '#', '$', '%', '^',
                '&', '*', '(', ')', '_', '+', '<', '>', '?', '/' };

            List<char> strings = new List<char>();
            List<int> numbersToList = new List<int>();

            Random rand = new Random();

            for (int i = 0; i < numbers; i++)
            {
                generatedPassword.Add((char)rand.Next(48, 57));
            }

            for (int i = 0; i < characters; i++)
            {
                generatedPassword.Add(specialCharacters[rand.Next(specialCharacters.Count)]);
            }

            for (int i = 0; i < rand.Next(length, 15) - (characters + numbers); i++)
            {
                generatedPassword.Add((char)rand.Next(97, 122));
            }

            return generatedPassword;
        }
    }
}
