using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._2x2_Squares_in_Matrix
{
    public class Program
    {
        public static void Main()
        {
            var sizeOfMatrix = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            
            string[][] matrix = new String[sizeOfMatrix[0]][];
            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            }
            var counter = 0;
            for (int row = 0; row < matrix.Length  - 1; row++)
            {
                for (int col = 0; col < matrix[row].Length - 1; col++)
                {
                    if (matrix[row][col] == matrix[row][col + 1] && matrix[row][col] == matrix[row + 1][col + 1] &&
                        matrix[row][col] == matrix[row + 1][col])
                    {
                        
                            counter++;
                        
                    }
                }
            }
            Console.WriteLine(counter);
        }
    }
}
