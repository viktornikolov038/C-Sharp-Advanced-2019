using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Matrices_Demo_Vol._2
{
    public class Program
    {
        public static void Main()
        {

            int[][] matrix = new int[3][];
            var counter = 0;
            for (int rowIndex = 0; rowIndex < matrix.Length; rowIndex++)
            {
                matrix[rowIndex] = new int[3];
                for (int coIndex = 0; coIndex < matrix[rowIndex].Length; coIndex++)
                {
                    matrix[rowIndex][coIndex] = counter;
                    counter++;
                }
            }

            

            int[,] secondMatrix = new int[3,3];

            counter = 0;
            for (int row = 0; row < secondMatrix.GetLength(0); row++)
            {
                for (int col = 0; col < secondMatrix.GetLength(1); col++)
                {
                    secondMatrix[row, col] = counter;
                    counter++;
                }
            }
            Console.WriteLine("Second Matrix : ");
            for (int i = 0; i < secondMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < secondMatrix.GetLength(1); j++)
                {
                    Console.Write($"{secondMatrix[i,j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("First Matrix :");

            for (int i = 0; i < matrix.Length; i++)
            {
                Console.WriteLine(string.Join(" ",matrix[i]));
            }

            var debugger = 0;
        }
    }
}
