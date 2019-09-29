using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2___Jedi_Galaxy
{
    public class Program
    {
        public static void Main()
        {
            var sizeOfMatrix = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var matrix = new int[sizeOfMatrix[0]][];
            matrix = BuildMatrix(matrix, sizeOfMatrix[1]);
            
            var jedi = Console.ReadLine();
            var JediStartIndex = new int[2];
            var EvilStartIndex = new int[2];
            var result = 0;
            while (jedi != "Let the Force be with you")
            {

                JediStartIndex = jedi
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                EvilStartIndex = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
                jedi = Console.ReadLine();

                var evilRow = EvilStartIndex[0];
                var evilCol = EvilStartIndex[1];
                var JediRow = JediStartIndex[0];
                var JediCol = JediStartIndex[1];
                //dark side
                var rows = sizeOfMatrix[0];
                var cols = sizeOfMatrix[1];
                if (evilRow >= rows)
                {
                    int shiftValue = evilRow - rows + 1;
                    evilRow -= shiftValue;
                    evilCol -= shiftValue;
                }

                if (evilCol >= cols)
                {
                    int shiftValue = evilCol - cols + 1;
                    evilRow -= shiftValue;
                    evilCol -= shiftValue;
                }


                while (evilRow >= 0 && evilCol >= 0)
                {
                    matrix[evilRow][evilCol] = 0;
                    evilRow--;
                    evilCol--;
                }

                if (JediRow >= rows)
                {
                    int shiftedValue = JediRow - rows + 1;
                    JediRow -= shiftedValue;
                    JediCol += shiftedValue;
                }
                if (JediCol < 0)
                {
                    int shiftValue = Math.Abs(JediCol);
                    JediRow -= shiftValue;
                    JediCol += shiftValue;
                }
                
                while (JediRow >= 0 && JediCol < cols)
                {
                    result += matrix[JediRow][JediCol];
                    JediRow--;
                    JediCol++;
                }
            }
            Console.WriteLine(result);
        }

        private static int[][] BuildMatrix(int[][] matrix,int colsAdder)
        {
            var counter = 0;
            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = new int[colsAdder];
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    matrix[row][col] = counter;
                    counter++;
                }
            }
            return matrix;
        }
    }
}
