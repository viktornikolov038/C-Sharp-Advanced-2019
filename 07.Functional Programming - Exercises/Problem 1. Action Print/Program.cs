using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Action_Print
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            Action<string> MyAction = s =>
                Console.WriteLine(string.Join("\n", s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray()));

            MyAction(input);
        }
    }
}
