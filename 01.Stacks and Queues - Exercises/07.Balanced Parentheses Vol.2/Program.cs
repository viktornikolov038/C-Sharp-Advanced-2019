using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Balanced_Parentheses_Vol._2
{
    public class Program
    {
        public static void Main()
        {
            var paranthesisInput = Console.ReadLine();

            var opendedSymbols = new Stack<char>();

            char[] allowedSymbols = new[] { '(', ')', '[', ']', '{', '}' };
            char[] allowedOpenedSybols = new[] { '(', '[', '{' };

            var missMatch = false;
            for (int i = 0; i < paranthesisInput.Length; i++)
            {
                if (!allowedSymbols.Contains(paranthesisInput[i]))
                {
                    Console.WriteLine("NO");
                    return;
                }
                if (allowedOpenedSybols.Contains(paranthesisInput[i]))
                {
                    opendedSymbols.Push(paranthesisInput[i]);
                }
                else
                {
                    if (!opendedSymbols.Any())
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                    switch (paranthesisInput[i])
                    {
                        case '}':
                            if (opendedSymbols.Pop() != '{')
                            {
                                Console.WriteLine("NO");
                                return;

                            }
                            break;
                        case ']':
                            if (opendedSymbols.Pop() != '[')
                            {
                                Console.WriteLine("NO");
                                return;

                            }
                            break;
                        case ')':
                            if (opendedSymbols.Pop() != '(')
                            {
                                Console.WriteLine("NO");
                                return;

                            }
                            break;
                    }

                }

                
            }
            Console.WriteLine("YES");
        }
    }
}

