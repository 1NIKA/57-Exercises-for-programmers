using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10_SelfCheckout
{
    class Program
    {
        public const double TAX_RATE = 5.5;
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter the price of item 1: ");
                    int price1 = int.Parse(Console.ReadLine());
                    Console.Write("Enter the quantity of item 1: ");
                    int quantity1 = int.Parse(Console.ReadLine());
                    Console.Write("Enter the price of item 2: ");
                    int price2 = int.Parse(Console.ReadLine());
                    Console.Write("Enter the quantity of item 2: ");
                    int quantity2 = int.Parse(Console.ReadLine());
                    Console.Write("Enter the price of item 3: ");
                    int price3 = int.Parse(Console.ReadLine());
                    Console.Write("Enter the quantity of item 3: ");
                    int quantity3 = int.Parse(Console.ReadLine());

                    double subTotal = (price1 * quantity1) + (price2 * quantity2)
                        + (price3 * quantity3);

                    double tax = (subTotal * TAX_RATE) / 100;
                    double total = subTotal + tax;

                    Console.WriteLine($"Subtotal: ${subTotal.ToString("f2")}");
                    Console.WriteLine($"Tax: ${Math.Round(tax, 2)}");
                    Console.WriteLine($"Total: ${Math.Round(total, 3)}");
                    break;
                }
                catch
                {
                    Console.WriteLine("enter only numbers");
                }
            }

            Console.ReadKey();
        }
    }
}
