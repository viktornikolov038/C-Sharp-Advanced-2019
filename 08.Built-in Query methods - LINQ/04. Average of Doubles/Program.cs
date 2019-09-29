using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Average_of_Doubles
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine();
            Console.WriteLine("{0:f2}",numbers.Split(' ').Select(double.Parse).Average());
        }
    }
}
