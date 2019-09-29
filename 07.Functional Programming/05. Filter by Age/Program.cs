using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Filter_by_Age
{
    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var people = new Dictionary<string,int>();
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine()
                    .Split(new[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                people.Add(line[0],int.Parse(line[1]));
            }
            var condition = Console.ReadLine();
            var age = int.Parse(Console.ReadLine());
            var format = Console.ReadLine();

            Func<int,bool> tester = CreateTester(condition, age);
            Action < KeyValuePair<string, int> > printer = CreatePrinter(format);
            IncokePrinter(people, tester, printer);

        }

        private static void IncokePrinter(Dictionary<string, int> people, Func<int, bool> tester,
            Action<KeyValuePair<string, int>> printer)
        {
            foreach (var person in people)
            {
                if (tester(person.Value))
                {
                    printer(person);
                }
            }
        }

        private static Action<KeyValuePair<string,int>> CreatePrinter(string format)
        {
            switch (format)
            {
                case "name age":
                    return person => Console.WriteLine($"{person.Key} - {person.Value}");
                case "name":
                    return person => Console.WriteLine($"{person.Key}");
                case "age":
                    return person => Console.WriteLine($"{person.Value}");
                default:
                    return null;

            }
            
        }

        private static Func<int, bool> CreateTester(string condition, int age)
        {
            if (condition == "older")
            {
                return n => n >= age;
            }
            else
            {
                return n => n < age;
            }
        }
    }
}
