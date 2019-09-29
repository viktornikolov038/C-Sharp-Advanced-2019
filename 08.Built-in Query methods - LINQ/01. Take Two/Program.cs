using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Take_Two
{
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine();
            var result = numbers
                .Split()
                .Select(int.Parse)
                .Distinct()
                .Where(n => n >= 10 && n <= 20)
                .Take(2)
                .ToArray();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
