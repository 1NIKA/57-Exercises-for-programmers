using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise32_GuessTheNumberGame
{
    public class RandomNumbersForBeginners : IRandomNumbers
    {
        public void FindNumber(int number)
        {
            Random rand = new Random();
            int randomNum = rand.Next(1, 10);

            int count = 1;
            while (number != randomNum)
            {
                if (number < randomNum)
                {
                    Console.Write("Too low. Guess again: ");
                    number = int.Parse(Console.ReadLine());
                    count++;
                }
                else
                {
                    Console.Write("Too high. Guess again: ");
                    number = int.Parse(Console.ReadLine());
                    count++;
                }
            }

            Console.WriteLine($"You got it in {count} guesses!");
            RateOfGame.Rate(count);
        }
    }
}