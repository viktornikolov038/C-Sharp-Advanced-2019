using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Problem_1.Reverse_Numbers_with_a_Stack
{
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(new[] {' '},StringSplitOptions.RemoveEmptyEntries);
            var result = new Stack<int>();
            foreach (var num in numbers)
            {
                var currentNum = int.Parse(num);
                result.Push(currentNum);
            }

            var resultCount = result.Count;
            var resultAsString = new StringBuilder();
            for (int i = 0; i < resultCount; i++)
            {
                resultAsString.Append(result.Pop() + " ");
            }

            Console.WriteLine(resultAsString.ToString().TrimEnd());
        }
    }
}
