using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise48_GrabbingTheWeather
{
    public class WeatherDegreesAndDirections
    {
        public static List<WindDegrees> windDegrees = new List<WindDegrees>
        {
            new WindDegrees()
            {
                Direction = "N",
                StartDegree = 348.75,
                EndDegree = 11.25
            },
            new WindDegrees()
            {
                Direction = "NNE",
                StartDegree = 11.25,
                EndDegree = 33.75
            },
            new WindDegrees()
            {
                Direction = "NE",
                StartDegree = 33.75,
                EndDegree = 56.25
            },
            new WindDegrees()
            {
                Direction = "ENE",
                StartDegree = 56.25,
                EndDegree = 78.75
            },
            new WindDegrees()
            {
                Direction = "E",
                StartDegree = 78.75,
                EndDegree = 101.25
            },
            new WindDegrees()
            {
                Direction = "ESE",
                StartDegree = 101.25,
                EndDegree = 123.75
            },
            new WindDegrees()
            {
                Direction = "SE",
                StartDegree = 123.75,
                EndDegree = 146.25
            },
            new WindDegrees()
            {
                Direction = "SSE",
                StartDegree = 146.25,
                EndDegree = 168.75
            },
            new WindDegrees()
            {
                Direction = "S",
                StartDegree = 168.25,
                EndDegree = 191.25
            },
            new WindDegrees()
            {
                Direction = "SSW",
                StartDegree = 191.25,
                EndDegree = 213.75
            },
            new WindDegrees()
            {
                Direction = "SW",
                StartDegree = 213.75,
                EndDegree = 236.25
            },
            new WindDegrees()
            {
                Direction = "WSW",
                StartDegree = 236.25,
                EndDegree = 258.75
            },
            new WindDegrees()
            {
                Direction = "W",
                StartDegree = 258.75,
                EndDegree = 281.25
            },
            new WindDegrees()
            {
                Direction = "WNW",
                StartDegree = 281.25,
                EndDegree = 303.75
            },
            new WindDegrees()
            {
                Direction = "NW",
                StartDegree = 303.75,
                EndDegree = 326.25
            },
            new WindDegrees()
            {
                Direction = "NNW",
                StartDegree = 326.25,
                EndDegree = 348.75
            },
        };
    }
}