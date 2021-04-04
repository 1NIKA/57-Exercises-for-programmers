using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise20_MultistateSalesTaxCalculator
{
    public class TaxCounter
    {
        public static void Tax(StateWithTax state, Order order)
        {
            state.State.TryGetValue(Console.ReadLine().ToLower(), out double value);
            Console.WriteLine($"The tax is {value.ToString("C", CultureInfo.GetCultureInfo("en-US"))}.");
            
            double tax = order.Amount + value;
            Console.WriteLine($"The total is {tax.ToString("C", CultureInfo.GetCultureInfo("en-US"))}.");
        }
    }
}