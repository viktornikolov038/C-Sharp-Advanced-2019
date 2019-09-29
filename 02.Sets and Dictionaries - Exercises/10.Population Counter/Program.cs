using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Population_Counter
{
    public class Program
    {
        public static void Main()
        {
            var report = new Dictionary<string,Dictionary<string,long>>();
            var totalForeachCountry = new Dictionary<string,long>();
            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "report")
                {
                    break;
                }
                var tokens = inputLine.Split('|');
                var currentCity = tokens[0];
                var currentCountry = tokens[1];
                var currentCityPopulation = long.Parse(tokens[2]);

                if (!totalForeachCountry.ContainsKey(currentCountry))
                {
                    totalForeachCountry[currentCountry] = 0l;
                }

                if (!report.ContainsKey(currentCountry))
                {
                    report[currentCountry] = new Dictionary<string, long>();
                }
                if (!report[currentCountry].ContainsKey(currentCity))
                {
                    report[currentCountry][currentCity] = 0l;
                }
                report[currentCountry][currentCity] += currentCityPopulation;
                totalForeachCountry[currentCountry] += currentCityPopulation;


            }

            totalForeachCountry = totalForeachCountry.OrderByDescending(c => c.Value)
                .ToDictionary(c => c.Key, c => c.Value);


           

            foreach (var country in totalForeachCountry)
            {
                Console.WriteLine($"{country.Key} (total population: {country.Value})");
                var result = report[country.Key].OrderByDescending(c => c.Value);
                foreach (var city in result)
                {
                    
                        Console.WriteLine($"=>{city.Key}: {city.Value}");
                    
                }
            }
        }
    }
}
