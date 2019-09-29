using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Reverse_Strings
{
    class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var result = new Stack<string>();
            foreach (var letter in input)
            {
                result.Push(letter.ToString());
                
            }

            Console.WriteLine(string.Join("",result));
            
        }
    }
}
