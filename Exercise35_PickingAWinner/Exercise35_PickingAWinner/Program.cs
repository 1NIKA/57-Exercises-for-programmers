using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise35_PickingAWinner
{
    class Program
    {
        static void Main(string[] args)
        {
            GameWinner.WinnerName(NameData.AddNamesToArray("Enter a name: "));

            Console.ReadKey();
        }
    }
}