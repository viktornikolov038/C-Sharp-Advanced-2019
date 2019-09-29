using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> parser = n => int.Parse(n);

            Action<int> printer = n => Console.WriteLine(n + 2);

            var numbers = Console.ReadLine()
                .Split(' ')
                .Select(parser)
                .OrderBy(a => a)
                .ToArray();
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
