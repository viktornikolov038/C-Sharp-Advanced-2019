using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Students_by_First_and_Last_Name
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new List<string[]>();
            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "END")
                {
                    break;
                }
                var data = inputLine.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                result.Add(data);             
            }
            foreach (var name in result.Where(x => String.Compare(x[0],x[1]) < 0))
            {
                Console.WriteLine(string.Join(" ",name));
            }
        }
    }
}
