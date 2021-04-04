using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Exercise48_GrabbingTheWeather
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Where are you? ");
            string country = Console.ReadLine();
            
            foreach (var item in WeatherInfo.GetCurrentWeather(country))
            {
                Console.WriteLine($"{country} weather:");
                Console.WriteLine($"{item.TempFahrenheit} degrees Fahrenheit");
                Console.WriteLine($"{item.TempCelsius} degrees Celsius");
                Console.WriteLine($"Sunrise: {item.Sunrise}");
                Console.WriteLine($"Sunset: {item.Sunset}");
                Console.WriteLine($"Humidity: {item.Humidity}");
                Console.WriteLine($"Description: {item.Description}");
                Console.WriteLine($"Wind degree: {item.Wind}");
                Console.WriteLine($"Wind direction: {item.WindDegree}");

                PrintWeatherInfo(item.Wind, item.Description);
            }

            Console.ReadKey();
        }
        
        static void PrintWeatherInfo(double degree, string description)
        {
            if (degree <= 70 && description == "clear sky") 
            {
                Console.WriteLine("\nit’s a nice day out!");
            }
            else if (degree <= 200 && description == "clear sky")
            {
                Console.WriteLine("\nit’s a normal day out!");
            }
            else if (degree <= 350 && description == "few clouds")
            {
                Console.WriteLine("\nit’s a bad day out!\nMaybe Rain, So You need an umbrella");
            }
            else if (description == "overcast clouds")
            {
                Console.WriteLine("\nit’s a very bad day out!\nYou need a coat");
            }
            else
            {
                Console.WriteLine("\nit’s a very bad day out!");
            }
        }
    }
}