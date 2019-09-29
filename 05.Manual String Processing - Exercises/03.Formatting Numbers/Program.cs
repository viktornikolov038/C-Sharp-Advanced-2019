using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Formatting_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var tokens = Console.ReadLine().Split(new []{' ', '\t','\r' },StringSplitOptions.RemoveEmptyEntries);
            var a = int.Parse(tokens[0]).ToString("X");
            var b = double.Parse(tokens[1]);
            var c = double.Parse(tokens[2]);

            var abin = Convert.ToString(int.Parse(tokens[0]), 2).PadLeft(10, '0');
            if (abin.Length > 10)
            {
                abin = abin.Substring(0,10);
            }
            Console.Write("|{0,-10}|",a);
            Console.Write(abin);
            Console.Write("|{0,10:F2}", b);
            Console.Write("|{0,-10:F3}|", c);
        }
    }
}
