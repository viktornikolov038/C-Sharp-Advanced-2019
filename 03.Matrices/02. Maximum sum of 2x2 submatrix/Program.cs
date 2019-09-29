using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Maximum_sum_of_2x2_submatrix
{
    public class Program
    {
        public static void Main()
        {
            var sizeOfMatrix = Console.ReadLine()
                .Split(new[] {", "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[][] matrix = new int[sizeOfMatrix[0]][];
            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = Console.ReadLine()
                    .Split(new[] {", "}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }

            var maxSquareRow = 0;
            var maxSquareCol = 0;
            var maxSum = 0;
            int[,] resultMatrix = new int[2,2];
            for (int row = 0; row < matrix.Length - 1; row++)
            {
                for (int col = 0; col < matrix[row].Length - 1; col++)
                {
                    var currentSum = 0;
                    currentSum = matrix[row][col] + matrix[row][col + 1] + matrix[row + 1][col] +
                                 matrix[row + 1][col + 1];
                    if (maxSum < currentSum)
                    {
                        maxSum = currentSum;
                        //resultMatrix[0,0] = matrix[row][col];
                        //resultMatrix[0,1] = matrix[row][col + 1];
                        //resultMatrix[1,0] = matrix[row + 1][col];
                        //resultMatrix[1,1] = matrix[row + 1][col + 1];
                        maxSquareRow = row;
                        maxSquareCol = col;
                    }
                }
            }
            //for (int row = 0; row < resultMatrix.GetLength(0); row++)
            //{
            //    for (int col = 0; col < resultMatrix.GetLength(1); col++)
            //    {
            //        Console.Write($"{resultMatrix[row,col]} ");
            //    }
            //    Console.WriteLine();
            //}

            Console.WriteLine($"{matrix[maxSquareRow][maxSquareCol]} {matrix[maxSquareRow][maxSquareCol + 1]}");
            Console.WriteLine($"{matrix[maxSquareRow + 1][maxSquareCol]} {matrix[maxSquareRow + 1][maxSquareCol + 1]}");
            Console.WriteLine(maxSum);
        }
    }
}
