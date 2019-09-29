using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_7.Valid_Usernames
{
    public class Program
    {
        public static void Main()
        {
            var regex = new Regex(@"\b[a-zA-Z]\w{2,24}\b");
            var usernames = Console.ReadLine().Split(new[] {' ', '/', '\\', '(', ')'},
                StringSplitOptions.RemoveEmptyEntries);
            var allMatches = new List<string>();
            foreach (var username in usernames)
            {
                var match = regex.Match(username);
                if (match.Success)
                {
                    allMatches.Add(match.Value.ToString());
                }
            }
            var pairs = new Dictionary<string, int>();
            for (int i = 0; i < allMatches.Count - 1; i++ )
            {
                if (pairs.ContainsKey(allMatches[i] + " " + allMatches[i + 1]))
                {
                    continue;
                }
                pairs.Add(allMatches[i] + " " + allMatches[i + 1], allMatches[i].Length + allMatches[i + 1].Length);
            }

            pairs = pairs.OrderByDescending(a => a.Value).ToDictionary(a => a.Key, a => a.Value);
            if (pairs.Any())
            {


                var first = pairs.First();
                var spilitedResult = first.ToString().Split(new[] {' ', ',',});

                Console.WriteLine(spilitedResult[0].Remove(0, 1));
                Console.WriteLine(spilitedResult[1]);
            }
        }
    }
}
