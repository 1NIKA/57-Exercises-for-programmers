using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise32_GuessTheNumberGame
{
    public class RateOfGame
    {
        public static void Rate(int count)
        {
            if (count == 1)
                Console.WriteLine("You’re a mind reader!");
            else if (count >= 2 || count <= 4)
                Console.WriteLine("Most impressive.");
            else if (count >= 3 || count <= 6)
                Console.WriteLine("You can do better than that.");
            else
                Console.WriteLine("Better luck next time.");
        }
    }
}
