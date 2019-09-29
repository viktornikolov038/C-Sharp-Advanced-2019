using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2___Cubic_s_Rube
{
    public class Program
    {
        public static void Main()
        {
            var n = long.Parse(Console.ReadLine());
            var notChanged = n * n * n;
            var result = 0l;
            while (true)
            {
                var inputCells = Console.ReadLine();
                if (inputCells == "Analyze")
                {
                    break;
                }
                var tokens = inputCells.Split().Select(long.Parse).ToArray();
                if (tokens[0] < 0 || tokens[1] < 0 || tokens[2] < 0)
                {
                    continue;
                }
                var fourthInt = tokens[3];
                if (fourthInt == 0)
                {
                    continue;
                }
                notChanged--;
                result += fourthInt;
            }
            Console.WriteLine(result);
            Console.WriteLine(notChanged);
        }

    }
}
