using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Reverse_and_exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var delimer = int.Parse(Console.ReadLine());
            var result = nums.Reverse().Where(n => n % delimer != 0).ToArray();
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
