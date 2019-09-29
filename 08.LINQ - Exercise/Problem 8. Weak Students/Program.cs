using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8.Weak_Students
{
    public class Program
    {
        public static void Main()
        {
            var result = new Dictionary<string, List<int>>();
            while (true)
            {
                var line = Console.ReadLine();
                if (line == "END")
                {
                    break;
                }
                var data = line.Split();
                var grades = data.Skip(2).Select(int.Parse).ToList();
                var weakGrades = new List<int>();
                for (int i = 0; i < grades.Count; i++)
                {
                    if (grades[i] <= 3)
                    {
                        weakGrades.Add(grades[i]);
                    }
                }
                if (weakGrades.Count >= 2)
                {
                    result.Add($"{data[0]} {data[1]}",weakGrades);
                }
            }

            foreach (var student in result)
            {
                Console.WriteLine(student.Key);
            }
        }
    }
}
