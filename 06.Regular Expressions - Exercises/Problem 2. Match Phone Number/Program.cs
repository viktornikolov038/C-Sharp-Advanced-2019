using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_2.Match_Phone_Number
{
    public class Program
    {
        public static void Main()
        {
            var regex = new Regex(@"^\+359( |-)2\1\d{3}\1\d{4}$");
            while (true)
            {
                var inputNum = Console.ReadLine();
                if (inputNum == "end")
                {
                    break;
                }
                var match = regex.Match(inputNum);
                if (match.Success)
                {
                    Console.WriteLine(match.Value);
                }
            }
        }
    }
}
