using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Diagonal_Difference
{
    public class Program
    {
        public static void Main()
        {
            var size = long.Parse(Console.ReadLine());
            long[][] matrix = new long[size][];

            var firstDiagonalSum = 0l;
            var secondDiagonalSum = 0l;

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = Console.ReadLine().Split(new[] {' '},StringSplitOptions.RemoveEmptyEntries).Select(long.Parse).ToArray();
            }

            for (int row = 0; row < matrix.Length; row++)
            {
                firstDiagonalSum += matrix[row][row];
           
                secondDiagonalSum += matrix[matrix.Length - 1 - row][row];
            }
            Console.WriteLine(Math.Abs(firstDiagonalSum - secondDiagonalSum));
        }
    }
}
