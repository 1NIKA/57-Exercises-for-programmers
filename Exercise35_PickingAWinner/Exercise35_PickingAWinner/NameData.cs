using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise35_PickingAWinner
{
    public class NameData
    {
        public static ArrayList AddNamesToArray(string text)
        {
            string name;
            ArrayList names = new ArrayList();

            do
            {
                Console.Write(text);
                name = Console.ReadLine();

                if (name != "")
                {
                    names.Add(name);
                }

            } while (name != "");

            return names;
        }
    }
}
