using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exercise44_ProductSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            const string json = @"D:\C#\57 Exercises for programmers\Exercise44_ProductSearch\Exercise44_ProductSearch\product.json";
            
            Console.Write("What is the product name? ");
            string productName = Console.ReadLine();

            while (!JsonFileParser.JsonParse(productName, json))
            {
                Console.WriteLine("Sorry, that product was not found in our inventory.");
                Console.Write("Do you want to add this product? y/n ");
                var key = Console.ReadKey();
                if (key.Key == ConsoleKey.Y)
                {
                    Console.Write("\nPrice: ");
                    double price = double.Parse(Console.ReadLine());
                    Console.Write("Quantity: ");
                    int qunatity = int.Parse(Console.ReadLine());

                    JsonFileAdder.AddProductsToJsonFile(productName, price, qunatity, json);
                    Console.WriteLine("\nplease wait few seconds...");
                    Thread.Sleep(1000);
                    Console.WriteLine("Product add successfully!\n");
                }
                else if (key.Key == ConsoleKey.N)
                {
                    Console.Write("\nWhat is the product name? ");
                    productName = Console.ReadLine();
                }
            }

            Console.ReadKey();
        }
    }
}