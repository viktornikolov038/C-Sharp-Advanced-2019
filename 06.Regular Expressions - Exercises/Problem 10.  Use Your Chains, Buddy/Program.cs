using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Problem_10.Use_Your_Chains__Buddy
{
    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var regex = new Regex(@"<p>(.*?)</p>");
            var matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                var whiteSpaces = @"[^a-z0-9]+";
                var reminder = match.Groups[1].Value;
                var replaced = Regex.Replace(reminder, whiteSpaces, " ");

                var sb = new StringBuilder();
                foreach (var character in replaced)
                {
                    if (character >= 'a' && character <= 'm')
                    {
                        sb.Append((char)((int)character + 13));
                    }
                    else if (character > 'm' && character <= 'z')
                    {
                        sb.Append((char)((int)character - 13));
                    }
                    else
                    {
                        sb.Append(character);
                    }
                }

                Console.Write(sb);
            }
        }
    }
}