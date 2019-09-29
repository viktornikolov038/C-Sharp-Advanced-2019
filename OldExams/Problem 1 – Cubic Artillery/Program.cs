using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1___Cubic_Artillery
{
    public class Program
    {
        public static void Main()
        {
            var maxCapacity = int.Parse(Console.ReadLine());
            var bunkers = new Queue<string>();
            var weapons = new Queue<int>();
            var leftCapacity = maxCapacity;
            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "Bunker Revision")
                {
                    break;
                }

                var tokens = inputLine.Split(' ');
                foreach (var element in tokens)
                {
                    int currentWeapon;
                    var isDigit = int.TryParse(element, out currentWeapon);
                    if (!isDigit)
                    {
                        bunkers.Enqueue(element);
                    }
                    else
                    {
                        var isSaved = false;
                        while (bunkers.Count > 1)
                        {
                            if (leftCapacity >= currentWeapon)
                            {
                                weapons.Enqueue(currentWeapon);
                                leftCapacity -= currentWeapon;
                                isSaved = true;
                                break;
                            }
                            else
                            {
                                var removedBunker = bunkers.Dequeue();
                                if (weapons.Any())
                                {
                                    Console.WriteLine($"{removedBunker} -> {string.Join(", ",weapons)}");
                                }
                                else
                                {
                                    Console.WriteLine($"{removedBunker} -> Empty");
                                }
                                
                                weapons.Clear();
                                leftCapacity = maxCapacity;
                            }

                        }
                        // when its left only 1 bunker
                        if (!isSaved)
                        {
                            if (currentWeapon <= maxCapacity)
                            {
                                while (leftCapacity < currentWeapon)
                                {
                                    leftCapacity += weapons.Dequeue();
                                }
                                
                                weapons.Enqueue(currentWeapon);
                                leftCapacity -= currentWeapon;
                            }
                        }
                    }
                }

            }
        }
    }
}
