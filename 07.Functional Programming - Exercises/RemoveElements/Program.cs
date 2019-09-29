using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace RemoveElements
{
    public class Program
    {
        public static void Main()
        {
            var names = Console.ReadLine()
                .Split()
                .ToList();
            Operations(names);
        }

        private static void Operations(List<string> names)
        {
            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "Party!")
                {
                    break;
                }
                var commandParams = inputLine.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                var command = commandParams[0];
                var cases = commandParams[1];
                var delimer = commandParams[2];
                switch (command)
                {
                    case "Remove":
                        Remove(names, cases, delimer);
                        break;
                    case "Double":
                        DoubleNames(names, cases, delimer);
                        break;
                }
            }
            if (names.Any())
            {
               Console.WriteLine($"{string.Join(", ", names)} are going to the party!"); 
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            
        }

        private static List<string> DoubleNames(List<string> names, string cases, string delimer)
        {
            var modifiedAllPeople = new List<string>();
            if (cases == "StartsWith")
            {
                foreach (var name in names)
                {
                    if (name.StartsWith(delimer))
                    {
                        modifiedAllPeople.Add(name);
                        modifiedAllPeople.Add(name);
                    }
                    else
                    {
                        modifiedAllPeople.Add(name);
                    }
                }
                
            }
            else if (cases == "EndsWith")
            {
                foreach (var name in names)
                {
                    if (name.EndsWith(delimer))
                    {
                        modifiedAllPeople.Add(name);
                        modifiedAllPeople.Add(name);
                    }
                    else
                    {
                        modifiedAllPeople.Add(name);
                    }
                }
            }
            else
            {
                foreach (var name in names)
                {
                    if (name.Length == int.Parse(delimer))
                    {
                        modifiedAllPeople.Add(name);
                        modifiedAllPeople.Add(name);
                    }
                    else
                    {
                        modifiedAllPeople.Add(name);
                    }
                }
            }
            names.Clear();
            names.AddRange(modifiedAllPeople);
            return names;
        }

        private static List<string> Remove(List<string> names, string cases, string delimer)
        {
            if (cases == "StartsWith")
            {
                for (int i = 0; i < names.Count; i++)
                {
                    if (names[i].StartsWith(delimer))
                    {
                        names.Remove(names[i]);
                        i--;
                    }
                }
            }
            else if(cases == "EndsWith")
            {
                for (int i = 0; i < names.Count; i++)
                {
                    if (names[i].EndsWith(delimer))
                    {
                        names.Remove(names[i]);
                        i--;
                    }
                }
            }
            else
            {
                for (int i = 0; i < names.Count; i++)
                {
                    if (names[i].Length == int.Parse(delimer))
                    {
                        names.Remove(names[i]);
                        i--;
                    }
                }
            }
            return names;
        }
    }
}
