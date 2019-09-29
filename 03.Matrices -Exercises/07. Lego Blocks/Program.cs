using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Lego_Blocks
{
    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            int[][] firstMatrix = new int[n][];
            int[][] secondMatrix = new int[n][];
            int[][] resultMatrix = new int[n][];
            for (int row = 0; row < firstMatrix.Length; row++)
            {
                firstMatrix[row] = Console.ReadLine()
                    .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }

            for (int row = 0; row < secondMatrix.Length; row++)
            {
                secondMatrix[row] = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }

            for (int row = 0; row < secondMatrix.Length; row++)
            {
                secondMatrix[row] = secondMatrix[row].Reverse().ToArray();
            }

            for (int row = 0; row < resultMatrix.Length; row++)
            {
                resultMatrix[row] = firstMatrix[row].Concat(secondMatrix[row]).ToArray();
            }
            var isMatched = true;
            for (int row = 0; row < resultMatrix.Length - 1; row++)
            {
                if (resultMatrix[row].Length != resultMatrix[row + 1].Length)
                {
                    isMatched = false;
                    break;
                    
                }
            }
            var totalElements = 0;
            for (int row = 0; row < resultMatrix.Length; row++)
            {
                totalElements += resultMatrix[row].Length;
            }
            if (!isMatched)
            {
                Console.WriteLine($"The total number of cells is: {totalElements}");
            }
            else
            {
                for (int row = 0; row < resultMatrix.Length; row++)
                {
                    Console.WriteLine($"[{string.Join(", ",resultMatrix[row])}]");
                }
            }
        }
    }
}
