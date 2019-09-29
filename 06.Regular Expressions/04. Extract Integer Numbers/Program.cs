using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Extract_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"\d+";
            var regex = new Regex(pattern);
            var text = Console.ReadLine();
            var matches = regex.Matches(text);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
