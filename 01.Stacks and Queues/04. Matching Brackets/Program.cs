using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Matching_Brackets
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var stack = new Stack<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '(')
                {
                    stack.Push(i);
                }

                if (input[i] == ')')
                {
                    var startIndex = stack.Pop();
                    var reminder = input.Substring(startIndex, i - startIndex + 1);
                    Console.WriteLine(reminder);    
                }
            }

        }
    }
}
