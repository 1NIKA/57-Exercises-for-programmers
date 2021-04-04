using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise52_CreatingYourOwnTimeService
{
    class Program
    {
        static void Main(string[] args)
        {
            JsonWriter.WriteCurrentDataInJson("currentTime.json");
            JsonReader.ReadCurrentDataInJson("currentTime.json");

            Console.ReadKey();
        }

        static void PrintInfo()
        {
            string time = DateTime.Now.ToString("h:mm:ss");
            Console.WriteLine("The current time is {0} UTC {1} {2} {3}.", time, 
                CultureInfo.InvariantCulture.DateTimeFormat.GetMonthName(DateTime.Now.Month),
                DateTime.Now.Day, DateTime.Now.Year);
        }
    }
}