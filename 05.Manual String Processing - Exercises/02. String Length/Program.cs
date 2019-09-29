using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.String_Length
{
    class Program
    {
        static void Main()
        {
            var text = Console.ReadLine();
            if (text.Length < 20)
            {
                text = text.PadRight(20, '*');
                Console.WriteLine(text);
            }
            else
            {
                Console.WriteLine(text.Substring(0,20));

            }
        }
    }
}
