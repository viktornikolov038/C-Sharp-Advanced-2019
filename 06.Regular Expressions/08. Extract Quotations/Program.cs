using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _08.Extract_Quotations
{
    public class Program
    {
        public static void Main()
        {
            var regex = new Regex(@"('|"")(.+?)\1");
            var text = Console.ReadLine();
            var matches = regex.Matches(text);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Groups[2]);
            }
        }
    }
}
