using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4___Champion_s_League
{
    public class Program
    {
        public static void Main()
        {
            var oponents = new Dictionary<string,List<string>>();
            var wins = new Dictionary<string,int>();
            while (true)
            {
                var line = Console.ReadLine();
                if (line == "stop")
                {
                    break;
                }
                var data = line.Split('|');
                var firstTeam = data[0].Trim();
                var secondTeam = data[1].Trim();

                if (!oponents.ContainsKey(firstTeam))
                {
                    oponents[firstTeam] = new List<string>();
                }
                if (!oponents.ContainsKey(secondTeam))
                {
                    oponents[secondTeam] = new List<string>();
                }

                if (!wins.ContainsKey(firstTeam))
                {
                    wins[firstTeam] = 0;
                }
                if (!wins.ContainsKey(secondTeam))
                {
                    wins[secondTeam] = 0;
                }

                oponents[firstTeam].Add(secondTeam);
                oponents[secondTeam].Add(firstTeam);
                var firstScore = data[2].Trim();
                var secondScore = data[3].Trim();

                var firstScoreSplited = firstScore.Split(':');
                var secondScoreSplited = secondScore.Split(':');
                var firstTeamHome = int.Parse(firstScoreSplited[0]);
                var firstTeamAway= int.Parse(secondScoreSplited[1]);
                var secondTeamHome = int.Parse(secondScoreSplited[0]);
                var secondTeamAway = int.Parse(firstScoreSplited[1]);


                var firstTeamTotal = firstTeamHome + firstTeamAway;
                var secondTeamTotal = secondTeamHome + secondTeamAway;

                if (firstTeamTotal > secondTeamTotal)
                {
                    wins[firstTeam]++;
                }else if (firstTeamTotal < secondTeamTotal)
                {
                    wins[secondTeam]++;
                }
                else
                {
                    if (firstTeamAway > secondTeamAway)
                    {
                        wins[firstTeam]++;
                    }
                    else
                    {
                        wins[secondTeam]++;
                    }
                }
            }

            wins = wins.OrderByDescending(w => w.Value).ThenBy(w => w.Key).ToDictionary(w => w.Key, w => w.Value);
            foreach (var team in wins)
            {
                Console.WriteLine(team.Key);
                Console.WriteLine($"- Wins: {team.Value}");
                Console.WriteLine($"- Opponents: {string.Join(", ",oponents[team.Key].OrderBy(x => x))}");
            }

        }
    }
}
