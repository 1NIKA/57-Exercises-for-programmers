using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11_CurrencyConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> currenciesToUSD = new Dictionary<string, double>();
            currenciesToUSD.Add("EU", 1.21616);
            currenciesToUSD.Add("GEL", 0.303037);
            currenciesToUSD.Add("GBP", 1.37334);
            currenciesToUSD.Add("TRY", 0.136218);
            currenciesToUSD.Add("MYR", 0.246979);
            currenciesToUSD.Add("RUB", 0.0132794);

            Console.Write("Choose the currency: (EU, GEL, GBP, TRY, MYR, RUB) ");
            string currency = Console.ReadLine();
            Console.Write($"How many {currency} are you exchanging? ");
            double euro = double.Parse(Console.ReadLine());
            double rate = 0;

            foreach (var item in currenciesToUSD)
            {
                if (item.Key == currency)
                {
                    rate = item.Value;
                }
            }

            double amountToUSD = euro * rate;

            Console.WriteLine($"{euro} {currency} at an exchange rate of {rate} is" +
                $"\n{Math.Round(amountToUSD, 2)} U.S. dollars.");

            Console.ReadKey();
        }
    }
}
