using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_9.Text_Filter
{
    public class Program
    {
        public static void Main()
        {
            var patterns = Console.ReadLine().Split(new[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);
            var text = Console.ReadLine();
            for (int i = 0; i < patterns.Length; i++)
            {
                var currentPattern = patterns[i];
                text = text.Replace(currentPattern,new string('*',currentPattern.Length));
            }

            Console.WriteLine(text);
        }
    }
}
