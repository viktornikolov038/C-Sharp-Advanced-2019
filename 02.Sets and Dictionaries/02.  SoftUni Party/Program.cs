using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SoftUni_Party
{
    public class Program
    {
        public static void Main()
        {
            var VipGuests = new SortedSet<string>();
            var regularGuests = new SortedSet<string>();
            while (true)
            {
                var line = Console.ReadLine();
                if (line == "PARTY")
                {
                    break;
                }
                
                if (char.IsDigit(line[0]) && line.Length == 8)
                {
                    VipGuests.Add(line);
                }
                else if (line.Length == 8)
                {
                    regularGuests.Add(line);
                }
                
            }

            while (true)
            {
                var line = Console.ReadLine();
                if (line == "END")
                {
                    break;
                }

                if (VipGuests.Contains(line))
                {
                    VipGuests.Remove(line);
                }
                else if (regularGuests.Contains(line))
                {
                    regularGuests.Remove(line);
                }
            }

            Console.WriteLine(VipGuests.Count + regularGuests.Count);
            foreach (var vip in VipGuests)
            {
                Console.WriteLine(vip);
            }
            foreach (var guest in regularGuests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}

