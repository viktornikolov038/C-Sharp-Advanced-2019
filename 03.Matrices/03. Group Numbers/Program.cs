using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Group_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine()
                .Split(new[] {", "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[][] matrix = new int[3][];
            var reminder0 = new List<int>();
            var reminder1 = new List<int>();
            var reminder2 = new List<int>();

            foreach (var num in inputLine)
            {
                if (Math.Abs(num) % 3 == 0)
                {
                    reminder0.Add(num);
                }
                else if (Math.Abs(num) % 3 == 1)
                {
                    reminder1.Add(num);
                }
                else if (Math.Abs(num) % 3 == 2)
                {
                    reminder2.Add(num);
                }
            }

            matrix[0] = reminder0.ToArray();
            matrix[1] = reminder1.ToArray();
            matrix[2] = reminder2.ToArray();

            for (int row = 0; row < matrix.Length; row++)
            {
                Console.WriteLine(string.Join(" ", matrix[row]));
            }




            //var zero = inputLine.Where(n => Math.Abs(n) % 3 == 0).ToArray();
            //var one = inputLine.Where(n => Math.Abs(n) % 3 == 1).ToArray();
            //var two = inputLine.Where(n => Math.Abs(n) % 3 == 2).ToArray();

            //Console.WriteLine(string.Join(" ", zero));
            //Console.WriteLine(string.Join(" ", one));
            //Console.WriteLine(string.Join(" ", two));
        }
    }
}