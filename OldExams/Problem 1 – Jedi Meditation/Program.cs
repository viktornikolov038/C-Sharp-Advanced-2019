using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Problem_1___Jedi_Meditation
{
    public class Program
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var master = new Queue<string>();
            var knight = new Queue<string>();
            var padawan = new Queue<string>();
            var toshkoAndSlaw = new Queue<string>();
            //var yodas = new Queue<string>();
            var yoda = false;
            for (int i = 0; i < n; i++)
            {
                var inputLine = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (var jedi in inputLine)
                {
                    if (jedi[0] == 'm')
                    {
                        master.Enqueue(jedi);
                    }
                    else if (jedi[0] == 'k')
                    {
                        knight.Enqueue(jedi);
                    }
                    else if (jedi[0] == 'p')
                    {
                        padawan.Enqueue(jedi);
                    }
                    else if (jedi[0] == 't' || jedi[0] == 's')
                    {
                        toshkoAndSlaw.Enqueue(jedi);
                    }
                    else if (jedi[0] == 'y')
                    {
                        //yodas.Enqueue(jedi);
                        yoda = true;
                    }
                }
            }
            var result = new StringBuilder();
            if (yoda)
            {

                while (master.Any())
                {
                    result.Append(master.Dequeue()).Append(" ");
                }
                while (knight.Any())
                {
                    result.Append(knight.Dequeue()).Append(" ");
                }
                while (toshkoAndSlaw.Any())
                {
                    result.Append(toshkoAndSlaw.Dequeue()).Append(" ");
                }
                while (padawan.Any())
                {
                    result.Append(padawan.Dequeue()).Append(" ");
                }
            }
            else
            {
                while (toshkoAndSlaw.Any())
                {
                    result.Append(toshkoAndSlaw.Dequeue()).Append(" ");
                }
                while (master.Any())
                {
                    result.Append(master.Dequeue()).Append(" ");
                }
                while (knight.Any())
                {
                    result.Append(knight.Dequeue()).Append(" ");
                }

                while (padawan.Any())
                {
                    result.Append(padawan.Dequeue()).Append(" ");
                }
            }

            Console.WriteLine(result.ToString());
        }
    }
}
