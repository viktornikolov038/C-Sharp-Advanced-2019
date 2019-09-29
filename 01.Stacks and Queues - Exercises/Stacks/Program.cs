using System;
using System.Collections.Generic;

namespace Stacks
{
    public class Program
    {
        public static void Main()
        {
            var numbers = new Stack<int>();

            numbers.Push(5);
            numbers.Push(10);
            numbers.Push(2);

            int currentNumber = numbers.Peek();
            int lastNumber = numbers.Pop();

            Console.WriteLine(lastNumber);
            currentNumber = numbers.Peek();
            Console.WriteLine(currentNumber);

            var numbersAsArray = numbers.ToArray();
            Console.WriteLine("///");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }


            
        }
    }
}
