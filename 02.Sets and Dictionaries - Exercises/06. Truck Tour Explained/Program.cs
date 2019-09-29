using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Truck_Tour_Explained
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var petrolStationsNumber = int.Parse(Console.ReadLine());
            var petrolStations = new Queue<int[]>();
            for (int i = 0; i < petrolStationsNumber; i++)
            {
                var currentStation = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                petrolStations.Enqueue(currentStation);

            }

            var reachFinal = false;
            var startingIndex = 0;
            while (!reachFinal)
            {
                var totalPetrol = 0;
                
                for (int i = 0; i <= petrolStationsNumber; i++)
                {
                    if (i == petrolStationsNumber)
                    {
                        reachFinal = true;
                    }
                    var petrolStation = petrolStations.Dequeue();
                    petrolStations.Enqueue(petrolStation);

                    var liters = petrolStation[0];
                    var distanceToNext = petrolStation[1];
                    totalPetrol += liters - distanceToNext;
                    
                    if (totalPetrol < 0)
                    {
                        startingIndex += i + 1; 
                        break;
                    }
                }
            }
            Console.WriteLine(startingIndex);
        }
    }
}
