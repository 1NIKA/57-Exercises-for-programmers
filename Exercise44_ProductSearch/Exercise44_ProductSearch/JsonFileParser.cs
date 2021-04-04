using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise44_ProductSearch
{
    public class JsonFileParser
    {
        public static bool JsonParse(string name, string path)
        {
            JObject obj1 = JObject.Parse(File.ReadAllText(path));
            dynamic products = obj1;

            for (int i = 0; i < products.products.Count; i++)
            {
                if (name.Equals(products.products[i].Name.ToString(), 
                        StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Name: {products.products[i].Name}");
                    Console.WriteLine($"Price: {products.products[i].Price.ToString("C", CultureInfo.GetCultureInfo("en-US"))}");
                    Console.WriteLine($"Quantity on hand: {products.products[i].Quantity}");
                    
                    return true;
                }
            }

            return false;
        }
    }
}