﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Hot_Potato
{
    public class Program
    {
        public static void Main()
        {
            var childern = Console.ReadLine().Split(' ');
            var n = int.Parse(Console.ReadLine());

            var queue = new Queue<string>(childern);
            //Mimi Pepi Toshko
            int cycle = 1;
            while (queue.Count != 1)
            {
                for (int i = 1; i < n; i++)
                {

                    queue.Enqueue(queue.Dequeue());
                }
                if (IsPrime(cycle))
                {
                    Console.WriteLine($"Prime {queue.Peek()}");
                }
                else
                {
                    Console.WriteLine($"Removed {queue.Dequeue()}");
                }
                cycle++;

            }

            Console.WriteLine($"Last is {queue.Dequeue()}");
        }


        public static bool IsPrime(int candidate)
        {
            // Test whether the parameter is a prime number.
            if ((candidate & 1) == 0)
            {
                if (candidate == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            // Note:
            // ... This version was changed to test the square.
            // ... Original version tested against the square root.
            // ... Also we exclude 1 at the end.
            for (int i = 3; (i * i) <= candidate; i += 2)
            {
                if ((candidate % i) == 0)
                {
                    return false;
                }
            }
            return candidate != 1;

        }
    }
}
