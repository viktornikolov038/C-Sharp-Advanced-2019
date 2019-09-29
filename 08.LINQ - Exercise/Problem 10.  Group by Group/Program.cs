using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_10.Group_by_Group
{
    
    public class Program
    {
        public static void Main()
        {
            var result = new Dictionary<int, List<string>>();
            while (true)
            {
                var line = Console.ReadLine();
                if (line == "END")
                {
                    break;
                }
                var data = line.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                var name = $"{data[0]} {data[1]}";
                var group = int.Parse(data[2]);
                if (!result.ContainsKey(group))
                {
                    result[group] = new List<string>();
                }
                result[group].Add(name);
            }
            result = result.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var groupedStudent in result)
            {
                Console.WriteLine($"{groupedStudent.Key} - {string.Join(", ",groupedStudent.Value)}");
            }
        }
    }
}
