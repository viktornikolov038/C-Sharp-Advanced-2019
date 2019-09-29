using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1___Arrange_Integers
{
    public class Program
    {
        public static void Main()
        {
            var inputNums = Console.ReadLine()
                .Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var result = new Dictionary<string, int>();
            var smallerThan10 = new Dictionary<int, string>()
            {
                [0] = "zero",
                [1] = "one",
                [2] = "two",
                [3] = "three",
                [4] = "four",
                [5] = "five",
                [6] = "six",
                [7] = "seven",
                [8] = "eight",
                [9] = "nine"
            };
            var sameCounter = 11;
            foreach (var num in inputNums)
            {
                if (num < 10)
                {
                    if (result.ContainsKey(smallerThan10[num]))
                    {
                        result.Add(smallerThan10[num] + sameCounter, num);
                        sameCounter++;
                    }
                    else
                    {
                        result.Add(smallerThan10[num], num);
                    }
                    
                }
                else
                {

                    var currentNumLenght = num.ToString().Length;
                    var currentNum = new StringBuilder();
                    for (int i = 0; i < currentNumLenght; i++)
                    {
                        var currentIndex = int.Parse(num.ToString()[i].ToString());
                        currentNum.Append(smallerThan10[currentIndex]).Append("-");
                    }
                    var doneNum = currentNum.ToString().TrimEnd('-');
                    // Console.WriteLine(doneNum);
                    if (result.ContainsKey(doneNum))
                    {
                        result.Add(doneNum + sameCounter, num);
                        sameCounter++;
                    }
                    else
                    {
                        result.Add(doneNum, num);
                    }

                }
            }

            result = result.OrderBy(a => a.Key).ToDictionary(a => a.Key, a => a.Value);
            Console.WriteLine(string.Join(", ", result.Values));
        }
    }
}
