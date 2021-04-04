using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Exercise48_GrabbingTheWeather
{
    public class WeatherInfo
    {
        private static readonly List<WindDegrees> windDegrees = WeatherDegreesAndDirections.windDegrees;

        public static IEnumerable<Weather> GetCurrentWeather(string country)
        {
            List<Weather> weatherInfo;

            using (var webClient = new WebClient())
            {
                var json = webClient.DownloadString(
                    $"http://api.openweathermap.org/data/2.5/weather?q={country}&appid=8f25f10da756db1f696f294c5f709f64");

                JObject obj1 = JObject.Parse(json);
                dynamic obj2 = obj1;
                (double fahrenheit, double celsius) = KelvinToFahrenheit((double)obj2.main.temp);

                weatherInfo = new List<Weather>
                {
                    new Weather { 
                    TempFahrenheit = fahrenheit,
                    TempCelsius = celsius,
                    Sunrise = obj2.sys.sunrise ,
                    Sunset = obj2.sys.sunset ,
                    Humidity = obj2.main.humidity,
                    Description = obj2.weather[0].description,
                    WindDegree = BinarySearch(windDegrees, obj2.wind.deg),
                    Wind = obj2.wind.deg }
                };
            }

            return weatherInfo;
        }

        private static (double fahrenheit, double celsius) KelvinToFahrenheit(dynamic kelvin)
        {
            double kelvinToFahrenheit = kelvin * 9 / 5 - 459.67;
            double kelvinToCelsius = kelvin - 273.15;

            return (Math.Round(kelvinToFahrenheit, 2), Math.Round(kelvinToCelsius, 2));
        }

        private static string BinarySearch(List<WindDegrees> windDegrees, dynamic item)
        {
            int low = 0;
            int high = windDegrees.Count - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                var guess = windDegrees[mid].EndDegree;
                var guess1 = windDegrees[mid].StartDegree;
                
                if (guess1 <= (double)item
                        && (double)item <= guess)
                    return windDegrees[mid].Direction;
                if (guess > (double)item)
                    high = mid - 1;
                else
                    low = mid + 1;
            }

            return null;
        }
    }
}