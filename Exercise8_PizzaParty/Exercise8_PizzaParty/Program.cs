using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8_PizzaParty
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("How many people? ");
                    int people = int.Parse(Console.ReadLine());
                    Console.Write("How many pizzas do you have? ");
                    int pizzas = int.Parse(Console.ReadLine());
                    Console.Write("How many slices per pizza? ");
                    int slices = int.Parse(Console.ReadLine());

                    int count = (slices * pizzas) / people;
                    int rest = (slices * pizzas) % people;

                    Console.WriteLine($"{people} people with {pizzas} pizzas");

                    if (count == 1)
                    {
                        Console.WriteLine($"Each person gets {count} piece of pizza.");
                    }
                    else
                    {
                        Console.WriteLine($"Each person gets {count} pieces of pizza.");
                    }
                   
                    Console.WriteLine($"There are {rest} leftover pieces.");
                    break;
                }
                catch
                {
                    Console.WriteLine("Please enter only numbers");
                }

            }

            Console.ReadKey();
        }
    }
}
