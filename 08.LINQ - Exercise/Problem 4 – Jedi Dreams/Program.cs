using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem_4___Jedi_Dreams
{
    public class Program
    {
        public static void Main()
        {                             /*\Methods       count     invokedMethods*/
            var result = new Dictionary<string,Dictionary<int,List<string>>>();
            var n = int.Parse(Console.ReadLine());
            var staticMethodsRegex = new Regex("Start of numbers(.*)End of numbers",
                RegexOptions.IgnoreCase | RegexOptions.Singleline);
            var fullCode = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                var inputLine = Console.ReadLine();
                fullCode.Append(inputLine);
            }

            var matches = staticMethodsRegex.Matches(fullCode.ToString());
            int debug = 0;
            //static.*\s+(\{(\s+)\})
        }
    }
}
