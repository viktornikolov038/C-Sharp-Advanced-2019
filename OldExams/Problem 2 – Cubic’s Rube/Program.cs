using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2___Cubic_s_Rube
{
    public class Program
    {
        public static void Main()
        {
            var n = long.Parse(Console.ReadLine());
            long[][][] matrix = new long[n][][];
            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = new long[n][];
                for (int cel = 0; cel < matrix[row].Length; cel++)
                {
                    matrix[row][cel] = new long[n];
                }
            }

            while (true)
            {
                var inputCell = Console.ReadLine();
                if (inputCell == "Analyze")
                {
                    break;
                }

                var cellData = inputCell.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                if (cellData[0] < 0 || cellData[1] < 0 || cellData[2] < 0)
                {
                    continue;

                }
                var particles = cellData[3];
                matrix[cellData[0]][cellData[1]][cellData[2]] = particles;
            }

            var sum = 0l;
            var notChanged = 0l;
            for (int row = 0; row < matrix.Length; row++)
            {

                for (int cel = 0; cel < matrix[row].Length; cel++)
                {
                    for (int kit = 0; kit < matrix[row][cel].Length; kit++)
                    {
                        sum += matrix[row][cel][kit];
                        if (matrix[row][cel][kit] == 0)
                        {
                            notChanged++;
                        }
                    }
                }
            }


            Console.WriteLine(sum);
            Console.WriteLine(notChanged);
        }
    }
}
