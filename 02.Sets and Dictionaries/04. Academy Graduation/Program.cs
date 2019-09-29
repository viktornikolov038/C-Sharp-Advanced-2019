using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Academy_Graduation
{
    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var result = new SortedDictionary<string, List<double>>();
            for (int i = 0; i < n; i++)
            {
                var studentName = Console.ReadLine();
                var grades = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToList();
                if (!result.ContainsKey(studentName))
                {
                    result[studentName] = new List<double>();
                }

                for (int j = 0; j < grades.Count; j++)
                {
                    result[studentName].Add(grades[j]);
                }               
            }

            foreach (var student in result)
            {
                Console.WriteLine($"{student.Key} is graduated with {student.Value.Average()}");
            }
        }
    }
}
