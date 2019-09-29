using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_10.Unicode_Characters
{
    public class Program
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            var sb = new StringBuilder();
            foreach (var symbol in text)
            {
                sb.Append("\\u" + ((int)symbol).ToString("X").PadLeft(4, '0').ToLower());

            }
            Console.WriteLine(sb);
        }
    }
}
