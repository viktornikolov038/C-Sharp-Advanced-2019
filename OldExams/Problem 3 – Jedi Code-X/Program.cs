using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_3___Jedi_Code_X
{
    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                var inputLine = Console.ReadLine();
                sb.Append(inputLine);
            }
            var namePattern = Console.ReadLine();
            var fullNamePattern = "([a-zA-Z]{})(?![a-zA-Z])";
            fullNamePattern = fullNamePattern.Insert(0, namePattern);
            fullNamePattern = fullNamePattern.Insert(10 + namePattern.Length, namePattern.Length.ToString());
            var nameRegex = new Regex(fullNamePattern);
            var matches = nameRegex.Matches(sb.ToString());
            var names = new List<string>();
            foreach (Match match in matches)
            {
                names.Add(match.Groups[1].Value);
                
            }

            var msgPattern = Console.ReadLine();
            var fullMsgPattern = "([a-zA-Z0-9]{})(?![a-zA-Z0-9])";
            fullMsgPattern = fullMsgPattern.Insert(0, msgPattern);
            fullMsgPattern = fullMsgPattern.Insert(13 + msgPattern.Length, msgPattern.Length.ToString());
            var msgRegex = new Regex(fullMsgPattern);
            var msgMatches = msgRegex.Matches(sb.ToString());
            var msg = new List<string>();
            foreach (Match msgMatch in msgMatches)
            {
                msg.Add(msgMatch.Groups[1].Value);
            }

            var msgIndexes = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var count = Math.Min(msgIndexes.Length, names.Count);
            for (int i = 0; i < count; i++)
            {
                if (msgIndexes[i] <= msg.Count)
                {
                    Console.WriteLine($"{names[i]} - {msg[msgIndexes[i] - 1]}");
                }
                else
                {
                    while (msgIndexes[i] >= 0)
                    {
                        if (msgIndexes[i] <= msg.Count)
                        {
                            Console.WriteLine($"{names[i]} - {msg[msgIndexes[i] - 1]}");
                            break;
                        }
                        else
                        {
                            msgIndexes[i]--;
                        }

                    }
                }
            }
        }
    }
}
