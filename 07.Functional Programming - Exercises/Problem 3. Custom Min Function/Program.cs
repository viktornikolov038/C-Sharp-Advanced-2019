using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Custom_Min_Function
{
    public class Program
    {
        public static void Main()
        {

            var input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            //Func<int[], int> f = delegate(int[] s)
            //{
            //    int result = int.MaxValue;

            //    foreach (var number in s)
            //    {
            //        if (result >= number)
            //        {
            //            result = number;
            //        }
            //    }

            //    return result;
            //};

            //Console.WriteLine(f(input));
            Func<int[],int> printSmallest = n => n.OrderBy(i => i).ToArray().First();
            Console.WriteLine(printSmallest(input));
            
        }
    }
}
