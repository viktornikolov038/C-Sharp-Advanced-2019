using System;
using System.Collections.Generic;
using System.Linq;

public static class PredicateParty
{
    public static void Main()
    {
        var allPeople = Console.ReadLine()
            .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        CommandReader(allPeople);
        if (allPeople.Count == 0)
        {
            Console.WriteLine($"Nobody is going to the party!");
        }
        else
        {
            Console.WriteLine($"{string.Join(", ", allPeople)} are going to the party!");
        }
    }

    public static List<string> CommandReader(List<string> allPeople)
    {
        while (true)
        {
            var input = Console.ReadLine();

            if (input == "Party!")
            {
                break;
            }

            var tokens = input
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var doubleOrRemove = tokens[0];
            var command = tokens[1];
            var dimension = tokens[2];

            switch (doubleOrRemove)
            {
                case "Double":
                    Double(allPeople, command, dimension);
                    break;

                case "Remove":
                    Remove(allPeople, command, dimension);
                    break;
            }
        }

        return allPeople;
    }

    public static void Remove(List<string> allPeople, string command, string dimensions)
    {
        switch (command)
        {
            case "StartsWith":
                allPeople.RemoveAll(x => x.StartsWith(dimensions));
                break;

            case "EndsWith":
                allPeople.RemoveAll(x => x.EndsWith(dimensions));
                break;

            case "Length":
                allPeople.RemoveAll(x => x.Length == int.Parse(dimensions));
                break;
        }
    }

    public static void Double(List<string> allPeople, string command, string dimensions)
    {
        var modifiedAllPeople = new List<string>();
        switch (command)
        {
            case "StartsWith":
                foreach (var name in allPeople)
                {
                    if (name.StartsWith(dimensions))
                    {
                        modifiedAllPeople.Add(name);
                        modifiedAllPeople.Add(name);
                    }
                    else
                    {
                        modifiedAllPeople.Add(name);
                    }
                }
                break;

            case "EndsWith":
                foreach (var name in allPeople)
                {
                    if (name.EndsWith(dimensions))
                    {
                        modifiedAllPeople.Add(name);
                        modifiedAllPeople.Add(name);
                    }
                    else
                    {
                        modifiedAllPeople.Add(name);
                    }
                }
                break;

            case "Length":
                foreach (var name in allPeople)
                {
                    if (name.Length == int.Parse(dimensions))
                    {
                        modifiedAllPeople.Add(name);
                        modifiedAllPeople.Add(name);
                    }
                    else
                    {
                        modifiedAllPeople.Add(name);
                    }
                }
                break;
        }
        allPeople.Clear();
        allPeople.AddRange(modifiedAllPeople);
    }
}