using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Matrix_of_Palindromes
{
    public class Program
    {
        public static void Main()
        {
            var sizeOfMatrix = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            string[,] matrix = new string[sizeOfMatrix[0],sizeOfMatrix[1]];
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    var currentpalindrome = new StringBuilder();
                    currentpalindrome.Append(alphabet[row]);
                    currentpalindrome.Append(alphabet[row + col]);
                    currentpalindrome.Append(alphabet[row]);
                    matrix[row,col] = currentpalindrome.ToString();
                }
                
                
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int i = 0; i < matrix.GetLength(1); i++)
                {
                    Console.Write($"{matrix[row,i]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
