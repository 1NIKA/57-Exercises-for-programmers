using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise44_ProductSearch
{
    public class JsonFileAdder
    {
        private static readonly string json =
            @"D:\C#\57 Exercises for programmers\Exercise44_ProductSearch\Exercise44_ProductSearch\product.json";

        public static void AddProductsToJsonFile(string name, double price, int quantity, string path)
        {
            Dictionary<string, List<Product>> productsList = new Dictionary<string, List<Product>>()
            {
                { "products", new List<Product>(AllDataFromJson())
                    {
                        new Product()
                        {
                            Name = name,
                            Price = price,
                            Quantity = quantity
                        }
                    }
                }
            };

            string json = JsonConvert.SerializeObject(productsList);
            File.WriteAllText(path, json);
        }

        private static IEnumerable<Product> AllDataFromJson()
        {
            JObject jObject = JObject.Parse(File.ReadAllText(json));
            dynamic products = jObject;
            List<Product> productsList = new List<Product>();

            for (int i = 0; i < products.products.Count; i++)
            {
                productsList.Add(new Product()
                    {
                        Name = products.products[i].Name,
                        Price = products.products[i].Price,
                        Quantity = products.products[i].Quantity,
                    }
                );
            }

            return productsList;
        }
    }
}