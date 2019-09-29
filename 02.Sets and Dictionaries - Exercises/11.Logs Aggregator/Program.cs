using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _11.Logs_Aggregator
{
    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            var report = new SortedDictionary<string,SortedSet<string>>();
            var everyDuration = new Dictionary<string,int>();
            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                var currentIp = tokens[0];
                var currentUser = tokens[1];
                var currentDuratation = int.Parse(tokens[2]);

                if (!report.ContainsKey(currentUser))
                {
                    report[currentUser] = new SortedSet<string>();
                }

                if (!everyDuration.ContainsKey(currentUser))
                {
                    everyDuration[currentUser] = 0;
                }
                everyDuration[currentUser] += currentDuratation;

                report[currentUser].Add(currentIp);
            }



            foreach (var user in report)
            {
                Console.WriteLine("{0}: {1} [{2}]",
                    user.Key,
                    everyDuration[user.Key],
                    string.Join(", ",user.Value));
            }
        }
    }
}
