using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Concatenate_Strings
{
    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var result = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                
                result.Append(Console.ReadLine()).Append(" ");
            }
            Console.WriteLine(result.ToString().TrimEnd());
        }
    }
}
