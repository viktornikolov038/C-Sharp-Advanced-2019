using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Unique_Usernames
{
    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var result = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {            
                var name = Console.ReadLine();
                result.Add(name);
            }

            foreach (var name in result)
            {
                Console.WriteLine(name);
            }
        }
    }
}
