using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Sets_of_Elements
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var sets = Console.ReadLine().Split();
            var n = int.Parse(sets[0]);
            var m = int.Parse(sets[1]);
            var firstSet = new List<int>();
            var secondSet = new List<int>();
            for (int i = 0; i < n; i++)
            {
                var currentNum = int.Parse(Console.ReadLine());
                firstSet.Add(currentNum);
            }
            for (int i = 0; i < m; i++)
            {
                var currentNum = int.Parse(Console.ReadLine());
                secondSet.Add(currentNum);
            }
            var result = firstSet.Intersect(secondSet);
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
