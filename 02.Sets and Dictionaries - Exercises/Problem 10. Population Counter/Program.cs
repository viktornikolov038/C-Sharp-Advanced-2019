using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_10.Population_Counter
{
    public class Program
    {
        public static void Main()
        {
            var result = new Dictionary<string,Dictionary<string,long>>();
            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "report")
                {
                    break;
                }
                var data = inputLine.Split('|');

                var currentCity = data[0];
                var currentCounty = data[1];
                var currentPopulation = long.Parse(data[2]);

                if (!result.ContainsKey(currentCounty))
                {
                    result[currentCounty] = new Dictionary<string, long>();
                }
                if (!result[currentCounty].ContainsKey(currentCity))
                {
                    result[currentCounty][currentCity] = 0L;
                }
                result[currentCounty][currentCity] += currentPopulation;
            }

            result = result.OrderByDescending(x => x.Value.Values.Sum()).ToDictionary(x => x.Key, x => x.Value);
            foreach (var country in result)
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value.Values.Sum()})");
                var currentCities = country.Value.OrderByDescending(x => x.Value);
                foreach (var city in currentCities)
                {
                    Console.WriteLine($"=>{city.Key}: {city.Value}");
                }
            }
        }
    }
}
