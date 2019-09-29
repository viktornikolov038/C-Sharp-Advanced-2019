using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Find_Evens_or_Odds
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var numbers = new List<int>();
            for (int i = input[0]; i < input[1] + 1; i++)
            {
                numbers.Add(i);
            }
            var condition = Console.ReadLine();
            if (condition == "odd")
            {
                Console.WriteLine(string.Join(" ",numbers
                    .Where(n => (n % 2 == 1)||(n % 2 == -1)))); 
            }
            else
            {
                Console.WriteLine(string.Join(" ", numbers
                    .Where(n => (n % 2 == 0))));
            }
        }
    }
}
