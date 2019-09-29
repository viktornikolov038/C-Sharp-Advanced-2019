using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.Extract_Tags
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"<.+?>";
            var regex = new Regex(pattern);
            var fullInput = new StringBuilder();
            
            while (true)
            {
                var text = Console.ReadLine();
                if (text == "END")
                {
                    break;
                }
                fullInput.Append(text);

            }
            var matches = regex.Matches(fullInput.ToString());
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
