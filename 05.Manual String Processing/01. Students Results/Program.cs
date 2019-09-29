using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Students_Results
{
    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            //var result = new Dictionary<string,List<int>>();
            Console.WriteLine("Name      |   CAdv|   COOP| AdvOOP|Average|");
            for (int i = 0; i < n; i++)
            {
                var data = Console.ReadLine().Split('-');
                var name = data[0];
                var grades = data[1].Split(new[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(double.Parse)
                    .ToArray();
                var firstGrade = grades[0];
                
                var secondGrade = grades[1];
                var thirdGrade = grades[2];
                var avg = (firstGrade + secondGrade + thirdGrade) / 3.0;
                Console.WriteLine(string.Format("{0,-10}|{1,7:f2}|{2,7:f2}|{3,7:f2}|{4,7:f4}|",
                    name,firstGrade,secondGrade,thirdGrade,avg));
            }
        }
    }
}
