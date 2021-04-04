using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise30_MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = MultiplicationTable();

            for (int i = 1; i < 13; i++)
            {
                for (int j = 1; j < 13; j++)
                {
                    Console.Write(string.Format("{0, -5}", array[i, j]));
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        static int[,] MultiplicationTable()
        {
            int[,] multiplicationTable = new int[13, 13];
            
            for (int i = 1; i < 13; i++)
            {
                for (int j = 1; j < 13; j++)
                {
                    multiplicationTable[i, j] = i * j;
                }
            }

            return multiplicationTable;
        }
    }
}
