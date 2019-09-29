using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.Excellent_Students
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Dictionary<string, List<int>>();
            while (true)
            {
                var line = Console.ReadLine();
                if (line == "END")
                {
                    break;
                }
                var data = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var grades = data.Skip(2).Select(int.Parse).ToList();
                result.Add($"{data[0]} {data[1]}", grades);
            }

            foreach (var students in result.Where(x => x.Value.Contains(6)))
            {
                Console.WriteLine(students.Key);
            }
        }
    }
}
