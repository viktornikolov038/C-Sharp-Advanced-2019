using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3___NMS
{
    public class Program
    {
        public static void Main()
        { 

            var sb =new StringBuilder();
            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "---NMS SEND---")
                {
                    break;
                }
                sb.Append(inputLine);
            }
            var delimer = Console.ReadLine();
            if (delimer == "(space)")
            {
                delimer = " ";
            }
            var result = sb.ToString();
            for (int i = 0; i < result.Length - 1; i++)
            {
                if (string.Compare(result[i].ToString(), result[i + 1].ToString(),StringComparison.OrdinalIgnoreCase) > 0)
                {
                    result = result.Insert(i + 1,delimer);
                    i+= delimer.Length;
                }
            }    
            Console.WriteLine(result);
        }
    }
}
