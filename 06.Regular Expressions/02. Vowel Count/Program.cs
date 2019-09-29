using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Vowel_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var pattern = @"[aeiouyAEIOUY]";
            var regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);
            Console.WriteLine("Vowels: {0}",matches.Count);
        }
    }
}
