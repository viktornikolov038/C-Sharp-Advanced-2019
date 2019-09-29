using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Maximum_Element
{
    class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var numbers = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                var currentInput = Console.ReadLine()
                    .Split(' ')
                    .Select(int.Parse)
                    .ToArray();

                if (currentInput[0] == 1)
                {
                    numbers.Push(currentInput[1]);
                }
                else if (currentInput[0] == 2 && numbers.Any())
                {
                    numbers.Pop();
                }
                else if (currentInput[0] == 3 && numbers.Any())
                {
                    var maxNum = int.MinValue;
                    foreach (var num in numbers)
                    {
                        if (maxNum < num)
                        {
                            maxNum = num;
                        }
                    }
                    Console.WriteLine(maxNum);
                }
            }
        }
    }
}
