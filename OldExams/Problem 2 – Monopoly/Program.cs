using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2___Monopoly
{
    public class Program
    {
        public static void Main()
        {
            var sizeOfField = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var money = 50;
            var hotels = 0;
            var turns = 0;
            char[][] field = new char[sizeOfField[0]][];
            for (int row = 0; row < field.Length; row++)
            {
                field[row] = new char[sizeOfField[1]];
                var colInput = Console.ReadLine();
                for (int col = 0; col < field[row].Length; col++)
                {
                    field[row][col] = colInput[col];
                }
            }
            var changeDirection = false;
            for (int row = 0; row < field.Length; row++)
            {
                if (!changeDirection)
                {
                    for (int col = 0; col < field[row].Length; col++)
                    {
                        if (field[row][col] == 'H')
                        {

                            hotels++;
                            Console.WriteLine($"Bought a hotel for {money}. Total hotels: {hotels}.");
                            money -= money;
                        }
                        else if (field[row][col] == 'F')
                        {
                            money += hotels * 10;
                            turns++;
                            continue;
                        }
                        else if (field[row][col] == 'S')
                        {
                            var mustSpend = (row + 1) * (col + 1);
                            if (money >= mustSpend)
                            {
                                money -= mustSpend;
                                Console.WriteLine($"Spent {mustSpend} money at the shop.");
                            }
                            else
                            {
                                Console.WriteLine($"Spent {money} money at the shop.");
                                money -= money;
                            }
                        }
                        else if (field[row][col] == 'J')
                        {

                            Console.WriteLine($"Gone to jail at turn {turns}.");
                            turns += 2;
                            money += hotels * 20;

                        }
                        money += hotels * 10;
                        turns++;
                    }
                }
                else
                {
                    for (int col = field[row].Length - 1; col >= 0; col--)
                    {
                        if (field[row][col] == 'H')
                        {

                            hotels++;
                            Console.WriteLine($"Bought a hotel for {money}. Total hotels: {hotels}.");
                            money -= money;
                        }
                        else if (field[row][col] == 'F')
                        {
                            money += hotels * 10;
                            turns++;
                            continue;
                        }
                        else if (field[row][col] == 'S')
                        {
                            var mustSpend = (row + 1) * (col + 1);
                            if (money >= mustSpend)
                            {
                                money -= mustSpend;
                                Console.WriteLine($"Spent {mustSpend} money at the shop.");
                            }
                            else
                            {

                                Console.WriteLine($"Spent {money} money at the shop.");
                                money -= money;
                            }
                        }
                        else if (field[row][col] == 'J')
                        {

                            Console.WriteLine($"Gone to jail at turn {turns}.");
                            turns += 2;
                            money += hotels * 20;
                        }
                        turns++;
                        money += hotels * 10;
                    }
                }

                changeDirection = !changeDirection;

            }
            Console.WriteLine($"Turns {turns}");
            Console.WriteLine($"Money {money}");
        }
    }
}
