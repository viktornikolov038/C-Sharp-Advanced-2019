using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1___Collect_Resources
{
    public class Program
    {
        private static bool IsValid(string currentElement)
        {
            var spitedElement = currentElement.Split('_');
            var elementName = spitedElement[0];
            if (elementName != "stone" && elementName != "gold" && elementName != "wood" && elementName != "food")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static void Main()
        {
            var result = 0;
            var field = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var n = int.Parse(Console.ReadLine());
            var allResults = new List<int>();
            for (int i = 0; i < n; i++)
            {
                var startAndStep = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                var startIndex = startAndStep[0];
                var Step = startAndStep[1];
                var collectedIndexes = new List<int>();
                
                for (int j = startIndex; j < field.Length; j+= Step)
                {
                    if (collectedIndexes.Contains(j))
                    {
                        break;
                    }
                    if (IsValid(field[j]))
                    {
                        var spitedElement = SplitCurrentElement(field[j]);
                        var elementValue = 0;
                        if (spitedElement.Length == 2)
                        {
                            elementValue = int.Parse(spitedElement[1]);
                        }
                        else
                        {
                            elementValue = 1;
                        }
                        
                        result += elementValue;
                        collectedIndexes.Add(j);
                    }
                    if (j + Step >= field.Length)
                    {
                        j = j + Step - field.Length - Step;
                    }

                }
                
                allResults.Add(result);
                result = 0;
            }
            
            Console.WriteLine(allResults.Max());
        }

        private static string[] SplitCurrentElement(string currentElement)
        {
            return currentElement.Split('_');
        }
    }
}
