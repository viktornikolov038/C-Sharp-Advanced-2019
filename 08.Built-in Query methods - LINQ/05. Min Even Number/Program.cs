using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Min_Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var even = numbers.Where(n => n % 2 == 0).ToArray();
            if (even.Any())
            {
                Console.WriteLine("{0:f2}",even.Min());
            }
            else
            {
                Console.WriteLine("No match");
            }
        }
    }
}
