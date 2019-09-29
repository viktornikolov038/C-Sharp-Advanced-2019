using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            var dust = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var water = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            var bucket = new Stack<int>(water);
            var flower = new Queue<int>(dust);
            var eternally = new Queue<int>();
            while (true)
            {
                var currentFlower = flower.Peek();
                var currentBucket = bucket.Peek();
                var diff = currentBucket - currentFlower;
                if (diff > 0)
                {
                    bucket.Pop();
                    flower.Dequeue();
                    if (bucket.Count > 0) bucket.Push(diff + bucket.Pop());
                    else bucket.Push(diff);
                }
                else if (diff == 0)
                {
                    bucket.Pop();
                    flower.Dequeue();
                    eternally.Enqueue(currentFlower);
                }
                else if (diff < 0)
                {
                    flower.Dequeue();
                    bucket.Pop();
                    var flowerArr = new int[flower.Count + 1];
                    flowerArr[0] = Math.Abs(diff);
                    for (int z = 1; z < flowerArr.Length; z++)
                    {
                        flowerArr[z] = flower.Dequeue();
                    }
                    flower = new Queue<int>(flowerArr);
                }
                if (bucket.Count == 0)
                {
                    Console.WriteLine(string.Join(" ", flower));
                    break;
                }
                else if (flower.Count == 0)
                {
                    Console.WriteLine(string.Join(" ", bucket));
                    break;
                }
            }

            if (eternally.Count != 0)
            {
                Console.WriteLine(string.Join(" ", eternally));
            }
            else if (eternally.Count == 0)
            {
                Console.WriteLine("None");
            }
        }
    }
}