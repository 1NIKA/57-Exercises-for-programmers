using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise35_PickingAWinner
{
    public class GameWinner
    {
        public static void WinnerName(ArrayList names)
        {
            Random rand = new Random();
            int randomWinner = rand.Next(0, names.Count);

            names.RemoveAt(randomWinner);
            Console.WriteLine($"The winner is... {names[randomWinner]}.");
        }
    }
}
