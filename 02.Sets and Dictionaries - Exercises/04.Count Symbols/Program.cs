using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Count_Symbols
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var result = new SortedDictionary<char,int>();
            foreach (var symbol in input)
            {
                if (!result.ContainsKey(symbol))
                {
                    result[symbol] = 0;
                }
                result[symbol]++;
            }

            foreach (var symbol in result)
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }
        }
    }
}
