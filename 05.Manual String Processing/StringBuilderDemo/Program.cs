using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderDemo
{
    public class Program
    {
        public static void Main()
        {
            var sb = new StringBuilder();
            var kit = "";
            for (int i = 0; i < 3; i++)
            {
                sb.Append("KIT");
            }
            kit += "ivan";
            sb[1] = 'a';
            try
            {
                sb[50] = 'a';
            }
            catch (Exception e)
            {
                Console.WriteLine("po poleka");
                
            }
            sb.Length = 3;
            Console.WriteLine(sb);
        }
    }
}
