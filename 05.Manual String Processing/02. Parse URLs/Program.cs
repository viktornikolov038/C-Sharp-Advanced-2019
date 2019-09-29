using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Parse_URLs
{
    public class Program
    {
        public static void Main()
        {
            var url = Console.ReadLine();
            var data = url.Split(new[] {"://"}, StringSplitOptions.RemoveEmptyEntries);
            if (data.Length != 2)
            {
                Console.WriteLine("Invalid URL");
                return;
                
            }
            var protocol = data[0];
            if (data[1].IndexOf('/') < 0)
            {
                Console.WriteLine("Invalid URL");
                return;
            }
            var server = data[1].Substring(0, data[1].IndexOf('/'));
            var resourses = data[1].Substring(data[1].IndexOf('/') + 1);
            Console.WriteLine($"Protocol = {protocol}");
            Console.WriteLine($"Server = {server}");
            Console.WriteLine($"Resources = {resourses}");
        }
    }
}
