using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1___Plus_Remove
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<List<char>> board = new List<List<char>>();

            var lineAdder = Console.ReadLine();
            for (int row = 0; lineAdder != "END"; row++)
            {
                
                if (lineAdder == "END")
                {
                    break;
                }
                board.Add(new List<char>(lineAdder.Length));
                for (int col = 0; col < lineAdder.Length; col++)
                {
                    board[row].Add(lineAdder[col]);
                }
                lineAdder = Console.ReadLine();
            }
            var debi = 0;
        }
    }
}
