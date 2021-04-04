using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise31_KarvonenHeartRate
{
    class Program
    {
        static void Main(string[] args)
        {   
            while (true)
            {
                try
                {
                    Console.Write("Enter your Resting Pulse: ");
                    double pulse = double.Parse(Console.ReadLine());
                    Console.Write("Enter your age: ");
                    int age = int.Parse(Console.ReadLine());
                    TargetHeartRate(65, 22);
                    break;
                }
                catch
                {
                    Console.WriteLine("Enter only valid inputs");
                }   
            }        

            Console.ReadKey();
        }

        static void TargetHeartRate(double pulse, int age)
        {
            List<int> intensity = new List<int>();
            for (int i = 55; i <= 95; i+=5)
            {
                intensity.Add(i);
            }

            Console.WriteLine("\nIntensity   | Rate");
            Console.WriteLine("------------|--------");

            double targetHeartRate = 0;
            foreach (int item in intensity)
            {
                targetHeartRate = (((220 - age) - pulse) * item / 100) + pulse;
                Console.WriteLine(string.Format("{0}%         | {1} bpm", item,
                     Math.Round(targetHeartRate, 0)));
            }  
        }
    }
}
