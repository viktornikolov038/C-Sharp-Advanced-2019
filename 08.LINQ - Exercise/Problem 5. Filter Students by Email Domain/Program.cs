using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5.Filter_Students_by_Email_Domain
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Dictionary<string, string>();
            while (true)
            {
                var line = Console.ReadLine();
                if (line == "END")
                {
                    break;
                }
                var data = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                result.Add($"{data[0]} {data[1]}", data[2]);
            }

            foreach (var students in result.Where(x => x.Value.EndsWith("@gmail.com")))
            {
                Console.WriteLine(students.Key);
            }
        }
    }
}
