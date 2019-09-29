using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Find_and_Sum_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            var b = 0;
            var input = Console.ReadLine().Split().Where(a => int.TryParse(a, out b)).ToArray();
            var result = 0;
            if (input.Any())
            {
                Console.WriteLine(input.Select(double.Parse).Sum());

            }
            else
            {
                Console.WriteLine("No match");
            }

        }
    }
}
