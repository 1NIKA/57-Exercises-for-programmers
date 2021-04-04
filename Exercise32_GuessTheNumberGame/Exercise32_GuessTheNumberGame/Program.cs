using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise32_GuessTheNumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Let's play Guess the Number.");
                Console.Write("Pick a difficulty level (1, 2, or 3): ");
                int level = int.Parse(Console.ReadLine());
                Console.Write("I have my number. What's your guess? ");
                int guessNumber = int.Parse(Console.ReadLine());

                NumberGameRules player1 = new NumberGameRules
                {
                    Difficulty = level,
                    GuessNumber = guessNumber
                };

                RandomNumbersForBeginners beginners = new RandomNumbersForBeginners();
                RandomNumbersForAdvanced advanced = new RandomNumbersForAdvanced();
                RandomNumbersForPro pro = new RandomNumbersForPro();

                switch (level)
                {
                    case 1:
                        beginners.FindNumber(guessNumber);
                        break;
                    case 2:
                        advanced.FindNumber(guessNumber);
                        break;
                    case 3:
                        pro.FindNumber(guessNumber);
                        break;
                    default:
                        pro.FindNumber(guessNumber);
                        break;
                }

                Console.Write("Play again? ");
                string answer = Console.ReadLine();

                if (answer == "n")
                {
                    break;
                }
            }
        }
    }
}