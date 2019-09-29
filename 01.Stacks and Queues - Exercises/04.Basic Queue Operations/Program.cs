using System;
using System.Collections.Generic;
using System.Linq;
namespace _04.Basic_Queue_Operations
{
    public class Program
    {
        public static void Main()
        {
            var tokens = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var N = tokens[0];
            var S = tokens[1];
            var X = tokens[2];

            var numbers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var queueOfNums = new Queue<int>();
            for (int i = 0; i < N; i++)
            {
                var currentNum = int.Parse(numbers[i]);
                queueOfNums.Enqueue(currentNum);
            }

            for (int i = 0; i < S; i++)
            {
                queueOfNums.Dequeue();
            }

            if (queueOfNums.Any())
            {
                if (queueOfNums.Contains(X))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(queueOfNums.ToArray().Min());
                }
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
