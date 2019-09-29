using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Add_VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            input
                .Split(new []{", "},StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .Select(n => n = n * 1.2)
                
                .ToList()
                .ForEach(n => Console.WriteLine($"{n:f2}"));
            
        }
    }
}
