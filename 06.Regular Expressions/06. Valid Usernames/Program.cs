using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"^[\w-]{3,16}$";
            var regex = new Regex(pattern);
            while (true)
            {
                var line = Console.ReadLine();
                if (line == "END")
                {
                    break;
                }
                var currentMatch = regex.Match(line);
                if (currentMatch.Success)
                {
                    Console.WriteLine("valid");
                }
                else
                {
                    Console.WriteLine("invalid");
                }
            }
        }
    }
}
