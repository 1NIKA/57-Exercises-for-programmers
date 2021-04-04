using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise16_DrivingAge
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> legalDriving = new Dictionary<string, int>();
            legalDriving.Add("Algeria", 18);
            legalDriving.Add("Cameroon", 16);
            legalDriving.Add("Egypt", 19);
            legalDriving.Add("Eswatini", 16);
            legalDriving.Add("Ethiopia", 28);
            legalDriving.Add("Ghana", 16);
            legalDriving.Add("Kenya", 18);


            while (true)
            {
                try
                {
                    Console.Write("What is your age? ");
                    int age = int.Parse(Console.ReadLine());

                    if (age < 0)
                    {
                        Console.WriteLine("Dont enter less than 0");
                        continue;
                    }

                    Console.WriteLine(age < 16 ? "You are not old " +
                        "enough to legally drive." : "You are old enough " +
                        "to legally drive.\nYou can try to get DrivingLicense in this country\n");

                    var query = legalDriving
                        .Where(x => x.Value <= age)
                        .OrderBy(x => x.Value)
                        .Select(x => new { country = x.Key, age = x.Value });

                    foreach (var item in query)
                    {
                        Console.WriteLine($"Country: {item.country} - Age: {item.age}");
                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Dont enter non-numeric data\n" +
                        "Please enter valid input");
                }
            }

            Console.ReadKey();
        }
    }
}
