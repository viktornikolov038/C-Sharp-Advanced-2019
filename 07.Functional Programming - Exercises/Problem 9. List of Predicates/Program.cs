using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9.List_of_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            var range = int.Parse(Console.ReadLine());
            var deviders = Console.ReadLine()
                .Split(new[] { ' ' })
                .Select(int.Parse)
                .ToArray();
            var numbers = new List<int>();
            for (int i = 1; i < range + 1; i++)
            {
                numbers.Add(i);
            }
            Func<int[], int[]> isValidNum = n =>  == 0;

        }
    }
}
