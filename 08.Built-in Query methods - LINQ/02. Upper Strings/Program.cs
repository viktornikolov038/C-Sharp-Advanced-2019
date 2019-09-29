using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Upper_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine().Split();
            line
                .Select(n => n.ToUpper())
                .ToList()
                .ForEach(n => Console.Write(n + " "));
            
        }
    }
}
