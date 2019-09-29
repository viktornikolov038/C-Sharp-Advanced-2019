using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.Sum_big_numbers
{
    public class Program
    {
        public static void Main()
        {
            BigInteger n1 = BigInteger.Parse(Console.ReadLine());
            BigInteger n2 = BigInteger.Parse(Console.ReadLine());
            BigInteger sum = n1 + n2;
            Console.WriteLine(sum);
        }
    }
}
