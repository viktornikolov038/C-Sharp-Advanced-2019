using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_1.Match_Full_Name
{
    public class Program
    {
        public static void Main()
        {
            var regex = new Regex(@"\b[A-Z][a-z]+ [A-Z][a-z]+\b");
            var inputName = Console.ReadLine();
            while (inputName != "end")
            {
                var match = regex.Match(inputName);
                if (match.Success)
                {
                    Console.WriteLine(match.Value);
                }
                inputName = Console.ReadLine();
            }
        }
    }
}
