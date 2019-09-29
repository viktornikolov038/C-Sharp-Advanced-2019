using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_1
{
    public class Program
    {
        public static void Main()
        {
            //var a = "This is Text text";
            //var b = "This is another text";
            //var pattern = "text";
            //var result = a.IndexOf(pattern,StringComparison.OrdinalIgnoreCase);
            //var stringa = a.Substring(5,1);
            //Console.WriteLine(stringa);
            //Console.WriteLine(result);


            var text = "text";
            text = text.PadRight(text.Length * 2, '*').PadLeft(text.Length * 3, '#');
            Console.WriteLine(text);
        }
    }
}
