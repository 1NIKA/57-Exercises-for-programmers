using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise51_PushingNotesToFirebase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("$ mynotes ");
            string text = Console.ReadLine();
            if (text.StartsWith("new "))
            {
                JsonWriter.WriteTextToJson("data.json", text);
                Console.WriteLine("Data add successfully");
            }
            else
            {
                Console.WriteLine("This command is not correct");
            }
            
            Console.ReadKey();
        }
    }
}