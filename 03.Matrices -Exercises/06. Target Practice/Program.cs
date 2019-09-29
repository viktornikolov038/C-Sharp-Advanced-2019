using System;

class FillMatrix
{
    static void Main(string[] args)
    {
        var entry = Console.ReadLine().Split(new char[] { ',', ';', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var rows = int.Parse(entry[0]);
        var cols = int.Parse(entry[1]);
        int[,] matrix = new int[rows, cols];
        var text = Console.ReadLine();
        var number = 0;
        var changeDirection = true;
        for (int row = rows - 1; row >= 0; row--)
        {
            if (!changeDirection)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = text[number % text.Length];
                    number++;
                }
            }
            else
            {
                for (int col = cols - 1; col >= 0; col--)
                {
                    matrix[row, col] = text[number % text.Length];
                    number++;
                }
            }
            changeDirection = !changeDirection;
        }
        entry = Console.ReadLine().Split(new char[] { ',', ';', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        var rowC = int.Parse(entry[0]);
        var colC = int.Parse(entry[1]);
        var r = int.Parse(entry[2]);
        int rCheck = r * r;
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                bool inCircle = ((row - rowC) * (row - rowC) + (col - colC) * (col - colC) <= rCheck);
                if (inCircle)
                {
                    matrix[row, col] = ' ';
                }
            }
        }
        for (int col = 0; col < cols; col++)
        {
            for (int row = rows - 1; row > 0; row--)
            {
                if (matrix[row, col] == ' ')
                {
                    for (int j = row - 1; j >= 0; j--)
                    {
                        if (matrix[j, col] != ' ')
                        {
                            matrix[row, col] = matrix[j, col];
                            matrix[j, col] = ' ';
                            break;
                        }
                    }
                }
            }
        }
        PrintMatrix(rows, cols, matrix);
    }

    private static void PrintMatrix(int rows, int cols, int[,] matrix)
    {
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write((char)matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}