using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _07.Valid_Time
{
    public class Program
    {
        public static void Main()
        {
            var pattern = @"^(\d{2}):(\d{2}):(\d{2}) ((AM)|(PM))$";
            var regex = new Regex(pattern);
            while (true)
            {
                var timeInput = Console.ReadLine();
                if (timeInput == "END")
                {
                    break;
                }
                var match = regex.Match(timeInput);
                if (match.Success)
                {
                    var hours = int.Parse(match.Groups[1].ToString());
                    var minutes = int.Parse(match.Groups[2].ToString());
                    var secounds = int.Parse(match.Groups[3].ToString());
                    if (hours < 0 || hours > 12 || minutes < 0 || minutes > 59 || secounds < 0 || secounds > 59)
                    {
                        Console.WriteLine("invalid");
                        continue;
                    }
                    Console.WriteLine("valid");
                    continue;
                }
                Console.WriteLine("invalid");
            }
        }
    }
}
