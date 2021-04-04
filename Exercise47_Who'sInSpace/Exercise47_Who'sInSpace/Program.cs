using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise47_Who_sInSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Name                  | Craft");
            Console.WriteLine("----------------------|--------");

            int max = FindMaxNameLength(ApiParser.ParseAPI());

            foreach (var person in ApiParser.ParseAPI()
                .OrderBy(p => p.Key))
            {   
                Console.WriteLine(string.Format($"{{0, {-max-1}}} | {{1}}",
                        person.Key, person.Value));
            }

            Console.WriteLine("\nWith group: ");
            foreach (var item in ApiParser.ParseAPI()
                .GroupBy(x => x.Value))
            {
                Console.WriteLine(item.Key + " : ");
                foreach (var person in item.
                    OrderBy(p => p.Key))
                {
                    Console.WriteLine("     " + person.Key);
                }
            }

            Console.ReadKey();
        }

        static int FindMaxNameLength(Dictionary<dynamic, dynamic> names)
        {
            int max = 0;
            string name;

            foreach (var person in names)
            {
                name = Convert.ToString(person.Key);

                if (max < name.Length)
                    max = name.Length;
            }

            return max;
        }
    }
}