using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Exercise15_PasswordValidation
{
    class Program
    {
        public const int SALT_SIZE = 24; // size in bytes
        public const int HASH_SIZE = 24; // size in bytes
        public const int ITERATIONS = 100000; // number of pbkdf2 iterations

        public static byte[] CreateHash(string input)
        {
            // Generate a salt
            RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider();
            byte[] salt = new byte[SALT_SIZE];
            provider.GetBytes(salt);

            // Generate the hash
            Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(input, salt, ITERATIONS);
            return pbkdf2.GetBytes(HASH_SIZE);
        }

        static void Main(string[] args)
        {
            Console.Write("What is the username: ");
            string username = Console.ReadLine();
            Console.Write("What is the password: ");
            string password = Console.ReadLine();
            bool isFind = false;

            var users = new Dictionary<string, string>
            {
                { "nika", "12345688" },
                { "Nika", "abc$123" },
                { "Anna", "abc$3" },
                { "Luka", "a$123" },
                { "Sandro", "123" }
            };

            foreach (var user in users)
            {
                if (user.Key == username && user.Value == password)
                {
                    isFind = true;
                }
            }

            if (isFind)
            {
                Console.WriteLine("Welcome!");
            }
            else
            {
                Console.WriteLine("I don't know you.");
            }

            Console.ReadKey();
        }
    }
}
