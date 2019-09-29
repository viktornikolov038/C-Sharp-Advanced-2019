using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.First_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split();
            var lettern = Console.ReadLine().Split().OrderBy(l => l);

            foreach (var letter in lettern)
            {
                var result = names
                    .Where(w => w.ToLower().StartsWith(letter.ToLower()))
                    .FirstOrDefault();


                if (result != null)
                {
                    Console.WriteLine(result);
                    return;
                }
            }
            Console.WriteLine("No match");
            
        }
    }
}
