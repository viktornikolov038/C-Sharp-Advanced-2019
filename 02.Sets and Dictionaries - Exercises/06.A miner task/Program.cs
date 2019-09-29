using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.A_miner_task
{
    public class Program
    {
        public static void Main()
        {
            var mine = new Dictionary<string, long>();
            while (true)
            {
                var resourse = Console.ReadLine();
                if (resourse == "stop")
                {
                    break;
                }

                var quantity = long.Parse(Console.ReadLine());
                if (!mine.ContainsKey(resourse))
                {
                    mine[resourse] = 0l;
                }
                mine[resourse] += quantity;
            }

            foreach (var resourse in mine)
            {
                Console.WriteLine($"{resourse.Key} -> {resourse.Value}");
            }
        }
    }
}
