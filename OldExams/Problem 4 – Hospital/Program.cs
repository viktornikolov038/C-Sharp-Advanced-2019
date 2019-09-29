using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4___Hospital
{
    public class Program
    {
        public static void Main()
        {
            var doctors = new Dictionary<string, List<string>>();
            var departments = new Dictionary<string, List<string>>();

            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "Output")
                {
                    break;
                }
                var tokens = inputLine.Split();
                var currentDepartment = tokens[0];
                var doctorName = tokens[1] + " " + tokens[2];
                var patient = tokens[3];

                if (!doctors.ContainsKey(doctorName))
                {
                    doctors[doctorName] = new List<string>();
                }
                doctors[doctorName].Add(patient);

                if (!departments.ContainsKey(currentDepartment))
                {
                    departments[currentDepartment] = new List<string>();
                }
                if (departments[currentDepartment].Count > 60)
                {
                    continue;
                }
                departments[currentDepartment].Add(patient);


            }
            //var rooms = new Dictionary<string,List<string>>();
            //foreach (var department in departments)
            //{
            //    foreach (var patients in department.Value)
            //    {
            //        if (!rooms.ContainsKey(department.Key))
            //        {
            //            rooms[department.Key] = new List<string>();
            //        }
            //        rooms[department.Key].Add(patients);
            //    }
            //}

            var output = Console.ReadLine();
            while (output != "End")
            {
                if (doctors.ContainsKey(output.Trim()))
                {
                    foreach (var patient in doctors[output.Trim()].OrderBy(a => a))
                    {
                        Console.WriteLine(patient);
                    }
                }
                else if (departments.ContainsKey(output.Trim()))
                {
                    foreach (var pacient in departments[output.Trim()])
                    {
                        Console.WriteLine(pacient);
                    }
                }
                else
                {
                    var spitedOutput = output.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    var departamentName = spitedOutput[0];
                    var roomNumber = int.Parse(spitedOutput[1]);
                    var currentRoom = new List<string>();
                    for (int i = (roomNumber - 1) * 3; i < roomNumber * 3; i++)
                    {
                        currentRoom.Add(departments[departamentName][i]);

                    }
                    foreach (var patient in currentRoom.OrderBy(a => a))
                    {
                        Console.WriteLine(patient);
                    }
                }
                output = Console.ReadLine();
            }
        }
    }
}
