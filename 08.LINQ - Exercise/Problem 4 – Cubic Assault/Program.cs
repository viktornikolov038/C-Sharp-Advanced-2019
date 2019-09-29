using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4___Cubic_Assault
{
    public class Program
    {
        public static void Main()
        {   
            var result = new Dictionary<string,Dictionary<string,long>>();
            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "Count em all")
                {
                    break;
                }
                var data = inputLine.Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
                var regionName = data[0];
                var meteorType = data[1];
                var count = long.Parse(data[2]);
                //if (meteorType != "Green" && meteorType != "Black" && meteorType != "Red")
                //{
                //    continue;
                //}
                if (!result.ContainsKey(regionName))
                {
                    result[regionName] = new Dictionary<string, long>();
                }
                if (!result[regionName].ContainsKey(meteorType))
                {
                    result[regionName][meteorType] = 0L;
                }
                result[regionName][meteorType] += count;
            }

            //region
            //color : count 

            
            foreach (var type in result)
            {

                if (!result[type.Key].ContainsKey("Green"))
                {
                    result[type.Key].Add("Green", 0L);
                }
                if (!result[type.Key].ContainsKey("Black"))
                {
                    result[type.Key].Add("Black", 0L);
                }
                if (!result[type.Key].ContainsKey("Red"))
                {
                    result[type.Key].Add("Red", 0L);
                }



                if (result[type.Key]["Green"] >= 1000000)
                    {
                        result[type.Key]["Red"] += result[type.Key]["Green"] / 1000000;
                        result[type.Key]["Green"] = result[type.Key]["Green"] % 1000000;
                        
                    }//1000999
                    if (result[type.Key]["Red"] >= 1000000)
                    {
                        result[type.Key]["Black"] += result[type.Key]["Red"] / 1000000;
                        result[type.Key]["Red"] = result[type.Key]["Red"] % 1000000;
                        
                    }
                    
                        
                
            }
            result = result
                .OrderByDescending(b => b.Value["Black"])
                .ThenBy(b => b.Key.Length)
                .ThenBy(b => b.Key)
                .ToDictionary(b => b.Key, b => b.Value);
            foreach (var region in result)
            {
                Console.WriteLine(region.Key);
                var currentRegion = region.Value.OrderByDescending(c => c.Value).ThenBy(c => c.Key).ToDictionary(c => c.Key, c => c.Value);
                foreach (var colorAndCount in currentRegion)
                {
                    Console.WriteLine($"-> {colorAndCount.Key} : {colorAndCount.Value}");
                }
            }
        }
    }
}
