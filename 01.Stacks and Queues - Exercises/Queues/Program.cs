using System;
using System.Collections.Generic;

namespace Queues
{
    public class Program
    {
        public static void Main()
        {
            var texts = new Queue<string>();

            texts.Enqueue("First");
            texts.Enqueue("Second");
            texts.Enqueue("Third");
            texts.Enqueue("Third");
            texts.Enqueue("Third");
            texts.Enqueue("Third");

            while (texts.Count > 0)
            {
                Console.WriteLine(texts.Dequeue());
            }
            Console.WriteLine(texts.Count);

        }
    }
}
