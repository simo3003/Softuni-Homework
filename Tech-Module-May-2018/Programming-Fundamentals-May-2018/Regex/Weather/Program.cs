using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, City> weather = new Dictionary<string, City>();
            string pattern = @"(?<city>[A-Z]{2})(?<temp>\d+\.\d+)(?<type>[A-zA-z]+)\|";
            while (input != "end")
            {
                string city = "";
                double temp = 0;
                string weatherType = "";

                foreach (Match matches in Regex.Matches(input, pattern))
                {
                    if (matches.Success)
                    {
                        city = matches.Groups["city"].Value;
                        temp = double.Parse(matches.Groups["temp"].Value);
                        weatherType = matches.Groups["type"].Value;
                    }
                    else
                    {
                        break;
                    }
                }

                if (city == "" || temp == 0 || weatherType == "") // checks if input was invalid
                {
                    input = Console.ReadLine();
                    continue;
                }

                if (weather.ContainsKey(city))
                {
                    weather[city] = new City
                    {
                        Temp = temp,
                        WeatherType = weatherType
                    };
                }
                else
                {
                    weather.Add(city, new City
                    {
                        Temp = temp,
                        WeatherType = weatherType
                    });
                }
                input = Console.ReadLine();
            }

            foreach (var city in weather.OrderBy(x => x.Value.Temp))
            {
                Console.WriteLine($"{city.Key} => {city.Value.Temp:f2} => {city.Value.WeatherType}");
            }
        }
    }

    class City
    {
        public double Temp { get; set; }
        public string WeatherType { get; set; }
    }
}
