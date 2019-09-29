using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Students_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Dictionary<string,int>();
            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "END")
                {
                    break;
                }
                var tokens = inputLine.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                result.Add($"{tokens[0]} {tokens[1]}",int.Parse(tokens[2]));
            }

            foreach (var student in result.Where(x => x.Value >= 18 && x.Value <= 24))
            {
                Console.WriteLine(student.Key + " " + student.Value);
            }
        }
    }
}
