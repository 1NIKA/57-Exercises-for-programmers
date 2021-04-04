using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exerice37_PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What's the minimum length? ");
            int length = int.Parse(Console.ReadLine());
            Console.Write("How many special characters? ");
            int characters = int.Parse(Console.ReadLine());
            Console.Write("How many numbers? ");
            int numbers = int.Parse(Console.ReadLine());

            Console.WriteLine("Your random password is:");
            Console.WriteLine(RandomPassword.RandomPasswordGenerator(length, characters, numbers));

            Console.ReadKey();
        }
    }
}
