using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Knights_of_Honor
{
    public  class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            Action<string> printSir = s =>
                Console.WriteLine(string.Join(Environment.NewLine, s
                    .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(w => "Sir " + w)));
            printSir(input);



        }
    }
}
