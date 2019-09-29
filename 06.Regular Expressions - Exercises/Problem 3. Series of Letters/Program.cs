using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_3.Series_of_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            var regex = new Regex(@"(\w)\1+");
            
          
            Console.WriteLine(Regex.Replace(str, @"(\w)\1+", "$1"));
        }
    }
}
