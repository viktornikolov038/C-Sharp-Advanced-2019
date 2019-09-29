//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Problem_1.Students_by_Group
//{
//    public class Student
//    {
//        public string FirstName { get; set; }

//        public string SecondName { get; set; }

//        public int Group { get; set; }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var final = new List<Student>();
//            while (true)
//            {
//                var inputLine = Console.ReadLine();
//                if (inputLine == "END")
//                {
//                    break;
//                }
//                var data = inputLine.Split(new []{' '},StringSplitOptions.RemoveEmptyEntries);
//                if (data.Last() == "2")
//                {
//                    final.Add(new Student()
//                    {
//                        FirstName = data[0],
//                        SecondName = data[1],
//                        Group = int.Parse(data[2])
//                    });
//                }
//            }
//            foreach (var name in final.OrderBy(a => a.FirstName))
//            {
//                Console.WriteLine($"{name.FirstName} {name.SecondName}");
//            }
//        }
//    }
//}


using System;
using System.Collections.Generic;
using System.Linq;

public static class StudentsByGroup
{
    public static void Main(string[] args)
    {
        var result = new Dictionary<string, int>();
        while (true)
        {
            var input = Console.ReadLine().Trim();

            if (input == "END")
            {
                break;
            }

            var inputTokens = input
                .Split(new char[] { }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var name = $"{inputTokens[0]} {inputTokens[1]}";
            var group = int.Parse(inputTokens[2]);

            result.Add(name, group);
        }

        foreach (var kvp in result.OrderBy(x => x.Key).Where(x => x.Value == 2))
        {
            Console.WriteLine(kvp.Key);
        }

    }
}