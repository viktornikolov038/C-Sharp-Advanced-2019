using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1___Second_Nature_Vol._2
{
    public class Program
    {
        public static void Main()
        {
            var flowersInput = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var flowers = new Queue<int>(flowersInput);
            var bucketsInput = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var buckets = new Stack<int>(bucketsInput);

            var leftWater = 0;
            var secondNature = new List<int>();
            while (flowers.Count > 0 && buckets.Count > 0)
            {
                if (buckets.Peek() > flowers.Peek())
                {              
                    
                    leftWater = buckets.Pop() - flowers.Dequeue();
                    if (buckets.Any())
                    {
                        buckets.Push(buckets.Pop() + leftWater);
                    }
                    else
                    {
                        buckets.Push(leftWater);
                    }
                    
                }
                else if (buckets.Peek() < flowers.Peek())
                {
                    var leftInFlower = flowers.Dequeue() - buckets.Pop();
                    var flowersArray = flowers.ToList();
                    flowersArray.Insert(0,leftInFlower);
                    flowers = new Queue<int>(flowersArray);
                }
                else
                {
                    buckets.Pop();
                    
                    secondNature.Add(flowers.Dequeue());
                }
                
            }


            
            
            if (flowers.Any())
            {
                Console.WriteLine(string.Join(" ",flowers));
            }
            else
            {              
                Console.WriteLine(string.Join(" ",buckets));
            }

            if (secondNature.Any())
            {
                Console.WriteLine(string.Join(" ",secondNature));
            }
            else
            {
                Console.WriteLine("None");
            }
        }
    }
}
