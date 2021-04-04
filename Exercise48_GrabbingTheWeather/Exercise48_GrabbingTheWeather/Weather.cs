using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise48_GrabbingTheWeather
{
    public class Weather
    {
        public double TempFahrenheit { get; set; }
        public double TempCelsius { get; set; }
        public long Sunrise { get; set; }
        public long Sunset { get; set; }
        public double Humidity { get; set; }
        public string Description { get; set; }
        public string WindDegree { get; set; }
        public double Wind { get; set; }
    }
}