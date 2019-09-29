using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Simple_Text_Editor
{
    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var result = new Stack<char>();
            for (int i = 0; i < n; i++)
            {
                var currentLine = Console.ReadLine().Split(' ');
                var command = int.Parse(currentLine[0]);
                if (command == 1)
                {
                    var currentString = currentLine[1];
                    for (int j = 0; j < currentString.Length; j++)
                    {
                        result.Push(currentString[j]);
                    }

                    
                }
                else if (command == 2)
                {
                    var count = int.Parse(currentLine[1]);
                    for (int j = 0; j < count; j++)
                    {
                        result.Pop();
                    }
                }
                else if (command == 3)
                {
                    var index = int.Parse(currentLine[1]);
                    var resultAsArray = result.Reverse().ToArray();
                             
                    Console.WriteLine(resultAsArray[index - 1]);
                }
                else if (command == 4)
                {
                    
                }              
            }
        }
    }
}
