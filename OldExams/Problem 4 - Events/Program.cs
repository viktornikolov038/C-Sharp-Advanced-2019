using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_4___Events
{
    public class Times
    {
        public int Hour { get; set; }

        public int Minute { get; set; }

        public string HoursAndMinutes { get; set; }
    }

    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var regex = new Regex(@"^#([a-zA-Z]+):\s*@([a-zA-Z]+)\s*(?:(\d+):(\d+))$");
            var result = new Dictionary<string, Dictionary<string, List<Times>>>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();
                var match = regex.Match(input);
                if (match.Success)
                {
                    var name = match.Groups[1].Value;
                    var town = match.Groups[2].Value;
                    var hours = match.Groups[3].Value;
                    var minutes = match.Groups[4].Value;
                    if (int.Parse(hours) == 0)
                    {
                        hours = "00";
                    }
                    if (int.Parse(hours) > 23)
                    {
                        continue;
                    }
                    if (int.Parse(minutes) > 59)
                    {
                        continue;
                    }
                    if (!result.ContainsKey(town))
                    {
                        result[town] = new Dictionary<string, List<Times>>();
                    }
                    if (!result[town].ContainsKey(name))
                    {
                        result[town][name] = new List<Times>();
                    }
                    result[town][name].Add(new Times()
                    {
                        Hour = int.Parse(hours),
                        Minute = int.Parse(minutes),
                        HoursAndMinutes = $"{hours}:{minutes}"

                    });
                }
            }
            var mustPrint = Console.ReadLine().Split(',').ToList();
            result = result.OrderBy(a => a.Key).ToDictionary(a => a.Key, a => a.Value);
            var validResult = new Dictionary<string, Dictionary<string, List<Times>>>(); ;
            foreach (var location in result)
            {
                if (mustPrint.Contains(location.Key))
                {
                    validResult.Add(location.Key, location.Value);
                }
            }

            foreach (var location in validResult)
            {
                var counter = 1;
                Console.WriteLine(location.Key + ":");
                var personAndTimes = new StringBuilder();
                foreach (var person in location.Value.OrderBy(a => a.Key))
                {

                    var currentTimes = new List<string>();
                    Console.Write($"{counter}. {person.Key} -> ");
                    counter++;
                    person.Value.OrderBy(x => x.Hour).ThenBy(x => x.Minute).ToList().ForEach(
                        a => currentTimes.Add(a.HoursAndMinutes + ", ")
                        );
                    for (int i = 0; i < currentTimes.Count; i++)
                    {

                        if (i == currentTimes.Count - 1)
                        {
                            Console.Write(currentTimes[i].TrimEnd(' ', ','));
                        }
                        else
                        {
                            Console.Write(currentTimes[i]);
                        }

                    }

                    Console.WriteLine();
                }
            }
        }
    }

}
