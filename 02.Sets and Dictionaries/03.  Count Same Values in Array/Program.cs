using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Count_Same_Values_in_Array
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();
            var result = new SortedDictionary<double, List<int>>();
            foreach (var number in numbers)
            {
                if (!result.ContainsKey(number))
                {
                    result[number] = new List<int>();
                }

                result[number].Add(1);
            }

            foreach (var number in result)
            {
                Console.WriteLine($"{number.Key} - {number.Value.Count} times");
            }
        }
    }
}
