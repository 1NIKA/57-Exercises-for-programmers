using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7_AreaOfARectangularRoom
{
    class Program
    {
        public const double conversion = 0.09290304;
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("What is the length of the room in foot? ");
                    int length = int.Parse(Console.ReadLine());
                    Console.Write("What is the width of the room in feet? ");
                    int width = int.Parse(Console.ReadLine());

                    Console.Write("choose feet or meters? ");
                    string choose = Console.ReadLine();

                    if (choose == "feet")
                    {
                        Console.WriteLine($"You entered dimensions of {length} feet " +
                            $"by {width} feet.");
                        Console.WriteLine($"The area is\n{length * width} square feet");
                    }
                    else
                    {
                        Console.WriteLine($"The area is\n" +
                        $"{Math.Round((length * width) * conversion, 3)} square meters");
                    }   
                    
                    break;
                }
                catch
                {
                    Console.WriteLine("enter only number");
                }    
            }

            Console.ReadKey();
        }
    }
}
