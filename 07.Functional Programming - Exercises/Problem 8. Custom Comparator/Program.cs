using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_8.Custom_Comparator
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split(new[] {' '})
                .Select(int.Parse)
                .ToArray();
            var odds = numbers.Where(n => n % 2 == 0).OrderBy(n => n).ToArray();
            var evens = numbers.Where(n => n % 2 != 0).OrderBy(n => n).ToArray();
            Console.WriteLine(string.Join(" ",odds.Concat(evens)));
        }
    }
}
