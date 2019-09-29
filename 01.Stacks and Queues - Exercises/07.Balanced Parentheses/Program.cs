using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Balanced_Parentheses
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            char[] allowedSymbols = { '{', '}', '(', ')', '[', ']' };
            var middle = input.Length / 2;
            var stack = new Stack<char>();
            var queue = new Queue<char>();
            for (int i = 0; i < input.Length; i++)
            {
                if (!allowedSymbols.Contains(input[i]))
                {
                    Console.WriteLine("NO");
                    break;
                }

                if (i < middle)
                {
                    queue.Enqueue(input[i]);
                }
                else
                {
                    stack.Push(input[i]);
                }
                
            }

            var stackAsArray = stack.ToArray();
            var queueAsArray = queue.ToArray();

            var isSame = false;
            for (int i = 0; i < middle; i++)
            {
                if ((int)stackAsArray[i] == (int)queueAsArray[i] + 2)
                {
                    
                    isSame = true;
                    continue;
                }
                if (stackAsArray[i] == ')')
                {
                    if (queueAsArray[i] == '(')
                    {
                        
                        isSame = true;
                        continue;
                    }
                }

                Console.WriteLine("NO");
                return;
            }

            Console.WriteLine("YES");
        }
    }
}
