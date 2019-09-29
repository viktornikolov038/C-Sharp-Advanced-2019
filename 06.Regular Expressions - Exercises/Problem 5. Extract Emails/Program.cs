using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_5.Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"^([a-zA-Z0-9][\w\.-]+\w)@[a-zA-Z][a-zA-Z-]+[a-zA-Z](\.[a-zA-Z]+)(\.[a-zA-Z]+|)*$";
            var regex = new Regex(pattern);
            var text = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            foreach (var word in text)
            {
                var email = "";
                if (word[word.Length - 1] == '.')
                {
                    email = word.Remove(word.Length - 1);
                }
                else
                {
                    email = word;
                }
                var match = regex.Match(email);
                if (match.Success)
                {
                    Console.WriteLine(match);
                }
            }
        }
    }
}
