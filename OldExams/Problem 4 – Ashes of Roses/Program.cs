using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_4___Ashes_of_Roses
{
    public class Program
    {
        public static void Main()
        {
            var result = new Dictionary<string,Dictionary<string,long>>();
            var pattern = @"^Grow <([A-Z][a-z]+)> <([a-zA-Z0-9]+)> ([0-9]+)$";
            var regex = new Regex(pattern);
            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "Icarus, Ignite!")
                {
                    break;                    
                }

                var currentMatch = regex.Match(inputLine);
                if (!currentMatch.Success)
                {
                    continue;                   
                }

                var currentRegion = currentMatch.Groups[1].ToString();
                var currentColor = currentMatch.Groups[2].ToString();
                var currentRoseCount = int.Parse(currentMatch.Groups[3].ToString());

                if (!result.ContainsKey(currentRegion))
                {
                    result[currentRegion] = new Dictionary<string, long>();
                }
                if (!result[currentRegion].ContainsKey(currentColor))
                {
                    result[currentRegion][currentColor] = 0l;
                }

                result[currentRegion][currentColor] += currentRoseCount;
            }


            result = result
                .OrderByDescending(a => a.Value.Values.Sum())
                .ThenBy(a => a.Key)
                .ToDictionary(a => a.Key, a => a.Value);

            foreach (var region in result)
            {
                Console.WriteLine(region.Key);

                var colorsOrdered = region.Value
                    .OrderBy(a => a.Value)
                    .ThenBy(a => a.Key)
                    .ToDictionary(a => a.Key, a => a.Value);
                foreach (var color in colorsOrdered)
                {
                    Console.WriteLine($"*--{color.Key} | {color.Value}");
                }
            }
        }
    }
}
