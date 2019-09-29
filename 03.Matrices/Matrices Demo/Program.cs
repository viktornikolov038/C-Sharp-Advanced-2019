using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices_Demo
{
    public class Program
    {
        public static void Main()
        {
            /*int[,] matrix = new int[3,3];*/ //only in c#

            
            //var counter = 0;
            //for (int row = 0; row < matrix.GetLength(0); row++)
            //{
            //    for (int col = 0; col < matrix.GetLength(1); col++)
            //    {
            //        matrix[row, col] = counter;
            //        counter++;
            //    }
            //}

            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        Console.Write($"{matrix[i,j]} ");
            //    }
            //    Console.WriteLine();
            //}

            int[][] matrix1 = new int[5][];
            var counter = 0;
            for (int rowIndex = 0; rowIndex < matrix1.Length; rowIndex++)
            {
                
                matrix1[rowIndex] = new int[rowIndex];
               
            }


            for (int rowIndex = 0; rowIndex < matrix1.Length; rowIndex++)
            {
                Console.WriteLine(string.Join(" ",matrix1[rowIndex]));
            }

            var debbuger = 1;
        }
    }
}
