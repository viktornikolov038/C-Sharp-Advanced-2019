using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Legendary_Farming
{
    public class Program
    {
        public static void Main()
        {
            var keyMaterials = new Dictionary<string, int>();
            keyMaterials["shards"] = 0;
            keyMaterials["fragments"] = 0;
            keyMaterials["motes"] = 0;
            var junk = new Dictionary<string, int>();
            var mustStop = false;
            while (true)
            {
                var data = Console.ReadLine().ToLower().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < data.Length; i += 2)
                {

                    if (data[i + 1] == "shards")
                    {
                        
                        keyMaterials["shards"] += int.Parse(data[i]);
                    }
                    else if (data[i + 1] == "fragments")
                    {
                        
                        keyMaterials["fragments"] += int.Parse(data[i]);
                    }
                    else if (data[i + 1] == "motes")
                    {
                       
                        keyMaterials["motes"] += int.Parse(data[i]);
                    }
                    else
                    {
                        if (!junk.ContainsKey(data[i + 1]))
                        {
                            junk[data[i + 1]] = 0;
                        }
                        junk[data[i + 1]] += int.Parse(data[i]);
                    }




                    if (keyMaterials.ContainsKey("shards"))
                    {
                        if (keyMaterials["shards"] >= 250)
                        {
                            Console.WriteLine("Shadowmourne obtained!");
                            keyMaterials["shards"] = keyMaterials["shards"] - 250;
                            mustStop = true;
                            break;
                        }
                    }
                    if (keyMaterials.ContainsKey("fragments"))
                    {
                        if (keyMaterials["fragments"] >= 250)
                        {
                            Console.WriteLine("Valanyr obtained!");
                            keyMaterials["fragments"] = keyMaterials["fragments"] - 250;

                            mustStop = true;
                            break;
                        }
                    }
                    if (keyMaterials.ContainsKey("motes"))
                    {
                        if (keyMaterials["motes"] >= 250)
                        {
                            Console.WriteLine("Dragonwrath obtained!");
                            keyMaterials["motes"] = keyMaterials["motes"] - 250;
                            mustStop = true;
                            break;
                        }
                    }
                }
                if (mustStop)
                {
                    break;
                }
            }

            keyMaterials = keyMaterials
                .OrderByDescending(a => a.Value)
                .ThenBy(a => a.Key)
                .ToDictionary(a => a.Key, a => a.Value);
            foreach (var junkItem in keyMaterials)
            {
                Console.WriteLine($"{junkItem.Key}: {junkItem.Value}");
            }
            junk = junk.OrderBy(a => a.Key).ToDictionary(a => a.Key, a => a.Value);
            foreach (var junkItem in junk)
            {
                Console.WriteLine($"{junkItem.Key}: {junkItem.Value}");
            }
            
        }
    }
}

