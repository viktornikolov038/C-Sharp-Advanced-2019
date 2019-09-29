using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_14.Letters_Change_Numbers
{
    public class Program
    {
        public static void Main()
        {
            var data = Console.ReadLine().Split(new[] {' ','\t','\r'}, StringSplitOptions.RemoveEmptyEntries);
            var sum = 0.0;
            foreach (var token in data)
            {
                var firstLetter = token[0];
                var lastLetter = token[token.Length - 1];
                var numAsStr = "";
                for (int i = 1; i < token.Length - 1; i++)
                {
                    numAsStr += token[i];
                }
                var num = double.Parse(numAsStr);
                Console.WriteLine(num);
                if (char.IsUpper(firstLetter))
                {
                    num /= (char)firstLetter - 64;
                    
                }
                else
                {
                    num *= (char) firstLetter - 96;
                }
                
                if (char.IsUpper(lastLetter))
                {
                    num -= (char) lastLetter - 64;
                }
                else
                {
                    num += (char) lastLetter - 96;
                }

                sum += num;
            }

            Console.WriteLine(sum.ToString("F2"));
        }
    }
}
