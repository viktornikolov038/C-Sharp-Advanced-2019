using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_11.Palindromes
{
    public class Program
    {
        public static void Main()
        {
            var text = Console.ReadLine();
            
            var words = text.Split(new[] { ' ', ',', '.', '?', '!','\t','\r'}, StringSplitOptions.RemoveEmptyEntries);
            var palindromes = new List<string>();
            foreach (var word in words)
            {
                var reversed = new string(word.Reverse().ToArray());
                if (word == reversed)
                {
                    palindromes.Add(word);
                }

            }
            palindromes.Sort();
            Console.WriteLine($"[{string.Join(", ", palindromes)}]");
        }

    }
}

