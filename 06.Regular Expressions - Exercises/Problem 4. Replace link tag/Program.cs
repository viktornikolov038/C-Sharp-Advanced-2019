using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ReplaceATag
{
    class ReplaceATag
    {
        static void Main()
        {
            string text = Console.ReadLine();
            var regex = new Regex(@"(.*)<a(.*>.+)<\/a>(.*)");
            while (text != "end")
            {
                var match = regex.Match(text);
                if (match.Success)
                {
                    var beforeTag = match.Groups[1];
                    var inTag = match.Groups[2].Value;
                    inTag = inTag.Replace(">", "]");
                    var afterTag = match.Groups[3];
                    var done = beforeTag.Value + "[URL" + inTag + "[/URL]" + afterTag;
                    Console.WriteLine(done);
                }
                else
                {
                    Console.WriteLine(text);
                }
                text = Console.ReadLine();
            }
        }
    }
}