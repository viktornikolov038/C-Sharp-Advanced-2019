using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = new int[3][];
            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix.Length; col++)
                {
                Console.WriteLine(matrix[row][col]);

                }

            }
        }
        
    }
}
