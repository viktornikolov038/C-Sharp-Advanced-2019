using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_6.Count_Substring_Occurrences
{
    public class Program
    {
        public static void Main()
        {
            var text = Console.ReadLine().ToLower();
            var pattern = Console.ReadLine().ToLower();
            var index = text.IndexOf(pattern);
            var count = 0;
            while (index != -1)
            {
                count++;
                index = text.IndexOf(pattern,index + 1);
            }
            Console.WriteLine(count);
        }
    }
}
