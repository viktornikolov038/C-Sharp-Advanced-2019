using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Simple_Calculator
{
    class Program
    {
        public static void Main()
        {
            var reminder = Console.ReadLine().Split(' ');
            var stack = new Stack<string>(reminder.Reverse());
            
            while (stack.Count > 1)
            {
                var firstNum = int.Parse(stack.Pop());
                var op = stack.Pop();
                var seconNum = int.Parse(stack.Pop());
                if (op == "+")
                {
                    stack.Push((firstNum + seconNum).ToString());
                }
                else if(op == "-")
                {
                    stack.Push((firstNum - seconNum).ToString());
                }
            }

            Console.WriteLine(stack.Pop());
        
        }
    }
}
