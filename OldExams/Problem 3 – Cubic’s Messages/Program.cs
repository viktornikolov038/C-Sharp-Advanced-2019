using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_3___Cubic_s_Messages
{
    public class Program
    {
        public static void Main()
        {
            while (true)
            {
                var encryptedInput = Console.ReadLine();
                if (encryptedInput == "Over!")
                {
                    break;
                }
                var msgLenght = int.Parse(Console.ReadLine());

                var pattern = "^([0-9]+)([a-zA-Z]+)([^A-Za-z]*?)$";

                var regex = new Regex(pattern);
                var match = regex.Match(encryptedInput);
                var numbersBefore = match.Groups[1].Value;
                var text = match.Groups[2].Value;
                var numbersAfter = match.Groups[3].Value;
                if (text.Length != msgLenght)
                {
                    continue;
                }

                var result = new StringBuilder();
                foreach (var num in numbersBefore)
                {
                    var currentNum = int.Parse(num.ToString());
                    if (currentNum <= text.Length - 1)
                    {
                        result.Append(text[currentNum]);
                    }
                    else
                    {
                        result.Append(" ");
                    }
                }

                foreach (var num in numbersAfter)
                {
                    int parsedNum;
                    var numOrNot = int.TryParse(num.ToString(), out parsedNum);
                    if (numOrNot && parsedNum <= text.Length - 1)
                    {
                        result.Append(text[parsedNum]);
                    }
                    else
                    {
                        result.Append(" ");
                    }
                }
                if (result.Length > 0)
                {
                    Console.WriteLine($"{text} == {result}");
                }

            }
        }
    }
}