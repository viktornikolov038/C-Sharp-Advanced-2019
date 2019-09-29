using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Students_Enrolled_in_2014_or_2015
{
    public class Program
    {
        public static void Main()
        {
            var result = new Dictionary<string, List<int>>();
            while (true)
            {

                var line = Console.ReadLine();
                if (line == "END")
                {
                    break;
                }
                var data = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var facultyNum = data[0];
                var grades = data.Skip(1).Select(int.Parse).ToList();
                result.Add(facultyNum, grades);
            }

            foreach (var student in result.Where(x => string.Join("", x.Key.Reverse().Take(2)) == "41" ||
                                                      string.Join("", x.Key.Reverse().Take(2)) == "51"))
            {
                Console.WriteLine(string.Join(" ", student.Value));
            }


        }
    }
}

