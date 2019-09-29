using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_1___Regeh
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var regex = new Regex(@"\[[^\[ ]+<(\d+)(REGEH)(\d+)>[^ ]+?\]");
            //var regex = new Regex(@"(?:\b|\s)\[.+?<(\d+)(REGEH)(\d+)>\w+]");
            //var regex = new Regex(@"(?:\b|\s)\[.+?<(\d+)(REGEH)(\d+)>[^ ]+?]");
            var matches = regex.Matches(input);
            var currentIndex = 0;
            var result = new StringBuilder();
            foreach (Match match in matches)
            {
                var numberBefore = int.Parse(match.Groups[1].Value);
                var numberAfter = int.Parse(match.Groups[3].Value);

                currentIndex += numberBefore;

                if (currentIndex < input.Length)
                {
                    result.Append(input[currentIndex]);

                }
                else
                {
                    currentIndex = Math.Abs(input.Length - currentIndex - 1);
                    result.Append(input[currentIndex]);

                }

                currentIndex += numberAfter;
                if (currentIndex < input.Length)
                {
                    result.Append(input[currentIndex]);
                }
                else
                {
                    currentIndex = Math.Abs(input.Length - currentIndex - 1);
                    result.Append(input[currentIndex]);
                }
            }
            if (result.ToString().Length != 0)
            {
                Console.WriteLine(result);
            }
          
        }
    }
}
