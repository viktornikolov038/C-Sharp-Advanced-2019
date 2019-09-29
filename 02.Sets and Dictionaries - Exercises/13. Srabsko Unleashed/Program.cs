using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _13.Srabsko_Unleashed
{
    public class Program
    {
        public static void Main()
        {
            var result = new Dictionary<string,Dictionary<string,long>>();

            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "End")
                {
                    break;
                }

                var tokens = inputLine.Split(' ');

                string pattern = @"(.*?) @(.*?) (\d+) (\d+)";
                if (!Regex.IsMatch(inputLine, pattern))
                {
                    inputLine = Console.ReadLine();
                    continue;
                }


                var leftAndRightPart = inputLine.Split('@');

                var currentSinger = leftAndRightPart[0];
                var venueAndTickest = leftAndRightPart[1].Split();
                if (venueAndTickest.Length < 3 || venueAndTickest.Length > 5)
                {
                    continue;
                    
                }

                
                var ticketsPrice = long.Parse(venueAndTickest[venueAndTickest.Length - 1]);
                var ticketsCount = long.Parse(venueAndTickest[venueAndTickest.Length - 2]);
                
                var venueLenght = venueAndTickest.Length - 2;
                
                var venueAsStringBuilder = new StringBuilder();
                for (int i = 0; i < venueLenght; i++)
                {
                    venueAsStringBuilder.Append(venueAndTickest[i] + " ");
                }
                var currentVenue = venueAsStringBuilder.ToString().TrimEnd();

                

                


                if (!result.ContainsKey(currentVenue))
                {
                    result[currentVenue] = new Dictionary<string, long>();
                }

                if (!result[currentVenue].ContainsKey(currentSinger))
                {
                    result[currentVenue][currentSinger] = 0l;
                }
                result[currentVenue][currentSinger] += ticketsPrice * ticketsCount;

            }

            foreach (var venue in result)
            {
                Console.WriteLine(venue.Key);
                var orderedDic = result[venue.Key].OrderByDescending(s => s.Value);
                foreach (var singer in orderedDic)
                {
                    Console.WriteLine($"#  {singer.Key}-> {singer.Value}");
                }
            }
        }
    }
}
