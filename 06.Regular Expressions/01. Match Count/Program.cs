using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Match_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = Console.ReadLine();
            var regex = new Regex(pattern);
            var text = Console.ReadLine();
            var matches = regex.Matches(text);
            Console.WriteLine(matches.Count);
        }
    }
}
