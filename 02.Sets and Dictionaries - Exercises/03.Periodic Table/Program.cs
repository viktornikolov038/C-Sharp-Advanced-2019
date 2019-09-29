using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Periodic_Table
{
    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var set = new SortedSet<string>();
            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split(' ');
                if (tokens.Length != 1)
                {
                    for (int j = 0; j < tokens.Length; j++)
                    {
                        set.Add(tokens[j]);
                    }
                }
                else
                {
                    set.Add(tokens[0]);
                }
            }
            Console.WriteLine(string.Join(" ",set));
        }
    }
}
