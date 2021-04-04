using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise20_MultistateSalesTaxCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is the order amount? ");

            Order order = new Order();
            order.Amount = double.Parse(Console.ReadLine());

            Console.Write("What state do you live in? ");

            TaxCounter.Tax(StateWithTaxData.stateWithTax, order);

            Console.ReadKey();
        }
    }
}