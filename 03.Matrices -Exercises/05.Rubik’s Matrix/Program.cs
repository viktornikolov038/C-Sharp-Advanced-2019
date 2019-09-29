using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _05.Rubik_s_Matrix
{
    public class Program
    {
        public static void Main()
        {
            var sizesOfMatrix = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var n = int.Parse(Console.ReadLine());
            int[][] matrix = new int[sizesOfMatrix[0]][];
            var filler = 1;
            for (int row = 0; row < sizesOfMatrix[0]; row++)
            {
                matrix[row] = new int[sizesOfMatrix[1]];
                for (int col = 0; col < sizesOfMatrix[1]; col++)
                {
                    matrix[row][col] = filler;
                    filler++;
                }
            }



            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                var direction = tokens[1];


                if (direction == "left" || direction == "right")
                {
                    var currentRow = int.Parse(tokens[0]);
                    var timesToMove = int.Parse(tokens[2]) % sizesOfMatrix[1];
                    if (direction == "left")
                    {
                        for (int j = 0; j < timesToMove; j++)
                        {
                            var temp = matrix[currentRow][0];
                            for (int col = 0; col < matrix.Length - 1; col++)
                            {
                                matrix[currentRow][col] = matrix[currentRow][col + 1];
                            }
                            matrix[currentRow][sizesOfMatrix[1] - 1] = temp;
                        }
                    }
                    else if (direction == "right")
                    {
                        for (int j = 0; j < timesToMove; j++)
                        {
                            var temp = matrix[currentRow][sizesOfMatrix[1] - 1];
                            for (int col = matrix.Length - 1; col >= 1; col--)
                            {
                                matrix[currentRow][col] = matrix[currentRow][col - 1];
                            }

                            matrix[currentRow][0] = temp;
                        }
                    }
                }
                else if (direction == "up" || direction == "down")
                {
                    var currentCol = int.Parse(tokens[0]);
                    var timestoMove = int.Parse(tokens[2]) % sizesOfMatrix[0];



                    var lastNumChanged = 0;
                    if (direction == "up")
                    {

                        for (int j = 0; j < timestoMove; j++)
                        {
                            var temp = matrix[0][currentCol];
                            for (int row = 0; row < matrix.Length - 1; row++)
                            {

                                matrix[row][currentCol] = matrix[row + 1][currentCol];

                            }
                            matrix[matrix.Length - 1][currentCol] = temp;

                        }
                    }


                    else if (direction == "down")
                    {

                        for (int j = 0; j < timestoMove; j++)
                        {
                            var temp = matrix[matrix.Length - 1][currentCol];
                            for (int row = matrix.Length - 1; row >= 1; row--)
                            {
                                matrix[row][currentCol] = matrix[row - 1][currentCol];
                            }
                            matrix[0][currentCol] = temp;
                        }
                    }

                }
                //1 2 3
                //4 5 6
                //7 8 9

            }


            


            var currentIndexAsNum = 1;
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row][col] == currentIndexAsNum)
                    {
                        Console.WriteLine("No swap required");
                    }
                    else
                    {
                        var mustSwapWith = "";
                        var mustBreak = false;
                        for (int i = 0; i < matrix.Length; i++)
                        {
                            for (int j = 0; j < matrix[i].Length; j++)
                            {
                                if (matrix[i][j] == currentIndexAsNum)
                                {
                                    mustSwapWith += $"{i}, {j}";
                                    var temp = matrix[row][col];
                                    matrix[row][col] = matrix[i][j];
                                    matrix[i][j] = temp;
                                    mustBreak = true;
                                    break;
                                    
                                }
                            }
                            if (mustBreak)
                            {
                                break;;
                            }
                        }

                        Console.WriteLine($"Swap ({row}, {col}) with ({mustSwapWith})");
                    }
                    currentIndexAsNum++;
                }
            }
            
        }
    }
}
