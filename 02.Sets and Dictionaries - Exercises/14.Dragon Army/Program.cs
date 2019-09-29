using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _14.Dragon_Army
{
    class Dragon
    {
        public int Damage { get; set; }

        public int  Health { get; set; }

        public int Armor { get; set; }
    
    }

    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var pattern = @"(.+?) (.+?) (.+?) (.+?) (.+)";

            var result = new Dictionary<string,Dictionary<string,Dragon>>();
            for (int i = 0; i < n; i++)
            {
                var inputLine = Console.ReadLine();
                if (!Regex.IsMatch(inputLine,pattern))
                {
                    continue;
                    
                }

                var regex = new Regex(pattern);
                var match = regex.Match(inputLine);

                var currentColor = match.Groups[1].ToString();
                var currentName = match.Groups[2].ToString();
                var currentDmg = 0;
                if (match.Groups[3].ToString() == "null")
                {
                    currentDmg = 45;
                }
                else
                {
                    currentDmg = int.Parse(match.Groups[3].ToString());
                }
                var currentHealth = 0;
                if (match.Groups[4].ToString() == "null")
                {
                    currentHealth = 250;
                }
                else
                {
                    currentHealth = int.Parse(match.Groups[4].ToString());
                }
                var currentArmor = 0;
                if (match.Groups[5].ToString() == "null")
                {
                    currentArmor = 10;
                }
                else
                {
                    currentArmor = int.Parse(match.Groups[5].ToString());
                }


                if (!result.ContainsKey(currentColor))
                {
                    result[currentColor] = new Dictionary<string, Dragon>();
                }
                if (!result[currentColor].ContainsKey(currentName))
                {
                    result[currentColor][currentName] = new Dragon();
                }
                result[currentColor][currentName] = new Dragon()
                {
                    Damage = currentDmg,
                    Health = currentHealth,
                    Armor = currentArmor
                };
            }


            

            foreach (var color in result)
            {
                double avgDmg = 0;
                double countDmg = 0;
                foreach (var dragon in color.Value)
                {
                    avgDmg += dragon.Value.Damage;
                    countDmg++;
                }
                avgDmg /= countDmg;

                double avgHealth = 0;
                double countHealth = 0;
                foreach (var dragon in color.Value)
                {
                    avgHealth += dragon.Value.Health;
                    countHealth++;
                }
                avgHealth /= countHealth;


                double avgArmor= 0;
                double countArmor = 0;
                foreach (var dragon in color.Value)
                {
                    avgArmor += dragon.Value.Armor;
                    countArmor++;
                }
                avgArmor /= countArmor;

                Console.WriteLine($"{color.Key}::({avgDmg:F2}/{avgHealth:F2}/{avgArmor:F2})");


                var orderedDragons = result[color.Key].OrderBy(a => a.Key).ToDictionary(a => a.Key, a => a.Value); 

                foreach (var dragon in orderedDragons)
                {
                    
                    
                    Console.WriteLine($"-{dragon.Key} -> damage: {dragon.Value.Damage}, health: {dragon.Value.Health}, armor: {dragon.Value.Armor}");
                }
            }
        }
    }
}
