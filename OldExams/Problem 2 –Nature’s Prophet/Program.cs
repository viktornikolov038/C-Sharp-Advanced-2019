using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2__Nature_s_Prophet
{
    public class Program
    {
        public static void Main()
        {
            var sizeOfMatrix = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[][] garden = new int[sizeOfMatrix[0]][];
            for (int row = 0; row < sizeOfMatrix[0]; row++)
            {
                garden[row] = new int[sizeOfMatrix[1]];
                for (int col = 0; col < garden[row].Length; col++)
                {
                    garden[row][col] = 0;
                }
            }
            while (true)
            {
                var commandLine = Console.ReadLine();
                if (commandLine == "Bloom Bloom Plow")
                {
                    break;                
                }
                var tokens = commandLine.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                var currentRow = int.Parse(tokens[0]);
                var currentCol = int.Parse(tokens[1]);

                for (int row = 0; row < garden.Length; row++)
                {
                    if (currentRow == row)
                    {
                        for (int col = 0; col < garden[row].Length; col++)
                        {
                            garden[row][col] += 1;                     
                        }
                    }

                    for (int col = 0; col < garden[row].Length; col++)
                    {
                        if (currentCol == col)
                        {
                            garden[row][col] += 1;
                        }
                    }                
                }
                garden[currentRow][currentCol] -= 1;
            }
            foreach (var row in garden)
            {
                Console.WriteLine(string.Join(" ",row));
            }
        }
    }
}
