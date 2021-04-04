using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9_PaintCalculator
{
    class Program
    {
        public const int gallonCoversFeet = 350;
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Length: ");
                    int length = int.Parse(Console.ReadLine());
                    Console.Write("Width: ");
                    int Width = int.Parse(Console.ReadLine());

                    int area = length * Width;
                    int newArea = area;
                    int countGallon = 1;

                    if (area < gallonCoversFeet)
                    {
                        countGallon = 0;
                    }
                    else
                    {
                        while (area > gallonCoversFeet)
                        {
                            countGallon++;
                            area -= gallonCoversFeet;
                        }
                    }
                    Console.WriteLine($"You will need to purchase {countGallon} " +
                        $"gallons of\npaint to cover {newArea} square feet.");
                    break;
                }
                catch
                {
                    Console.WriteLine("enter only numbers;");
                }
                
            }

            Console.ReadKey();
        }
    }
}