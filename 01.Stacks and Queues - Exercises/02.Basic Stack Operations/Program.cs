using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Basic_Stack_Operations
{
    public class Program
    {
        public static void Main()
        {
            var tokens = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var numbersInput = Console.ReadLine().Split(new[] {' '},StringSplitOptions.RemoveEmptyEntries);
            var numbers = new Stack<int>();
            

            var N = int.Parse(tokens[0]);
            var S = int.Parse(tokens[1]);
            var X = int.Parse(tokens[2]);
            for (int i = 0; i < N; i++)
            {
                var currentNum = int.Parse(numbersInput[i]);
                numbers.Push(currentNum);
            }
            for (int i = 0; i < S; i++)
            {
                numbers.Pop();
            }
            if (numbers.Count > 0)
            {
                var hasX = numbers.Contains(X);
                if (hasX)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(numbers.ToArray().Min());
                }
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
