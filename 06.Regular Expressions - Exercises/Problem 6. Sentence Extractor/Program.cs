using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_6.Sentence_Extractor
{
    public class Program
    {
        public static void Main()
        {
            var keyWord = Console.ReadLine();
            var text = Console.ReadLine();
            var pattern = string.Format(@"[^!.?]*?\b{0}\b.*?(\!|\.|\?)", keyWord);

            var matches = Regex.Matches(text, pattern);
            foreach (Match match in matches)
            {
                Console.WriteLine(match.Groups[0]);
            }
        }
    }
}
