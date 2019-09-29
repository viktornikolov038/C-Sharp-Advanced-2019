using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Sort_Students
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new List<string[]>();
            while (true)
            {
                var line = Console.ReadLine();
                if (line == "END")
                {
                    break;
                }
                var tokens = line.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                result.Add(tokens);
            }

            foreach (var student in result.OrderBy(x => x[1]).ThenByDescending(x => x[0]))
            {
                Console.WriteLine(string.Join(" ",student));
            }
        }
    }
}
