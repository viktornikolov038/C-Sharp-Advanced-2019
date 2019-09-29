using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_11.Logs_Aggregator
{
    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var result = new Dictionary<string,SortedSet<string>>();
            var durations = new Dictionary<string,int>();
            for (int i = 0; i < n; i++)
            {
                var inputLine = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                var currentIp = inputLine[0];
                var currentUser = inputLine[1];
                var currentDuration = int.Parse(inputLine[2]);
                if (!result.ContainsKey(currentUser))
                {
                    result[currentUser] = new SortedSet<string>();
                }
                if (!durations.ContainsKey(currentUser))
                {
                    durations[currentUser] = new int();
                }
                durations[currentUser] += currentDuration;
                result[currentUser].Add(currentIp);
            }

            foreach (var user in result.OrderBy(a => a.Key))
            {
                Console.WriteLine($"{user.Key}: {durations[user.Key]} [{string.Join(", ",user.Value.OrderBy(a => a))}]");
            }
        }
    }
}
