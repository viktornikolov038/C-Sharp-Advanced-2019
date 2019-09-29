using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Applied_Arithmetics
{
    public class Program
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            while (true)
            {
                var command = Console.ReadLine();
                if (command == "end")
                {
                    break;   
                }
                if (command == "add")
                {
                    numbers = numbers.Select(n => n + 1).ToArray();
                }else if (command == "multiply")
                {
                    numbers = numbers.Select(n => n * 2).ToArray();
                }else if (command == "subtract")
                {
                    numbers = numbers.Select(n => n - 1).ToArray();
                }else if (command == "print")
                {
                    Console.WriteLine(string.Join(" ", numbers));
                }
            }
            
        }
    }
}
