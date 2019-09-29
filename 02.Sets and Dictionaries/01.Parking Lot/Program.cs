using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Parking_Lot
{
    class Program
    {
        static void Main()
        {
            var garage = new SortedSet<string>();
            while (true)
            {
                var line = Console.ReadLine();

                if (line == "END")
                {
                    break;
                }
                var tokens = line.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                var direction = tokens[0];
                var carNumber = tokens[1];
                if (direction == "IN")
                {
                    garage.Add(carNumber);
                }
                else if (direction == "OUT")
                {
                    garage.Remove(carNumber);
                }
            }
            if (garage.Any())
            {
                foreach (var car in garage)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            }
        }
    }
